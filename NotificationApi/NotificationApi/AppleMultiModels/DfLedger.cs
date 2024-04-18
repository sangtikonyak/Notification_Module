using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfLedger
    {
        public string Accountid { get; set; } = null!;
        public string? Linkid { get; set; }
        public string? Narration { get; set; }
        public double? Dr { get; set; }
        public double? Cr { get; set; }
        public string? Instrumentid { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
