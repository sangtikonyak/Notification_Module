using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Subscriberledger
    {
        public decimal Transactionid { get; set; }
        public string Userid { get; set; } = null!;
        public string? Specifications { get; set; }
        public double? Dr { get; set; }
        public double? Cr { get; set; }
        public string? Exdtpayment { get; set; }
        public string? Instrumentid { get; set; }
        public string? Modby { get; set; }
        public DateTime? Transactiondate { get; set; }
        public DateTime? Modon { get; set; }
    }
}
