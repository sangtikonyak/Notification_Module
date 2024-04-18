using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Mailnotification
    {
        public int Id { get; set; }
        public string? Event { get; set; }
        public string? Toname { get; set; }
        public string? Toemails { get; set; }
        public string Ccemails { get; set; } = null!;
        public string Locationcode { get; set; } = null!;
    }
}
