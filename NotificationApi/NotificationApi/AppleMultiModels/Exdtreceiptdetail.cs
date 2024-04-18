using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Exdtreceiptdetail
    {
        public string? Transactionid { get; set; }
        public string Userid { get; set; } = null!;
        public string Receiptnumber { get; set; } = null!;
        public double? Amount { get; set; }
        public string? Instrument { get; set; }
        public string? Chequenoandbank { get; set; }
        public string? Remarks { get; set; }
        public DateTime? Paymentdate { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
