using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class PsmPowercheckstatus
    {
        public string Popid { get; set; } = null!;
        public string? Popname { get; set; }
        public string? Gridcheck { get; set; }
        public string? Batterycheck { get; set; }
        public int? Powerstate { get; set; }
        public DateTime? Modon { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
