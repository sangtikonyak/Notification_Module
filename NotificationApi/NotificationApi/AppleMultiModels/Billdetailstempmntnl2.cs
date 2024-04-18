using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Billdetailstempmntnl2
    {
        public string Billnumber { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string? Emailid { get; set; }
        public string Paymentmode { get; set; } = null!;
        public string? Name { get; set; }
        public string? Coradr { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Username { get; set; }
        public DateTime? Connectiondate { get; set; }
        public DateTime? Billdate { get; set; }
        public decimal? Billcycleid { get; set; }
        public DateTime? Billstartdate { get; set; }
        public DateTime? Billenddate { get; set; }
        public string Billplanid { get; set; } = null!;
        public string? Packagename { get; set; }
        public double? Extrachargespermb { get; set; }
        public double? Cyclecharges { get; set; }
        public double? Daysbilled { get; set; }
        public double? Otrc { get; set; }
        public double? Securitydeposit { get; set; }
        public double? Extraofclength { get; set; }
        public double? Extraofccharges { get; set; }
        public double? Extracat5length { get; set; }
        public double? Extracat5charges { get; set; }
        public double? Dta { get; set; }
        public double? Alloweddta { get; set; }
        public double? Actualdatatransfer { get; set; }
        public double? Extradatatransfer { get; set; }
        public double? Extradatatransfercharges { get; set; }
        public double? Proratedcyclecharges { get; set; }
        public double? Currentcyclecharges { get; set; }
        public double? Totalcharges { get; set; }
        public double? Arrears { get; set; }
        public double? Otrcdiscount { get; set; }
        public double? Waivers { get; set; }
        public double? Persistentwaiver { get; set; }
        public double? Payments { get; set; }
        public double? Netpayable { get; set; }
        public double? Othercharges { get; set; }
        public double? Servicetax { get; set; }
        public string? Usergstin { get; set; }
        public double? Cgst { get; set; }
        public double? Sgst { get; set; }
        public double? Igst { get; set; }
        public double? Securitydepositdiscount { get; set; }
        public double? Totaloutstanding { get; set; }
        public DateTime? Lastdateofpayment { get; set; }
        public string? Firstbill { get; set; }
        public string? OtherChargesRemarks { get; set; }
        public string? WaiversRemarks { get; set; }
        public bool? Pdfgenerated { get; set; }
        public double? Totaloutstandingwithlatefine { get; set; }
        public string? Location { get; set; }
    }
}
