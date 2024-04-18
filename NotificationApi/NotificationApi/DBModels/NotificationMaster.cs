using System;
using System.Collections.Generic;

namespace NotificationApi.DBModels
{
    public partial class NotificationMaster
    {
        public NotificationMaster()
        {
            NotificationDetails = new HashSet<NotificationDetail>();
        }

        public int NotificationMasterId { get; set; }
        public string TemplateName { get; set; } = null!;
        public string? TemplateMessage { get; set; }
        public string TimeStamp { get; set; } = null!;
        public bool IsNotificationSent { get; set; }
        public string SentBy { get; set; } = null!;

        public virtual ICollection<NotificationDetail> NotificationDetails { get; set; }
    }
}
