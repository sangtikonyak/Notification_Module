using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class ForcedPlanChange
    {
        public string Userid { get; set; } = null!;
        public string? Username { get; set; }
        public string Billplanidbeforeforced { get; set; } = null!;
        public DateTime Forcedplanchangedate { get; set; }
        public DateTime? Revertedplanchangedate { get; set; }
        public DateTime Forcedchangeentrydatetime { get; set; }
        public DateTime? Revertedplanchangeentrydatetime { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public int Id { get; set; }
    }
}
