using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Userstatuslog
    {
        public int Logid { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Remarks { get; set; }
        public string Status { get; set; } = null!;
        public string Modby { get; set; } = null!;
        public DateTime? Modon { get; set; }
    }
}
