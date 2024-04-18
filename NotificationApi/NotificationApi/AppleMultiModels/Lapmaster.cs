using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Lapmaster
    {
        public int Lapid { get; set; }
        public string Lapname { get; set; } = null!;
        public string? Lapaddress { get; set; }
        public string? Laparea { get; set; }
        public string Lapadmincontact1 { get; set; } = null!;
        public string? Lapadmincontact2 { get; set; }
        public string Laptechcontact1 { get; set; } = null!;
        public string Lapbillingcontact1 { get; set; } = null!;
        public string Lapbillingcontact2 { get; set; } = null!;
        public string Lapstatus { get; set; } = null!;
        public string Lapadminemailid { get; set; } = null!;
        public string Laptechemailid { get; set; } = null!;
        public string? Lapbillingemailid { get; set; }
        public string Modby { get; set; } = null!;
        public DateTime Modon { get; set; }
    }
}
