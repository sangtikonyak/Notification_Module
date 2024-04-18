using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Systemusermaster
    {
        public string Empid { get; set; } = null!;
        public string? Locationrights { get; set; }
        public string? Modulerights { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Designation { get; set; }
        public string? Password { get; set; }
        public DateTime? Dob { get; set; }
        public double? Mobilenum { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Emailid { get; set; }
        public bool? Forgotpassword { get; set; }
        public decimal? Priv { get; set; }
        public double? Whatsappno { get; set; }
    }
}
