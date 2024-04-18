using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Regotrcplan
    {
        public string Otrcid { get; set; } = null!;
        public string? Otrcname { get; set; }
        public double? Securitydeposit { get; set; }
        public double? Otrcdownpayment { get; set; }
        public string? Locations { get; set; }
        public string? Status { get; set; }
        public short? WaiverRental1Percentage { get; set; }
        public short? WaiverRental2Percentage { get; set; }
        public short? WaiverRental3Percentage { get; set; }
        public short? WaiverRental4Percentage { get; set; }
        public short? WaiverRental5Percentage { get; set; }
        public short? WaiverRental6Percentage { get; set; }
        public double? Otrcm2 { get; set; }
        public double? Otrcm3 { get; set; }
        public double? Otrcm4 { get; set; }
        public double? Otrcm5 { get; set; }
        public double? Otrcm6 { get; set; }
        public double? Otrcm7 { get; set; }
        public double? Otrcm8 { get; set; }
        public double? Otrcm9 { get; set; }
        public double? Otrcm10 { get; set; }
        public double? Otrcm11 { get; set; }
        public double? Otrcm12 { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Remarks { get; set; }
    }
}
