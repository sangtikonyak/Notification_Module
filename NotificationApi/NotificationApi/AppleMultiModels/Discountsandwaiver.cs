using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Discountsandwaiver
    {
        public string? Userid { get; set; }
        public double? Otrcdiscount { get; set; }
        public double? Securitydepositdiscount { get; set; }
        public double? Waiver { get; set; }
        public double? Persistentwaiver { get; set; }
    }
}
