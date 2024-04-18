using System;
using System.Collections.Generic;

namespace NotificationApi.DBModels
{
    public partial class NotificationDetail
    {
        public int NotificationDetailsId { get; set; }
        public string WhatsAppNumber { get; set; } = null!;
        public string InvalidWhatsappNumbers { get; set; } = null!;
        public string Error { get; set; } = null!;
        public int NotificationMasterId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime Date { get; set; }

        public virtual NotificationMaster NotificationMaster { get; set; } = null!;
    }
}
