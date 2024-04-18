using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Agentmaster
    {
        public string Agentcode { get; set; } = null!;
        public string? Agentname { get; set; }
        public string? Contactnumber { get; set; }
        public string? Address { get; set; }
        public string? Status { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
