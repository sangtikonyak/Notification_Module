using NotificationApi.DTO;

namespace NotificationApi.Repository
{
    public interface IAuthService
    {
        Task<string> Login(SystemUserMasterDTO systemUserMasterDTO);
    }
}
