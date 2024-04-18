using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class SmsserviceRequest
    {
        public int ServiceRequestId { get; set; }
        public string? RequestMessage { get; set; }
        public string? Issueid { get; set; }
        public int? ReceivedId { get; set; }
        public short AccountNumber { get; set; }
        public long MobileNumber { get; set; }
        public DateTime FirstReceivedTime { get; set; }
        public DateTime ModOn { get; set; }
        public string? Status { get; set; }
    }
}
