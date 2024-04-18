using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Linkmaster
    {
        public Linkmaster()
        {
            LinkDownTimes = new HashSet<LinkDownTime>();
        }

        public int Id { get; set; }
        public string LinkName { get; set; } = null!;
        public int LinkLength { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime Modon { get; set; }
        public string Modby { get; set; } = null!;

        public virtual ICollection<LinkDownTime> LinkDownTimes { get; set; }
    }
}
