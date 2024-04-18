using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Billcycle
    {
        public int Id { get; set; }
        public double? Billcycleid { get; set; }
        public string? Billcyclename { get; set; }
        public DateTime? Cyclestartdate { get; set; }
        public DateTime? Cycleenddate { get; set; }
        public string? Isquarterly { get; set; }
        public string? Ishalfyearly { get; set; }
        public string? Isyearly { get; set; }
        public DateTime? Lastdateofpayment { get; set; }
        public string? Billedstatus { get; set; }
        public string? Latefinefired { get; set; }
        public string? Reactivationchargesfired { get; set; }
        public string? Locationcode { get; set; }
        public DateTime? Duedate1 { get; set; }
        public double? Dueamount1 { get; set; }
        public DateTime? Duedate2 { get; set; }
        public double? Dueamount2 { get; set; }
    }
}
