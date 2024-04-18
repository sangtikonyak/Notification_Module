using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Deletedbill
    {
        public int Id { get; set; }
        public string Userid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ReasonForDeletion { get; set; } = null!;
        public DateTime ExecutionTime { get; set; }
        public string? ResetConnectionStatus { get; set; }
    }
}
