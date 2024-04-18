using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Servicerequestlog
    {
        public string? Issueid { get; set; }
        public string? Actiontaken { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Callbooknumber { get; set; }
        public string? Status { get; set; }
        public DateTime? Createdtimestamp { get; set; }
    }
}
