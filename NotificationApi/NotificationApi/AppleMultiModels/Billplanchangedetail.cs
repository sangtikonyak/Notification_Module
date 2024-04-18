using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Billplanchangedetail
    {
        public string Userid { get; set; } = null!;
        public string? Oldbillplanid { get; set; }
        public string? Newbillplanid { get; set; }
        public string? Newpaymentmode { get; set; }
        public int Fromcycleid { get; set; }
        public DateTime? Fromdate { get; set; }
        public string? Changeaffected { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Oldpaymentmode { get; set; }
        public decimal? Securitydepositdeclared { get; set; }
    }
}
