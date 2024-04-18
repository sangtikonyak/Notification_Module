using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Powerstatus
    {
        public string Popid { get; set; } = null!;
        public string? Popname { get; set; }
        public string? Gridcheck { get; set; }
        public string? Batterycheck { get; set; }
        public int? Prevstate { get; set; }
        public int? Currstate { get; set; }
        public string? Alertrequired { get; set; }
        public string? Alertsent { get; set; }
        public string? Lastalertsentdatetime { get; set; }
    }
}
