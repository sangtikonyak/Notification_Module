using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Billperiodchangedetail
    {
        public int Id { get; set; }
        public string Userid { get; set; } = null!;
        public int Fromcycleid { get; set; }
        public DateTime Newbillstartdate { get; set; }
        public DateTime Newbillenddate { get; set; }
        public bool Changeaffected { get; set; }
        public DateTime Createdon { get; set; }
        public string Createdby { get; set; } = null!;
        public DateTime? Modifiedon { get; set; }
        public string? Modifiedby { get; set; }
    }
}
