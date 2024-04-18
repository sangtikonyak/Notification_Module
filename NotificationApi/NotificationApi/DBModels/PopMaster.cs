using System;
using System.Collections.Generic;

namespace NotificationApi.DBModels
{
    public partial class PopMaster
    {
        public PopMaster()
        {
            UserMasters = new HashSet<UserMaster>();
        }

        public string Popid { get; set; } = null!;
        public string Popname { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Contactperson { get; set; } = null!;
        public string Mobilenumber { get; set; } = null!;
        public string Landlinenumber { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}
