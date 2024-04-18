using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Fibermaintenance
    {
        public string Teammembers { get; set; } = null!;
        public string Startlocation { get; set; } = null!;
        public string Endlocation { get; set; } = null!;
        public DateTime Dateofmaintenance { get; set; }
        public string? Status { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
