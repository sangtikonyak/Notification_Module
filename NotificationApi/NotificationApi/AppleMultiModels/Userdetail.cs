using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Userdetail
    {
        public string Userid { get; set; } = null!;
        public decimal? LatitudeInstallation { get; set; }
        public decimal? LongitudeInstallation { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? Modon { get; set; }
        public string? Modby { get; set; }
    }
}
