using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Issuescategory
    {
        public int Id { get; set; }
        public string Issuetitle { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
