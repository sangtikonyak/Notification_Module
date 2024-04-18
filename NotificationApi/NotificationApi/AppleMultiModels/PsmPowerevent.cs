using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class PsmPowerevent
    {
        public decimal Eventid { get; set; }
        public string Popid { get; set; } = null!;
        public DateTime? Startdatetime { get; set; }
        public DateTime? Stopdatetime { get; set; }
        public int? Eventstate { get; set; }
        public string? Eventstatus { get; set; }
    }
}
