using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Accountmaster
    {
        public string Accountid { get; set; } = null!;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Coradr { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Altmobilenumber { get; set; }
        public string? Landlinenumber { get; set; }
        public string? Emailid1 { get; set; }
        public string? Emailid2 { get; set; }
        public string? Emailid3 { get; set; }
        public string? Status { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
