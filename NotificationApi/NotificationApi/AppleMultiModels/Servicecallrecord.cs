using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Servicecallrecord
    {
        public string Issueid { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime? Issuereporteddatetime { get; set; }
        public DateTime? Issueresolveddatetime { get; set; }
        public string? Issuetype { get; set; }
        public string? Issue { get; set; }
        public string? Issuecause { get; set; }
        public string? Issueassignedto { get; set; }
        public string? Systemuserid { get; set; }
        public string? Popid { get; set; }
        /// <summary>
        /// Z = Developer archived
        /// </summary>
        public string? Status { get; set; }
        public string? Supporttype { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Supportcategory { get; set; }
        public string? Callingnumber { get; set; }
    }
}
