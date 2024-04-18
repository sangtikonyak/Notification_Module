using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Userbillinginfo
    {
        public string Userid { get; set; } = null!;
        public string Billplanid { get; set; } = null!;
        public string? Billplanidbeforeforced { get; set; }
        public string Paymentmode { get; set; } = null!;
        public decimal? Extraofclength { get; set; }
        public decimal? Extracat5length { get; set; }
        public string? Billflag { get; set; }
        public decimal? Securityamount { get; set; }
        public DateTime? Billstartdate { get; set; }
        public DateTime? Billenddate { get; set; }
        public DateTime? Modifiedon { get; set; }
        public double? Outstanding { get; set; }
    }
}
