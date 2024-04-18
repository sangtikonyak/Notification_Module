using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Creditnote
    {
        public int Id { get; set; }
        public string Userid { get; set; } = null!;
        public double Creditamount { get; set; }
        public DateTime? Modon { get; set; }
        public string? Modby { get; set; }
        public string Billnumber { get; set; } = null!;
        public string? Narration { get; set; }
        public string? Creditnoteid { get; set; }
    }
}
