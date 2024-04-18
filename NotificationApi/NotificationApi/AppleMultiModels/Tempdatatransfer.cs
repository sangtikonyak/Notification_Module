using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Tempdatatransfer
    {
        public string? Sl { get; set; }
        public string Username { get; set; } = null!;
        public double? Download { get; set; }
        public double? Upload { get; set; }
        public double? Total { get; set; }
    }
}
