using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class DfBillinginfo
    {
        public string Linkid { get; set; } = null!;
        public string Billplanid { get; set; } = null!;
        public string Billingmode { get; set; } = null!;
        public string? Billflag { get; set; }
    }
}
