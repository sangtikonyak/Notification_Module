using System;
using System.Collections.Generic;

namespace NotificationApi.DBModels
{
    public partial class User
    {
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public byte[] PasswordKey { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
    }
}
