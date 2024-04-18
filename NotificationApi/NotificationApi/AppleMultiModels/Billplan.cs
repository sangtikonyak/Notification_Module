using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Billplan
    {
        public string Billplanid { get; set; } = null!;
        public string? Packagename { get; set; }
        public string? Media { get; set; }
        public string? Ulflag { get; set; }
        public double? Mdta { get; set; }
        public double? Qdta { get; set; }
        public double? Hdta { get; set; }
        public double? Ydta { get; set; }
        public double? Otrc { get; set; }
        public double? Freeofclength { get; set; }
        public double? Extraofcrate { get; set; }
        public double? Freecat5length { get; set; }
        public double? Extracat5rate { get; set; }
        public double? Mrate { get; set; }
        public double? Qrate { get; set; }
        public double? Hrate { get; set; }
        public double? Yrate { get; set; }
        public double? Security { get; set; }
        public double? Extrachargespermb { get; set; }
        public string? Status { get; set; }
        public bool? Fap { get; set; }
        public DateTime Createdon { get; set; }
        public string? Billplanremarks { get; set; }
        public string? Locations { get; set; }
    }
}
