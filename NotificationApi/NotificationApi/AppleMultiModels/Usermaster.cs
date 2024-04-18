using System;
using System.Collections.Generic;

namespace NotificationApi.AppleMultiModels
{
    public partial class Usermaster
    {
        public string Userid { get; set; } = null!;
        public string? Usertype { get; set; }
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public string? Branchid { get; set; }
        public string? Name { get; set; }
        public string? Insadr { get; set; }
        public string? Coradr { get; set; }
        public DateTime? Registrationdate { get; set; }
        public DateTime? Connectiondate { get; set; }
        public string? Mobilenumber { get; set; }
        public string? Altmobilenumber { get; set; }
        public string? Landlinenumber { get; set; }
        public string? Emailid { get; set; }
        public string? Status { get; set; }
        public string? Networkallocationstatus { get; set; }
        public string? Remarks { get; set; }
        public string? Addressprooftype { get; set; }
        public string? Idprooftype { get; set; }
        public string? Photofilename { get; set; }
        public string? Idproofname { get; set; }
        public string? Addproofname { get; set; }
        public string? Modby { get; set; }
        public DateTime? Modon { get; set; }
        public string? Registrationid { get; set; }
        public bool? PasswordCreated { get; set; }
        public bool? Forgotpassword { get; set; }
        public int Lapid { get; set; }
        public string Cafnumber { get; set; } = null!;
        public string? Cafdocumentname { get; set; }
        public string? Cafannexurename { get; set; }
        public string? Popid { get; set; }
        public string? Connectiontype { get; set; }
        public string? Connectiondetails { get; set; }
        public string? Installationconnectiontype { get; set; }
        public string? Usergstin { get; set; }
        public string? IdproofnameBack { get; set; }
        public string? AddproofnameBack { get; set; }
        public string? Signaturefilename { get; set; }
        public decimal Customerid { get; set; }
        public short Locationid { get; set; }
        public string? Macaddress { get; set; }
        public string? Signature { get; set; }
        public string? Whatsappno { get; set; }
        public string? Aadharnumber { get; set; }
        public string? Previousisp { get; set; }
        public string? OptAndroidBox { get; set; }
        public string? DeviceSerialNumber { get; set; }
        public string? Locationcode { get; set; }
        public string? OnudeviceSerialNumber { get; set; }
        public string? Onumacaddress { get; set; }
    }
}
