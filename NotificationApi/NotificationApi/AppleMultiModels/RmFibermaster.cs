using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class RmFibermaster
    {
        public int Trunkid { get; set; }
        public int? Parentmediaid { get; set; }
        public string? Mediatype { get; set; }
        public decimal? Fibercount { get; set; }
        public string? Address { get; set; }
        public decimal? Lengthfromparent { get; set; }
        public string? Terminationname { get; set; }
        public string? Coredetails { get; set; }
        public string? Isroot { get; set; }
        public string? Isclient { get; set; }
        public string? Userid { get; set; }
        public string? Ispop { get; set; }
        public string? Popid { get; set; }
        public string? Istrunk { get; set; }
        public int? Icon { get; set; }
        public int? Selicon { get; set; }
    }
}
