using System.ComponentModel.DataAnnotations;

namespace NotificationApi.DTO
{
    public class SystemUserMasterDTO
    {

        [Required]
        public string EmpId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
