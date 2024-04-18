using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfReceiptdetail
    {
        public decimal Transactionid { get; set; }
        public string? Accountid { get; set; }
        public string? Linkid { get; set; }
        public string? Receiptid { get; set; }
        public string Receiptnumber { get; set; } = null!;
        public double? Amount { get; set; }
        public string? Paymentmode { get; set; }
        public string? Chequenoandbank { get; set; }
        public DateTime? Paymentdate { get; set; }
        public decimal? Invoiceid { get; set; }
        public string? Remarks { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
