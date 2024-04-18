using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfInvoice
    {
        public string Invoiceid { get; set; } = null!;
        public string Linkid { get; set; } = null!;
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
        public double? Cyclecharges { get; set; }
        public double? Daysbilled { get; set; }
        public double? Currentcharges { get; set; }
        public double? Servicetax { get; set; }
        public double? Arrears { get; set; }
        public double? Waivers { get; set; }
        public double? Totaloutstanding { get; set; }
        public DateTime? Lastdateofpayment { get; set; }
    }
}
