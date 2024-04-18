using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class UserAadharDetail
    {
        public int Id { get; set; }
        public decimal Aadharnumber { get; set; }
        public string? Cef { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? Dob { get; set; }
        public string? Pincode { get; set; }
        public string? ResponseValues { get; set; }
        public string? OtpsentMessage { get; set; }
        public string? OtpstatusCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? Ekyclink { get; set; }
    }
}
