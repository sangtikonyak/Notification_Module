using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class LinkDownTime
    {
        public int Id { get; set; }
        public int LinkId { get; set; }
        public string CutLocationCoordinates { get; set; } = null!;
        public DateTime DownDateTime { get; set; }
        public DateTime UpDateTime { get; set; }
        public int DowntimeHours { get; set; }
        public string Remarks { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime ModOn { get; set; }
        public string ModBy { get; set; } = null!;

        public virtual Linkmaster Link { get; set; } = null!;
    }
}
