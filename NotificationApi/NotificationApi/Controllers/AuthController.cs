using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotificationApi.CustomExceptions;
using NotificationApi.DTO;
using NotificationApi.Repository;

namespace NotificationApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login([FromBody] SystemUserMasterDTO systemUserMasterDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { status = 404, error = new { message = "invalid post body" } });
            }

            try
            {
                string jwt = await _authService.Login(systemUserMasterDTO);
                return Ok(new { status = 200, message = "Login Success", data = new { token = jwt } });
            }
            catch (InvalidCredentialsException)
            {
                return StatusCode(401, new { status = 401, error = new { message = "Invalid Password" } });
            }catch (Exception e)
            {
                return StatusCode(500, new { status = 500, error = new { message = e.Message } });
            }
        }
    }
}
