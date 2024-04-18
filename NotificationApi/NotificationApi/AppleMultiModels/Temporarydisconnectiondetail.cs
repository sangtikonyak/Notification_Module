using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Temporarydisconnectiondetail
    {
        public string? Userid { get; set; }
        public DateTime? Startdate { get; set; }
        public string? Enddate { get; set; }
        public string? Tfn { get; set; }
        public string? Reactivationflag { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
    }
}
