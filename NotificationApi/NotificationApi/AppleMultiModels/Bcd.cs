using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Bcd
    {
        public string Billcyclename { get; set; } = null!;
        public string Billnumber { get; set; } = null!;
        public DateTime Billdate { get; set; }
        public string Userid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Mobilenumber { get; set; } = null!;
        public string Emailid { get; set; } = null!;
        public string Correspondenceaddress { get; set; } = null!;
        public string? Usergstin { get; set; }
        public string IsFirstBillFalseOrTrue { get; set; } = null!;
        public string Packagename { get; set; } = null!;
        public string Billplanid { get; set; } = null!;
        public string CycleCharges { get; set; } = null!;
        public string Arrears { get; set; } = null!;
        public string SecurityDeposit { get; set; } = null!;
        public string? Cgst { get; set; }
        public string? Sgst { get; set; }
        public string? ServicetaxPregst { get; set; }
        public string Waivers { get; set; } = null!;
        public string Totaloutstanding { get; set; } = null!;
        public string AmountWithLateFineAfterDueDate { get; set; } = null!;
        public DateTime Lastdateofpayment { get; set; }
        public string Instrument { get; set; } = null!;
        public string Paidamount { get; set; } = null!;
        public DateTime? Paymentdate { get; set; }
        public string Receiptid { get; set; } = null!;
    }
}
