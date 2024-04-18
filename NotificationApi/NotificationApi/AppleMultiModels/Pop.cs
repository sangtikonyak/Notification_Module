using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Pop
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Contactperson { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Gpdip { get; set; }
        public string? Bpdip { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? LocId { get; set; }
    }
}
