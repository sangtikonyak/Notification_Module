using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Wadtemp
    {
        public int Id { get; set; }
        public string Userid { get; set; } = null!;
        public double Waiver { get; set; }
        public double? Arrear { get; set; }
        public string? Dnb { get; set; }
        public decimal Cycleid { get; set; }
        public DateTime? Modon { get; set; }
        public string? Modby { get; set; }
        public string? Remarks { get; set; }
    }
}
