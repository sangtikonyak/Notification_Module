using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Tempsessiondetail
    {
        public decimal Rownum { get; set; }
        public string? Userid { get; set; }
        public string? Username { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Stoptime { get; set; }
        public decimal? Billcycleid { get; set; }
        public string? Billcycletype { get; set; }
        public string? Clientip { get; set; }
        public string? Snatip { get; set; }
        public double? Downloadbytes { get; set; }
        public double? Uploadbytes { get; set; }
        public double? Totalbytes { get; set; }
        public string? Date { get; set; }
        public decimal? Time { get; set; }
        public string? Usedtime { get; set; }
        public string? Isselfduplicate { get; set; }
        public string? Isduplicate { get; set; }
        public string? Ismerged { get; set; }
        public string? Issplit { get; set; }
    }
}
