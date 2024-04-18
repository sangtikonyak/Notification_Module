using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Powercheckstatus
    {
        public string Popid { get; set; } = null!;
        public string? Popname { get; set; }
        public string? Gridcheck { get; set; }
        public string? Batterycheck { get; set; }
        public int? Prevstate { get; set; }
        public int? Currstate { get; set; }
    }
}
