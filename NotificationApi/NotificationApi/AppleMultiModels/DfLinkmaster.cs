using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfLinkmaster
    {
        public string Linkid { get; set; } = null!;
        public string? Accountid { get; set; }
        public string? Branchid { get; set; }
        public string? Billplanid { get; set; }
        public string? Name { get; set; }
        public string? Insadr { get; set; }
        public DateTime? Connectiondate { get; set; }
        public double? Alength { get; set; }
        public double? Ulength { get; set; }
        public string? Jmc { get; set; }
        public string? Otdr { get; set; }
        public string? Status { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
