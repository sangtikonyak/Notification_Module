using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NotificationApi.AppleMultiModels;
using NotificationApi.CustomExceptions;
using NotificationApi.DTO;
using NotificationApi.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NotificationApi.Repository
{
    public class IAuthServiceImpl : IAuthService
    {
        private readonly apple_multilocationsContext _context;
        private readonly IConfiguration _configuration;

        public IAuthServiceImpl(apple_multilocationsContext context, IConfiguration configuration)
        {
            this._context = context;
            _configuration = configuration;
        }
        public async Task<string> Login(SystemUserMasterDTO systemUserMasterDTO)

        {
            try
            {
                Systemusermaster systemusermaster = await _context.Systemusermasters.FirstOrDefaultAsync(sym => sym.Empid.Equals(systemUserMasterDTO.EmpId));
                if (systemusermaster == null)
                {
                    throw new UserNotFoundException("user not found");
                }

                string password = Encryption.Encrypt(systemUserMasterDTO.Password, 20);
                bool isValid = VerifyUser(password, systemusermaster.Password);
                if (!isValid)
                {
                    throw new InvalidCredentialsException("invalid Password");
                }

                string token =  CreateToken(systemusermaster);
                if(string.IsNullOrEmpty(token))
                {
                    throw new Exception("Jwt Not Created");
                }
                return token;
            }catch(Exception e)
            {
                throw;
            }
       
        }

        private bool VerifyUser(string password,string existingPassword)
        {
            return password.Equals(existingPassword);
        }

        private string CreateToken(Systemusermaster usermaster)
        {
            string jwt = "";

            try
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usermaster.Name),
                    new Claim(ClaimTypes.NameIdentifier,usermaster.Empid)

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("Appsettings:Token").Value));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);


                var token = new JwtSecurityToken(
                    claims: claims,

                    signingCredentials: cred,
                    expires: DateTime.Now.AddMinutes(20)
                    );
                jwt = new JwtSecurityTokenHandler().WriteToken(token);

            }
            catch(Exception e)
            {
                throw;
            }
         

            return jwt;
        }
    }
}
