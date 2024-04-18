using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Permanentdisconnectiondetail
    {
        public string Userid { get; set; } = null!;
        public DateTime? Disconnectiondate { get; set; }
        public string? Remarks { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
