using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Powerchecksm
    {
        public string Popid { get; set; } = null!;
        public DateTime? Lastl1sms { get; set; }
        public DateTime? Lastl2sms { get; set; }
        public DateTime? Lastl3sms { get; set; }
    }
}
