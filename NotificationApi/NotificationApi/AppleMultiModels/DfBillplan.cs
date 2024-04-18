using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfBillplan
    {
        public string Billplanid { get; set; } = null!;
        public string? Packagename { get; set; }
        public double? Rate { get; set; }
        public string? Status { get; set; }
    }
}
