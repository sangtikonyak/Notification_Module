using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Morebyte
    {
        public int? Id { get; set; }
        public string? Userid { get; set; }
        public decimal? Morebytes { get; set; }
        public decimal? Servicetax { get; set; }
        public decimal? Sgst { get; set; }
        public decimal? Cgst { get; set; }
        public decimal? Totalamount { get; set; }
        public int? Cycleid { get; set; }
        public string? Remarks { get; set; }
        public DateTime? Activatedon { get; set; }
    }
}
