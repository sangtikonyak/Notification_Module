using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Receiptdetail
    {
        public string Userid { get; set; } = null!;
        public string? Receiptid { get; set; }
        /// <summary>
        /// auto generated receipt by the the application
        /// </summary>
        public string? Entryreceiptid { get; set; }
        public string? Receiptnumber { get; set; }
        /// <summary>
        /// transaction receipt value like cash receipt number, upi transaction id, online order id etc.
        /// </summary>
        public string? Transactionreceiptid { get; set; }
        public double? Amount { get; set; }
        public string? Instrument { get; set; }
        public string? Chequenoandbank { get; set; }
        public string? Exdtpayment { get; set; }
        public string? Remarks { get; set; }
        public DateTime? Paymentdate { get; set; }
        public decimal? Billcycleid { get; set; }
        public string? Collectionempid { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
