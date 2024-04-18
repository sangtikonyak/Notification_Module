using System;
using System.Collections.Generic;

namespace NotificationApi.DBModels
{
    public partial class UserMaster
    {
        public string Userid { get; set; } = null!;
        public string Whatsappno { get; set; } = null!;
        public string Popid { get; set; } = null!;
        public string Mobilenumber { get; set; } = null!;

        public virtual PopMaster Pop { get; set; } = null!;
    }
}
