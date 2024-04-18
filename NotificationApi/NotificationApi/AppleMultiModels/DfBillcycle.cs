using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfBillcycle
    {
        public decimal? Billcycleid { get; set; }
        public string? Billcyclename { get; set; }
        public DateTime? Cyclestartdate { get; set; }
        public DateTime? Cycleenddate { get; set; }
        public string? Isquarterly { get; set; }
        public string? Ishalfyearly { get; set; }
        public string? Isyearly { get; set; }
        public DateTime? Lastdateofpayment { get; set; }
        public string? Billedstatus { get; set; }
    }
}
