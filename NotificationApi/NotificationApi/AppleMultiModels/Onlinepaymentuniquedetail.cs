using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Onlinepaymentuniquedetail
    {
        public string Billnumber { get; set; } = null!;
        public DateTime? Billdate { get; set; }
        public DateTime? Paymentdate { get; set; }
        public string? Receiptid { get; set; }
        public string Receiptnumber { get; set; } = null!;
        public double? Totalcharges { get; set; }
        public double? Servicetax { get; set; }
        public double? Arrears { get; set; }
        public double? Waivers { get; set; }
        public double? Totaloutstanding { get; set; }
        public double? Paidamount { get; set; }
        public string Userid { get; set; } = null!;
        public string? Username { get; set; }
        public string? Emailid { get; set; }
        public string? Name { get; set; }
        public string? Coradr { get; set; }
        public string? Mobilenumber { get; set; }
        public string Billplanid { get; set; } = null!;
        public string? Packagename { get; set; }
    }
}
