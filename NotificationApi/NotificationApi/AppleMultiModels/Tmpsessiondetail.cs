using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Tmpsessiondetail
    {
        public string? Username { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Stoptime { get; set; }
        public string? Clientip { get; set; }
        public string? Snatip { get; set; }
        public decimal? Downloadbytes { get; set; }
        public decimal? Uploadbytes { get; set; }
        public decimal? Totalbytes { get; set; }
        public string? Date { get; set; }
        public decimal? Time { get; set; }
        public string? Usedtime { get; set; }
    }
}
