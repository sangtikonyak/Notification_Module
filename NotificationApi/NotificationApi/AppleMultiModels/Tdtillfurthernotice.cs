using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Tdtillfurthernotice
    {
        public string Userid { get; set; } = null!;
        public DateTime? Startdate { get; set; }
        public double? Waiver { get; set; }
        public string? Reactivationflag { get; set; }
        public string? Remarks { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
