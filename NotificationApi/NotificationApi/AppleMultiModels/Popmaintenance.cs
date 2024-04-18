using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Popmaintenance
    {
        public string Popid { get; set; } = null!;
        public string? Manualmetercharge { get; set; }
        public string? Batterystatus { get; set; }
        public string? Inverterchargingstatus { get; set; }
        public string? Replacement { get; set; }
        public DateTime? Dateofmaintenance { get; set; }
        public string? Remarks { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
