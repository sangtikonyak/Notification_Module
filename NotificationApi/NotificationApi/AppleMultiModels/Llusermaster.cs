using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Llusermaster
    {
        public string CustomerId { get; set; } = null!;
        public string? Location { get; set; }
        public string CustomerName { get; set; } = null!;
        public string? WanIpaddress { get; set; }
        public string? LanIpaddress { get; set; }
        public string? Status { get; set; }
        public string? BandwidthCapacity { get; set; }
        public string? InstallationAddress { get; set; }
        public DateTime? InstallationDate { get; set; }
        public string? PurposeOfLl { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonPhone { get; set; }
        public string? ContactPersonEmail { get; set; }
    }
}
