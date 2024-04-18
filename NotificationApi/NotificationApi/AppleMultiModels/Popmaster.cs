using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Popmaster
    {
        public string Popid { get; set; } = null!;
        public string? Popname { get; set; }
        public string? Address { get; set; }
        public string? Contactperson { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Landlinenumber { get; set; }
        public string? Status { get; set; }
        public string? Gpdip { get; set; }
        public string? Bpdip { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// DMP, KOH, MKG, WKA
        /// </summary>
        public string? Locations { get; set; }
        public string? Locationcode { get; set; }
        public string? Accessiblelocation { get; set; }
    }
}
