using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Registereduser
    {
        public int Id { get; set; }
        public string? Userid { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Insadr { get; set; }
        public string? Coradr { get; set; }
        public DateTime? Registrationdate { get; set; }
        public DateTime? Connectiondate { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Altmobilenumber { get; set; }
        public string? Landlinenumber { get; set; }
        public string? Emailid { get; set; }
        public string Billplanid { get; set; } = null!;
        public string Rentalpaymode { get; set; } = null!;
        public string Otrcid { get; set; } = null!;
        public decimal? Priority { get; set; }
        public string? Status { get; set; }
        public string? Remarks { get; set; }
        public string? Empid { get; set; }
        public string? Agentcode { get; set; }
        public string? Isagentaccount { get; set; }
        public string? Isbillraised { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Addressprooftype { get; set; }
        public string? Idprooftype { get; set; }
        public string? Photofilename { get; set; }
        public string? Idproofname { get; set; }
        public string? Addproofname { get; set; }
        public int Lapid { get; set; }
        public string Cafnumber { get; set; } = null!;
        public string? Cafdocumentname { get; set; }
        public string? Cafannexurename { get; set; }
        public string? Installationconnectiontype { get; set; }
        public string? Usergstin { get; set; }
        public string? AddproofnameBack { get; set; }
        public string? IdproofnameBack { get; set; }
        public string? SignatureFileName { get; set; }
        public string? ReasonforRejection { get; set; }
        public string? ReferredBy { get; set; }
        public string? GeoLocFileName { get; set; }
        public DateTime? KycVdate { get; set; }
        public string? Whatsappno { get; set; }
        public string? Aadharnumber { get; set; }
        public string? Previousisp { get; set; }
        public string? OptAndroidBox { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? CafnumberEncrypted { get; set; }
        public string? EkycLink { get; set; }
        public bool? Isinsadrsame { get; set; }
        public bool? Iscoradrsame { get; set; }
        public bool? Iswhatsappsame { get; set; }
        public bool? Insadrverified { get; set; }
        public string? Locationcode { get; set; }
        public string? Ottaddon { get; set; }
    }
}
