using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Syseventlog
    {
        public decimal Logid { get; set; }
        public string? Event { get; set; }
        public string? Userid { get; set; }
        public string? Systemuserid { get; set; }
        public DateTime? Modon { get; set; }
    }
}
