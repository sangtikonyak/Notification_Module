using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NotificationApi.AppleMultiModels
{
    public partial class apple_multilocationsContext : DbContext
    {
        public apple_multilocationsContext()
        {
        }

        public apple_multilocationsContext(DbContextOptions<apple_multilocationsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accountmaster> Accountmasters { get; set; } = null!;
        public virtual DbSet<Agentmaster> Agentmasters { get; set; } = null!;
        public virtual DbSet<Bcd> Bcds { get; set; } = null!;
        public virtual DbSet<Billcycle> Billcycles { get; set; } = null!;
        public virtual DbSet<Billdetail> Billdetails { get; set; } = null!;
        public virtual DbSet<Billdetailstempmntnl> Billdetailstempmntnls { get; set; } = null!;
        public virtual DbSet<Billdetailstempmntnl2> Billdetailstempmntnl2s { get; set; } = null!;
        public virtual DbSet<Billperiodchangedetail> Billperiodchangedetails { get; set; } = null!;
        public virtual DbSet<Billplan> Billplans { get; set; } = null!;
        public virtual DbSet<Billplanchangedetail> Billplanchangedetails { get; set; } = null!;
        public virtual DbSet<Creditnote> Creditnotes { get; set; } = null!;
        public virtual DbSet<Currcycledt> Currcycledts { get; set; } = null!;
        public virtual DbSet<Datatransferdetail> Datatransferdetails { get; set; } = null!;
        public virtual DbSet<Deletedbill> Deletedbills { get; set; } = null!;
        public virtual DbSet<DfAccountmaster> DfAccountmasters { get; set; } = null!;
        public virtual DbSet<DfBillcycle> DfBillcycles { get; set; } = null!;
        public virtual DbSet<DfBillinginfo> DfBillinginfos { get; set; } = null!;
        public virtual DbSet<DfBillplan> DfBillplans { get; set; } = null!;
        public virtual DbSet<DfInvoice> DfInvoices { get; set; } = null!;
        public virtual DbSet<DfLedger> DfLedgers { get; set; } = null!;
        public virtual DbSet<DfLinkmaster> DfLinkmasters { get; set; } = null!;
        public virtual DbSet<DfReceiptdetail> DfReceiptdetails { get; set; } = null!;
        public virtual DbSet<Disconnectappform> Disconnectappforms { get; set; } = null!;
        public virtual DbSet<Discountsandwaiver> Discountsandwaivers { get; set; } = null!;
        public virtual DbSet<Dnpdetail> Dnpdetails { get; set; } = null!;
        public virtual DbSet<Exdtreceiptdetail> Exdtreceiptdetails { get; set; } = null!;
        public virtual DbSet<Fibermaintenance> Fibermaintenances { get; set; } = null!;
        public virtual DbSet<ForcedPlanChange> ForcedPlanChanges { get; set; } = null!;
        public virtual DbSet<Issuescategory> Issuescategories { get; set; } = null!;
        public virtual DbSet<Lapmaster> Lapmasters { get; set; } = null!;
        public virtual DbSet<LinkDownTime> LinkDownTimes { get; set; } = null!;
        public virtual DbSet<Linkmaster> Linkmasters { get; set; } = null!;
        public virtual DbSet<Llusermaster> Llusermasters { get; set; } = null!;
        public virtual DbSet<Mailnotification> Mailnotifications { get; set; } = null!;
        public virtual DbSet<Moduleaccessmaster> Moduleaccessmasters { get; set; } = null!;
        public virtual DbSet<Morebyte> Morebytes { get; set; } = null!;
        public virtual DbSet<Onlinepaymentuniquedetail> Onlinepaymentuniquedetails { get; set; } = null!;
        public virtual DbSet<Permanentdisconnectiondetail> Permanentdisconnectiondetails { get; set; } = null!;
        public virtual DbSet<Pop> Pops { get; set; } = null!;
        public virtual DbSet<Popmaintenance> Popmaintenances { get; set; } = null!;
        public virtual DbSet<Popmaster> Popmasters { get; set; } = null!;
        public virtual DbSet<Powerchecksm> Powerchecksms { get; set; } = null!;
        public virtual DbSet<Powercheckstatus> Powercheckstatuses { get; set; } = null!;
        public virtual DbSet<Powerstatus> Powerstatuses { get; set; } = null!;
        public virtual DbSet<Powerstatusdummyevent> Powerstatusdummyevents { get; set; } = null!;
        public virtual DbSet<PsmPowercheckstatus> PsmPowercheckstatuses { get; set; } = null!;
        public virtual DbSet<PsmPowerevent> PsmPowerevents { get; set; } = null!;
        public virtual DbSet<Receiptdetail> Receiptdetails { get; set; } = null!;
        public virtual DbSet<Registereduser> Registeredusers { get; set; } = null!;
        public virtual DbSet<Regotrcplan> Regotrcplans { get; set; } = null!;
        public virtual DbSet<RmFibermaster> RmFibermasters { get; set; } = null!;
        public virtual DbSet<Servicecallrecord> Servicecallrecords { get; set; } = null!;
        public virtual DbSet<Servicerequestlog> Servicerequestlogs { get; set; } = null!;
        public virtual DbSet<Sessiondetail> Sessiondetails { get; set; } = null!;
        public virtual DbSet<SmsserviceRequest> SmsserviceRequests { get; set; } = null!;
        public virtual DbSet<Splittempsessiondetail> Splittempsessiondetails { get; set; } = null!;
        public virtual DbSet<Subscriberledger> Subscriberledgers { get; set; } = null!;
        public virtual DbSet<Syseventlog> Syseventlogs { get; set; } = null!;
        public virtual DbSet<Systemusermaster> Systemusermasters { get; set; } = null!;
        public virtual DbSet<T1> T1s { get; set; } = null!;
        public virtual DbSet<Tdtillfurthernotice> Tdtillfurthernotices { get; set; } = null!;
        public virtual DbSet<Tempdatatransfer> Tempdatatransfers { get; set; } = null!;
        public virtual DbSet<Tempdatatransferdetail> Tempdatatransferdetails { get; set; } = null!;
        public virtual DbSet<Temporarydisconnectiondetail> Temporarydisconnectiondetails { get; set; } = null!;
        public virtual DbSet<Tempsessiondetail> Tempsessiondetails { get; set; } = null!;
        public virtual DbSet<Testingservicecallrecord> Testingservicecallrecords { get; set; } = null!;
        public virtual DbSet<Testingservicerequestlog> Testingservicerequestlogs { get; set; } = null!;
        public virtual DbSet<Tmpbilldetail> Tmpbilldetails { get; set; } = null!;
        public virtual DbSet<Tmpemailcampaign> Tmpemailcampaigns { get; set; } = null!;
        public virtual DbSet<Tmpsessiondetail> Tmpsessiondetails { get; set; } = null!;
        public virtual DbSet<TmptableQuery> TmptableQueries { get; set; } = null!;
        public virtual DbSet<UserAadharDetail> UserAadharDetails { get; set; } = null!;
        public virtual DbSet<Userbillinginfo> Userbillinginfos { get; set; } = null!;
        public virtual DbSet<Userdetail> Userdetails { get; set; } = null!;
        public virtual DbSet<Usermaster> Usermasters { get; set; } = null!;
        public virtual DbSet<Userpop> Userpops { get; set; } = null!;
        public virtual DbSet<Userstatuslog> Userstatuslogs { get; set; } = null!;
        public virtual DbSet<Wad> Wads { get; set; } = null!;
        public virtual DbSet<Wadtemp> Wadtemps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=223.27.120.20;Database=apple_multilocations;User=symbiosappleadmin;Password=HSJoha@2024@!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACCOUNTMASTER");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Altmobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("ALTMOBILENUMBER");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(250)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Emailid1)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID1");

                entity.Property(e => e.Emailid2)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID2");

                entity.Property(e => e.Emailid3)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID3");

                entity.Property(e => e.Landlinenumber)
                    .HasMaxLength(20)
                    .HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Agentmaster>(entity =>
            {
                entity.HasKey(e => e.Agentcode);

                entity.ToTable("AGENTMASTER");

                entity.Property(e => e.Agentcode)
                    .HasMaxLength(8)
                    .HasColumnName("AGENTCODE");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Agentname)
                    .HasMaxLength(100)
                    .HasColumnName("AGENTNAME");

                entity.Property(e => e.Contactnumber)
                    .HasMaxLength(20)
                    .HasColumnName("CONTACTNUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bcd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BCD");

                entity.Property(e => e.AmountWithLateFineAfterDueDate)
                    .HasMaxLength(50)
                    .HasColumnName("Amount with Late Fine after Due Date");

                entity.Property(e => e.Arrears).HasMaxLength(50);

                entity.Property(e => e.Billcyclename)
                    .HasMaxLength(100)
                    .HasColumnName("BILLCYCLENAME");

                entity.Property(e => e.Billdate)
                    .HasColumnType("date")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(50)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Cgst)
                    .HasMaxLength(50)
                    .HasColumnName("CGST");

                entity.Property(e => e.Correspondenceaddress)
                    .HasMaxLength(500)
                    .HasColumnName("CORRESPONDENCEADDRESS");

                entity.Property(e => e.CycleCharges).HasMaxLength(50);

                entity.Property(e => e.Emailid)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(100)
                    .HasColumnName("INSTRUMENT");

                entity.Property(e => e.IsFirstBillFalseOrTrue)
                    .HasMaxLength(50)
                    .HasColumnName("IsFirstBill(False or True)");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("date")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(50)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("NAME");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(500)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paidamount)
                    .HasMaxLength(50)
                    .HasColumnName("PAIDAMOUNT");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("date")
                    .HasColumnName("PAYMENTDATE");

                entity.Property(e => e.Receiptid)
                    .HasMaxLength(500)
                    .HasColumnName("RECEIPTID");

                entity.Property(e => e.SecurityDeposit).HasMaxLength(50);

                entity.Property(e => e.ServicetaxPregst)
                    .HasMaxLength(50)
                    .HasColumnName("SERVICETAX_PREGST");

                entity.Property(e => e.Sgst)
                    .HasMaxLength(50)
                    .HasColumnName("SGST");

                entity.Property(e => e.Totaloutstanding)
                    .HasMaxLength(50)
                    .HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("USERID");

                entity.Property(e => e.Waivers)
                    .HasMaxLength(50)
                    .HasColumnName("WAIVERS");
            });

            modelBuilder.Entity<Billcycle>(entity =>
            {
                entity.ToTable("BILLCYCLES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Billcycleid).HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billcyclename)
                    .HasMaxLength(255)
                    .HasColumnName("BILLCYCLENAME");

                entity.Property(e => e.Billedstatus)
                    .HasMaxLength(255)
                    .HasColumnName("BILLEDSTATUS");

                entity.Property(e => e.Cycleenddate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CYCLEENDDATE");

                entity.Property(e => e.Cyclestartdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CYCLESTARTDATE");

                entity.Property(e => e.Dueamount1).HasColumnName("DUEAMOUNT1");

                entity.Property(e => e.Dueamount2).HasColumnName("DUEAMOUNT2");

                entity.Property(e => e.Duedate1)
                    .HasColumnType("date")
                    .HasColumnName("DUEDATE1");

                entity.Property(e => e.Duedate2)
                    .HasColumnType("date")
                    .HasColumnName("DUEDATE2");

                entity.Property(e => e.Ishalfyearly)
                    .HasMaxLength(255)
                    .HasColumnName("ISHALFYEARLY");

                entity.Property(e => e.Isquarterly)
                    .HasMaxLength(255)
                    .HasColumnName("ISQUARTERLY");

                entity.Property(e => e.Isyearly)
                    .HasMaxLength(255)
                    .HasColumnName("ISYEARLY");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Latefinefired)
                    .HasMaxLength(255)
                    .HasColumnName("LATEFINEFIRED");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(5)
                    .HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Reactivationchargesfired)
                    .HasMaxLength(255)
                    .HasColumnName("REACTIVATIONCHARGESFIRED");
            });

            modelBuilder.Entity<Billdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLDETAILS");

                entity.Property(e => e.Actualdatatransfer).HasColumnName("ACTUALDATATRANSFER");

                entity.Property(e => e.Alloweddta).HasColumnName("ALLOWEDDTA");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(20)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Cgst)
                    .HasColumnName("CGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcyclecharges).HasColumnName("CURRENTCYCLECHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("CYCLECHARGES");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Dta).HasColumnName("DTA");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Extracat5charges).HasColumnName("EXTRACAT5CHARGES");

                entity.Property(e => e.Extracat5length).HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extradatatransfer).HasColumnName("EXTRADATATRANSFER");

                entity.Property(e => e.Extradatatransfercharges).HasColumnName("EXTRADATATRANSFERCHARGES");

                entity.Property(e => e.Extraofccharges).HasColumnName("EXTRAOFCCHARGES");

                entity.Property(e => e.Extraofclength).HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Firstbill)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTBILL")
                    .IsFixedLength();

                entity.Property(e => e.Igst)
                    .HasColumnName("IGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Iscancelled).HasColumnName("ISCANCELLED");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Lastdateofpayment2)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTDATEOFPAYMENT2");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Netpayable).HasColumnName("NETPAYABLE");

                entity.Property(e => e.OtherChargesRemarks).HasMaxLength(1000);

                entity.Property(e => e.Othercharges).HasColumnName("OTHERCHARGES");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Pdfgenerated).HasColumnName("PDFGenerated");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Proratedcyclecharges).HasColumnName("PRORATEDCYCLECHARGES");

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Sgst)
                    .HasColumnName("SGST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalcharges).HasColumnName("TOTALCHARGES");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Totaloutstandingwithlatefine).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE");

                entity.Property(e => e.Totaloutstandingwithlatefine2).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE2");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");

                entity.Property(e => e.WaiversRemarks).HasMaxLength(1000);
            });

            modelBuilder.Entity<Billdetailstempmntnl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLDETAILSTEMPMNTNL");

                entity.Property(e => e.Actualdatatransfer).HasColumnName("ACTUALDATATRANSFER");

                entity.Property(e => e.Alloweddta).HasColumnName("ALLOWEDDTA");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(20)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcyclecharges).HasColumnName("CURRENTCYCLECHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("CYCLECHARGES");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Dta).HasColumnName("DTA");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Extracat5charges).HasColumnName("EXTRACAT5CHARGES");

                entity.Property(e => e.Extracat5length).HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extradatatransfer).HasColumnName("EXTRADATATRANSFER");

                entity.Property(e => e.Extradatatransfercharges).HasColumnName("EXTRADATATRANSFERCHARGES");

                entity.Property(e => e.Extraofccharges).HasColumnName("EXTRAOFCCHARGES");

                entity.Property(e => e.Extraofclength).HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Firstbill)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTBILL")
                    .IsFixedLength();

                entity.Property(e => e.Igst).HasColumnName("IGST");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Netpayable).HasColumnName("NETPAYABLE");

                entity.Property(e => e.OtherChargesRemarks).HasMaxLength(1000);

                entity.Property(e => e.Othercharges).HasColumnName("OTHERCHARGES");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Pdfgenerated).HasColumnName("PDFGenerated");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Proratedcyclecharges).HasColumnName("PRORATEDCYCLECHARGES");

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.Totalcharges).HasColumnName("TOTALCHARGES");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Totaloutstandingwithlatefine).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");

                entity.Property(e => e.WaiversRemarks).HasMaxLength(1000);
            });

            modelBuilder.Entity<Billdetailstempmntnl2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLDETAILSTEMPMNTNL2");

                entity.Property(e => e.Actualdatatransfer).HasColumnName("ACTUALDATATRANSFER");

                entity.Property(e => e.Alloweddta).HasColumnName("ALLOWEDDTA");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(20)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcyclecharges).HasColumnName("CURRENTCYCLECHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("CYCLECHARGES");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Dta).HasColumnName("DTA");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Extracat5charges).HasColumnName("EXTRACAT5CHARGES");

                entity.Property(e => e.Extracat5length).HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extradatatransfer).HasColumnName("EXTRADATATRANSFER");

                entity.Property(e => e.Extradatatransfercharges).HasColumnName("EXTRADATATRANSFERCHARGES");

                entity.Property(e => e.Extraofccharges).HasColumnName("EXTRAOFCCHARGES");

                entity.Property(e => e.Extraofclength).HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Firstbill)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTBILL")
                    .IsFixedLength();

                entity.Property(e => e.Igst).HasColumnName("IGST");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Netpayable).HasColumnName("NETPAYABLE");

                entity.Property(e => e.OtherChargesRemarks).HasMaxLength(1000);

                entity.Property(e => e.Othercharges).HasColumnName("OTHERCHARGES");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Pdfgenerated).HasColumnName("PDFGenerated");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Proratedcyclecharges).HasColumnName("PRORATEDCYCLECHARGES");

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.Totalcharges).HasColumnName("TOTALCHARGES");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Totaloutstandingwithlatefine).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");

                entity.Property(e => e.WaiversRemarks).HasMaxLength(1000);
            });

            modelBuilder.Entity<Billperiodchangedetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLPERIODCHANGEDETAILS");

                entity.Property(e => e.Changeaffected).HasColumnName("CHANGEAFFECTED");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON");

                entity.Property(e => e.Fromcycleid).HasColumnName("FROMCYCLEID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Newbillenddate)
                    .HasColumnType("date")
                    .HasColumnName("NEWBILLENDDATE");

                entity.Property(e => e.Newbillstartdate)
                    .HasColumnType("date")
                    .HasColumnName("NEWBILLSTARTDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Billplan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLPLANS");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billplanremarks)
                    .HasMaxLength(500)
                    .HasColumnName("billplanremarks");

                entity.Property(e => e.Createdon)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Extracat5rate).HasColumnName("EXTRACAT5RATE");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extraofcrate).HasColumnName("EXTRAOFCRATE");

                entity.Property(e => e.Fap).HasColumnName("FAP");

                entity.Property(e => e.Freecat5length).HasColumnName("FREECAT5LENGTH");

                entity.Property(e => e.Freeofclength).HasColumnName("FREEOFCLENGTH");

                entity.Property(e => e.Hdta).HasColumnName("HDTA");

                entity.Property(e => e.Hrate).HasColumnName("HRATE");

                entity.Property(e => e.Locations)
                    .HasMaxLength(100)
                    .HasColumnName("LOCATIONS");

                entity.Property(e => e.Mdta).HasColumnName("MDTA");

                entity.Property(e => e.Media)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MEDIA")
                    .IsFixedLength();

                entity.Property(e => e.Mrate).HasColumnName("MRATE");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(200)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Qdta).HasColumnName("QDTA");

                entity.Property(e => e.Qrate).HasColumnName("QRATE");

                entity.Property(e => e.Security).HasColumnName("SECURITY");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Ulflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Ydta).HasColumnName("YDTA");

                entity.Property(e => e.Yrate).HasColumnName("YRATE");
            });

            modelBuilder.Entity<Billplanchangedetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BILLPLANCHANGEDETAILS");

                entity.Property(e => e.Changeaffected)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CHANGEAFFECTED")
                    .IsFixedLength();

                entity.Property(e => e.Fromcycleid).HasColumnName("FROMCYCLEID");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("date")
                    .HasColumnName("FROMDATE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Newbillplanid)
                    .HasMaxLength(100)
                    .HasColumnName("NEWBILLPLANID");

                entity.Property(e => e.Newpaymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NEWPAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Oldbillplanid)
                    .HasMaxLength(100)
                    .HasColumnName("OLDBILLPLANID");

                entity.Property(e => e.Oldpaymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OLDPAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Securitydepositdeclared)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SECURITYDEPOSITDECLARED");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Creditnote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CREDITNOTES");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(50)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Creditamount).HasColumnName("CREDITAMOUNT");

                entity.Property(e => e.Creditnoteid)
                    .HasMaxLength(20)
                    .HasColumnName("CREDITNOTEID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Narration)
                    .HasMaxLength(500)
                    .HasColumnName("NARRATION");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Currcycledt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CURRCYCLEDT");

                entity.Property(e => e.Alloweddt).HasColumnName("ALLOWEDDT");

                entity.Property(e => e.Balance).HasColumnName("BALANCE");

                entity.Property(e => e.Balancecldt).HasColumnName("BALANCECLDT");

                entity.Property(e => e.Balancedt).HasColumnName("BALANCEDT");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Cl).HasColumnName("CL");

                entity.Property(e => e.Clbal).HasColumnName("CLBAL");

                entity.Property(e => e.Cldt).HasColumnName("CLDT");

                entity.Property(e => e.Consumption).HasColumnName("CONSUMPTION");

                entity.Property(e => e.Cycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CYCLEID");

                entity.Property(e => e.Cycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Dt).HasColumnName("DT");

                entity.Property(e => e.Exdt).HasColumnName("EXDT");

                entity.Property(e => e.Exdtcharges).HasColumnName("EXDTCHARGES");

                entity.Property(e => e.Isnew)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISNEW")
                    .IsFixedLength();

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Ulflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ULFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Datatransferdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DATATRANSFERDETAILS");

                entity.Property(e => e.Cycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CYCLEID");

                entity.Property(e => e.Cycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Dt).HasColumnName("DT");

                entity.Property(e => e.Exdtpayment).HasColumnName("EXDTPAYMENT");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Deletedbill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DELETEDBILLS");

                entity.Property(e => e.ExecutionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("executionTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ReasonForDeletion)
                    .HasMaxLength(500)
                    .HasColumnName("Reason_for_Deletion");

                entity.Property(e => e.ResetConnectionStatus).HasMaxLength(5);

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<DfAccountmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_ACCOUNTMASTER");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Altmobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("ALTMOBILENUMBER");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(250)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Emailid1)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID1");

                entity.Property(e => e.Emailid2)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID2");

                entity.Property(e => e.Emailid3)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID3");

                entity.Property(e => e.Landlinenumber)
                    .HasMaxLength(20)
                    .HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<DfBillcycle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_BILLCYCLES");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billcyclename)
                    .HasMaxLength(100)
                    .HasColumnName("BILLCYCLENAME");

                entity.Property(e => e.Billedstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLEDSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Cycleenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CYCLEENDDATE");

                entity.Property(e => e.Cyclestartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CYCLESTARTDATE");

                entity.Property(e => e.Ishalfyearly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISHALFYEARLY")
                    .IsFixedLength();

                entity.Property(e => e.Isquarterly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISQUARTERLY")
                    .IsFixedLength();

                entity.Property(e => e.Isyearly)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISYEARLY")
                    .IsFixedLength();

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTDATEOFPAYMENT");
            });

            modelBuilder.Entity<DfBillinginfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_BILLINGINFO");

                entity.Property(e => e.Billflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Billingmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLINGMODE")
                    .IsFixedLength();

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(8)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Linkid)
                    .HasMaxLength(12)
                    .HasColumnName("LINKID");
            });

            modelBuilder.Entity<DfBillplan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_BILLPLANS");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(8)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(200)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Rate).HasColumnName("RATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DfInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_INVOICES");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(8)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcharges).HasColumnName("CURRENTCHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("CYCLECHARGES");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Invoiceid)
                    .HasMaxLength(10)
                    .HasColumnName("INVOICEID");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Linkid)
                    .HasMaxLength(12)
                    .HasColumnName("LINKID");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");
            });

            modelBuilder.Entity<DfLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_LEDGER");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Instrumentid)
                    .HasMaxLength(12)
                    .HasColumnName("INSTRUMENTID");

                entity.Property(e => e.Linkid)
                    .HasMaxLength(12)
                    .HasColumnName("LINKID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .HasColumnName("NARRATION");
            });

            modelBuilder.Entity<DfLinkmaster>(entity =>
            {
                entity.HasKey(e => e.Linkid);

                entity.ToTable("DF_LINKMASTER");

                entity.Property(e => e.Linkid)
                    .HasMaxLength(12)
                    .HasColumnName("LINKID");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Alength).HasColumnName("ALENGTH");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(12)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(8)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Insadr)
                    .HasMaxLength(250)
                    .HasColumnName("INSADR");

                entity.Property(e => e.Jmc)
                    .HasMaxLength(200)
                    .HasColumnName("JMC");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Otdr)
                    .HasMaxLength(200)
                    .HasColumnName("OTDR");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Ulength).HasColumnName("ULENGTH");
            });

            modelBuilder.Entity<DfReceiptdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DF_RECEIPTDETAILS");

                entity.Property(e => e.Accountid)
                    .HasMaxLength(12)
                    .HasColumnName("ACCOUNTID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Chequenoandbank)
                    .HasMaxLength(100)
                    .HasColumnName("CHEQUENOANDBANK");

                entity.Property(e => e.Invoiceid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("INVOICEID");

                entity.Property(e => e.Linkid)
                    .HasMaxLength(12)
                    .HasColumnName("LINKID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYMENTDATE");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(10)
                    .HasColumnName("PAYMENTMODE");

                entity.Property(e => e.Receiptid)
                    .HasMaxLength(11)
                    .HasColumnName("RECEIPTID");

                entity.Property(e => e.Receiptnumber)
                    .HasMaxLength(50)
                    .HasColumnName("RECEIPTNUMBER");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Transactionid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TRANSACTIONID");
            });

            modelBuilder.Entity<Disconnectappform>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DISCONNECTAPPFORMS");

                entity.Property(e => e.Applicationformname)
                    .HasMaxLength(200)
                    .HasColumnName("APPLICATIONFORMNAME");

                entity.Property(e => e.Userstatuslogid).HasColumnName("USERSTATUSLOGID");
            });

            modelBuilder.Entity<Discountsandwaiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DISCOUNTSANDWAIVERS");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Waiver).HasColumnName("WAIVER");
            });

            modelBuilder.Entity<Dnpdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DNPDETAILS");

                entity.Property(e => e.Dnpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DNPDATE");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Exdtreceiptdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXDTRECEIPTDETAILS");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Chequenoandbank)
                    .HasMaxLength(100)
                    .HasColumnName("CHEQUENOANDBANK");

                entity.Property(e => e.Instrument)
                    .HasMaxLength(10)
                    .HasColumnName("INSTRUMENT");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYMENTDATE");

                entity.Property(e => e.Receiptnumber)
                    .HasMaxLength(50)
                    .HasColumnName("RECEIPTNUMBER");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Transactionid)
                    .HasMaxLength(12)
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Fibermaintenance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FIBERMAINTENANCE");

                entity.Property(e => e.Dateofmaintenance)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEOFMAINTENANCE");

                entity.Property(e => e.Endlocation)
                    .HasMaxLength(500)
                    .HasColumnName("ENDLOCATION");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Startlocation)
                    .HasMaxLength(500)
                    .HasColumnName("STARTLOCATION");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Teammembers)
                    .HasMaxLength(500)
                    .HasColumnName("TEAMMEMBERS");
            });

            modelBuilder.Entity<ForcedPlanChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ForcedPlanChange");

                entity.Property(e => e.Billplanidbeforeforced)
                    .HasMaxLength(50)
                    .HasColumnName("billplanidbeforeforced");

                entity.Property(e => e.Forcedchangeentrydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("forcedchangeentrydatetime");

                entity.Property(e => e.Forcedplanchangedate)
                    .HasColumnType("date")
                    .HasColumnName("forcedplanchangedate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .HasColumnName("remarks");

                entity.Property(e => e.Revertedplanchangedate)
                    .HasColumnType("date")
                    .HasColumnName("revertedplanchangedate");

                entity.Property(e => e.Revertedplanchangeentrydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("revertedplanchangeentrydatetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(150)
                    .HasColumnName("status");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(12)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Issuescategory>(entity =>
            {
                entity.ToTable("ISSUESCATEGORY");

                entity.Property(e => e.Issuetitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ISSUETITLE");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Lapmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LAPMASTER");

                entity.Property(e => e.Lapaddress)
                    .HasMaxLength(1000)
                    .HasColumnName("LAPADDRESS");

                entity.Property(e => e.Lapadmincontact1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAPADMINCONTACT1");

                entity.Property(e => e.Lapadmincontact2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAPADMINCONTACT2");

                entity.Property(e => e.Lapadminemailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAPADMINEMAILID");

                entity.Property(e => e.Laparea)
                    .HasColumnType("text")
                    .HasColumnName("LAPAREA");

                entity.Property(e => e.Lapbillingcontact1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAPBILLINGCONTACT1");

                entity.Property(e => e.Lapbillingcontact2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAPBILLINGCONTACT2");

                entity.Property(e => e.Lapbillingemailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAPBILLINGEMAILID");

                entity.Property(e => e.Lapid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LAPID");

                entity.Property(e => e.Lapname)
                    .HasMaxLength(400)
                    .HasColumnName("LAPNAME");

                entity.Property(e => e.Lapstatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("LAPSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.Laptechcontact1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LAPTECHCONTACT1");

                entity.Property(e => e.Laptechemailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAPTECHEMAILID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LinkDownTime>(entity =>
            {
                entity.ToTable("LinkDownTime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasMaxLength(12);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("createdOn")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CutLocationCoordinates).HasMaxLength(50);

                entity.Property(e => e.DownDateTime).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ModBy).HasMaxLength(20);

                entity.Property(e => e.ModOn).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .HasColumnName("remarks");

                entity.Property(e => e.UpDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.LinkDownTimes)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinkDownTime_LINKMASTER");
            });

            modelBuilder.Entity<Linkmaster>(entity =>
            {
                entity.ToTable("LINKMASTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(12)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("createdOn")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LinkName).HasMaxLength(100);

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("modby");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("modon");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Llusermaster>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("LLUSERMASTER");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.BandwidthCapacity).HasMaxLength(50);

                entity.Property(e => e.ContactPersonEmail).HasMaxLength(50);

                entity.Property(e => e.ContactPersonName).HasMaxLength(50);

                entity.Property(e => e.ContactPersonPhone).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.InstallationAddress).HasMaxLength(100);

                entity.Property(e => e.InstallationDate).HasColumnType("date");

                entity.Property(e => e.LanIpaddress)
                    .HasMaxLength(50)
                    .HasColumnName("LAN_IPAddress");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.PurposeOfLl)
                    .HasMaxLength(50)
                    .HasColumnName("PurposeOfLL");

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.Property(e => e.WanIpaddress)
                    .HasMaxLength(50)
                    .HasColumnName("WAN_IPAddress");
            });

            modelBuilder.Entity<Mailnotification>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAILNOTIFICATIONS");

                entity.Property(e => e.Ccemails)
                    .HasMaxLength(500)
                    .HasColumnName("CCEMAILS");

                entity.Property(e => e.Event)
                    .HasMaxLength(50)
                    .HasColumnName("EVENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Toemails)
                    .HasMaxLength(500)
                    .HasColumnName("TOEMAILS");

                entity.Property(e => e.Toname)
                    .HasMaxLength(50)
                    .HasColumnName("TONAME");
            });

            modelBuilder.Entity<Moduleaccessmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MODULEACCESSMASTER");

                entity.Property(e => e.Modulename)
                    .HasMaxLength(50)
                    .HasColumnName("MODULENAME");

                entity.Property(e => e.Priv).HasColumnName("PRIV");
            });

            modelBuilder.Entity<Morebyte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("morebytes");

                entity.Property(e => e.Activatedon)
                    .HasColumnType("date")
                    .HasColumnName("activatedon");

                entity.Property(e => e.Cgst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cgst");

                entity.Property(e => e.Cycleid).HasColumnName("cycleid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Morebytes)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("morebytes");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("remarks");

                entity.Property(e => e.Servicetax)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("servicetax");

                entity.Property(e => e.Sgst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sgst");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalamount");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<Onlinepaymentuniquedetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ONLINEPAYMENTUNIQUEDETAILS");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("billdate");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(10)
                    .HasColumnName("billnumber");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("billplanid");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("coradr");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("emailid");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("mobilenumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("packagename");

                entity.Property(e => e.Paidamount).HasColumnName("paidamount");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Receiptid)
                    .HasMaxLength(10)
                    .HasColumnName("receiptid");

                entity.Property(e => e.Receiptnumber)
                    .HasMaxLength(50)
                    .HasColumnName("receiptnumber");

                entity.Property(e => e.Servicetax).HasColumnName("servicetax");

                entity.Property(e => e.Totalcharges).HasColumnName("totalcharges");

                entity.Property(e => e.Totaloutstanding).HasColumnName("totaloutstanding");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");
            });

            modelBuilder.Entity<Permanentdisconnectiondetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PERMANENTDISCONNECTIONDETAILS");

                entity.Property(e => e.Disconnectiondate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DISCONNECTIONDATE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Pop>(entity =>
            {
                entity.ToTable("pops");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasColumnName("address");

                entity.Property(e => e.Bpdip)
                    .HasMaxLength(50)
                    .HasColumnName("bpdip");

                entity.Property(e => e.Contactperson)
                    .HasMaxLength(100)
                    .HasColumnName("contactperson");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Gpdip)
                    .HasMaxLength(50)
                    .HasColumnName("gpdip");

                entity.Property(e => e.LocId)
                    .HasMaxLength(3)
                    .HasColumnName("loc_id");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("mobilenumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Popmaintenance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POPMAINTENANCE");

                entity.Property(e => e.Batterystatus)
                    .HasMaxLength(300)
                    .HasColumnName("BATTERYSTATUS");

                entity.Property(e => e.Dateofmaintenance)
                    .HasColumnType("datetime")
                    .HasColumnName("DATEOFMAINTENANCE");

                entity.Property(e => e.Inverterchargingstatus)
                    .HasMaxLength(300)
                    .HasColumnName("INVERTERCHARGINGSTATUS");

                entity.Property(e => e.Manualmetercharge)
                    .HasMaxLength(200)
                    .HasColumnName("MANUALMETERCHARGE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Replacement)
                    .HasMaxLength(500)
                    .HasColumnName("REPLACEMENT");
            });

            modelBuilder.Entity<Popmaster>(entity =>
            {
                entity.HasKey(e => e.Popid);

                entity.ToTable("POPMASTER");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Accessiblelocation)
                    .HasMaxLength(500)
                    .HasColumnName("ACCESSIBLELOCATION");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Bpdip)
                    .HasMaxLength(20)
                    .HasColumnName("BPDIP");

                entity.Property(e => e.Contactperson)
                    .HasMaxLength(200)
                    .HasColumnName("CONTACTPERSON");

                entity.Property(e => e.Gpdip)
                    .HasMaxLength(20)
                    .HasColumnName("GPDIP");

                entity.Property(e => e.Landlinenumber)
                    .HasMaxLength(20)
                    .HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(10)
                    .HasColumnName("LOCATIONCODE")
                    .IsFixedLength();

                entity.Property(e => e.Locations)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATIONS")
                    .HasComment("DMP, KOH, MKG, WKA");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Popname)
                    .HasMaxLength(200)
                    .HasColumnName("POPNAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_AT");
            });

            modelBuilder.Entity<Powerchecksm>(entity =>
            {
                entity.HasKey(e => e.Popid)
                    .HasName("PK_POWERSMSSTATUS");

                entity.ToTable("POWERCHECKSMS");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Lastl1sms)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTL1SMS");

                entity.Property(e => e.Lastl2sms)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTL2SMS");

                entity.Property(e => e.Lastl3sms)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTL3SMS");
            });

            modelBuilder.Entity<Powercheckstatus>(entity =>
            {
                entity.HasKey(e => e.Popid)
                    .HasName("PK_POWERCHKSTATUS");

                entity.ToTable("POWERCHECKSTATUS");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Batterycheck)
                    .HasMaxLength(10)
                    .HasColumnName("BATTERYCHECK");

                entity.Property(e => e.Currstate).HasColumnName("CURRSTATE");

                entity.Property(e => e.Gridcheck)
                    .HasMaxLength(50)
                    .HasColumnName("GRIDCHECK");

                entity.Property(e => e.Popname)
                    .HasMaxLength(50)
                    .HasColumnName("POPNAME");

                entity.Property(e => e.Prevstate).HasColumnName("PREVSTATE");
            });

            modelBuilder.Entity<Powerstatus>(entity =>
            {
                entity.HasKey(e => e.Popid);

                entity.ToTable("POWERSTATUS");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Alertrequired)
                    .HasMaxLength(50)
                    .HasColumnName("ALERTREQUIRED");

                entity.Property(e => e.Alertsent)
                    .HasMaxLength(10)
                    .HasColumnName("ALERTSENT");

                entity.Property(e => e.Batterycheck)
                    .HasMaxLength(10)
                    .HasColumnName("BATTERYCHECK");

                entity.Property(e => e.Currstate).HasColumnName("CURRSTATE");

                entity.Property(e => e.Gridcheck)
                    .HasMaxLength(50)
                    .HasColumnName("GRIDCHECK");

                entity.Property(e => e.Lastalertsentdatetime)
                    .HasMaxLength(50)
                    .HasColumnName("LASTALERTSENTDATETIME");

                entity.Property(e => e.Popname)
                    .HasMaxLength(50)
                    .HasColumnName("POPNAME");

                entity.Property(e => e.Prevstate).HasColumnName("PREVSTATE");
            });

            modelBuilder.Entity<Powerstatusdummyevent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("POWERSTATUSDUMMYEVENTS");

                entity.Property(e => e.Event).HasMaxLength(50);
            });

            modelBuilder.Entity<PsmPowercheckstatus>(entity =>
            {
                entity.HasKey(e => e.Popid)
                    .HasName("PK_PSM_POWERCHKSTATUS");

                entity.ToTable("PSM_POWERCHECKSTATUS");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Batterycheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BATTERYCHECK")
                    .IsFixedLength();

                entity.Property(e => e.Gridcheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GRIDCHECK")
                    .IsFixedLength();

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Popname)
                    .HasMaxLength(50)
                    .HasColumnName("POPNAME");

                entity.Property(e => e.Powerstate).HasColumnName("POWERSTATE");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_AT");
            });

            modelBuilder.Entity<PsmPowerevent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PSM_POWEREVENTS");

                entity.Property(e => e.Eventid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EVENTID");

                entity.Property(e => e.Eventstate)
                    .HasColumnName("EVENTSTATE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eventstatus)
                    .HasMaxLength(1)
                    .HasColumnName("EVENTSTATUS");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Startdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATETIME");

                entity.Property(e => e.Stopdatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOPDATETIME");
            });

            modelBuilder.Entity<Receiptdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RECEIPTDETAILS");

                entity.HasIndex(e => new { e.Receiptnumber, e.Instrument, e.Userid }, "IX_RECEIPTDETAILS");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Chequenoandbank)
                    .HasMaxLength(100)
                    .HasColumnName("CHEQUENOANDBANK");

                entity.Property(e => e.Collectionempid)
                    .HasMaxLength(12)
                    .HasColumnName("COLLECTIONEMPID");

                entity.Property(e => e.Entryreceiptid)
                    .HasMaxLength(20)
                    .HasColumnName("ENTRYRECEIPTID")
                    .HasComment("auto generated receipt by the the application");

                entity.Property(e => e.Exdtpayment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXDTPAYMENT")
                    .IsFixedLength();

                entity.Property(e => e.Instrument)
                    .HasMaxLength(15)
                    .HasColumnName("INSTRUMENT");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAYMENTDATE");

                entity.Property(e => e.Receiptid)
                    .HasMaxLength(10)
                    .HasColumnName("RECEIPTID");

                entity.Property(e => e.Receiptnumber)
                    .HasMaxLength(50)
                    .HasColumnName("RECEIPTNUMBER");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Transactionreceiptid)
                    .HasMaxLength(50)
                    .HasColumnName("TRANSACTIONRECEIPTID")
                    .HasComment("transaction receipt value like cash receipt number, upi transaction id, online order id etc.");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Registereduser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REGISTEREDUSERS");

                entity.Property(e => e.Aadharnumber)
                    .HasMaxLength(12)
                    .HasColumnName("AADHARNUMBER");

                entity.Property(e => e.Addproofname)
                    .HasMaxLength(200)
                    .HasColumnName("ADDPROOFNAME");

                entity.Property(e => e.AddproofnameBack)
                    .HasMaxLength(200)
                    .HasColumnName("ADDPROOFNAME_BACK");

                entity.Property(e => e.Addressprooftype)
                    .HasMaxLength(200)
                    .HasColumnName("ADDRESSPROOFTYPE");

                entity.Property(e => e.Agentcode)
                    .HasMaxLength(8)
                    .HasColumnName("AGENTCODE");

                entity.Property(e => e.Altmobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("ALTMOBILENUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Cafannexurename)
                    .HasMaxLength(200)
                    .HasColumnName("CAFANNEXURENAME");

                entity.Property(e => e.Cafdocumentname)
                    .HasMaxLength(200)
                    .HasColumnName("CAFDOCUMENTNAME");

                entity.Property(e => e.Cafnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CAFNUMBER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CafnumberEncrypted)
                    .HasMaxLength(100)
                    .HasColumnName("CAFNumberEncrypted");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(250)
                    .HasColumnName("CORADR");

                entity.Property(e => e.EkycLink).HasMaxLength(500);

                entity.Property(e => e.Emailid)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Empid)
                    .HasMaxLength(20)
                    .HasColumnName("EMPID");

                entity.Property(e => e.GeoLocFileName).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Idproofname)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFNAME");

                entity.Property(e => e.IdproofnameBack)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFNAME_BACK");

                entity.Property(e => e.Idprooftype)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFTYPE");

                entity.Property(e => e.Insadr)
                    .HasMaxLength(250)
                    .HasColumnName("INSADR");

                entity.Property(e => e.Insadrverified).HasColumnName("INSADRVERIFIED");

                entity.Property(e => e.Installationconnectiontype)
                    .HasMaxLength(11)
                    .HasColumnName("INSTALLATIONCONNECTIONTYPE");

                entity.Property(e => e.Isagentaccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISAGENTACCOUNT")
                    .IsFixedLength();

                entity.Property(e => e.Isbillraised)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISBILLRAISED")
                    .IsFixedLength();

                entity.Property(e => e.Iscoradrsame).HasColumnName("ISCORADRSAME");

                entity.Property(e => e.Isinsadrsame).HasColumnName("ISINSADRSAME");

                entity.Property(e => e.Iswhatsappsame).HasColumnName("ISWHATSAPPSAME");

                entity.Property(e => e.KycVdate)
                    .HasColumnType("datetime")
                    .HasColumnName("KycVDate");

                entity.Property(e => e.Landlinenumber)
                    .HasMaxLength(20)
                    .HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Lapid).HasColumnName("LAPID");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(10)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(10)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.OptAndroidBox)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Otrcid)
                    .HasMaxLength(8)
                    .HasColumnName("OTRCID");

                entity.Property(e => e.Ottaddon)
                    .HasMaxLength(50)
                    .HasColumnName("OTTAddon");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Photofilename)
                    .HasMaxLength(200)
                    .HasColumnName("PHOTOFILENAME");

                entity.Property(e => e.Previousisp)
                    .HasMaxLength(100)
                    .HasColumnName("PREVIOUSISP");

                entity.Property(e => e.Priority)
                    .HasColumnType("numeric(9, 0)")
                    .HasColumnName("PRIORITY");

                entity.Property(e => e.ReasonforRejection).HasMaxLength(2000);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(250)
                    .HasColumnName("Referred_By");

                entity.Property(e => e.Registrationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONDATE");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Rentalpaymode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("RENTALPAYMODE")
                    .IsFixedLength();

                entity.Property(e => e.SignatureFileName).HasMaxLength(200);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Whatsappno)
                    .HasMaxLength(10)
                    .HasColumnName("WHATSAPPNO");
            });

            modelBuilder.Entity<Regotrcplan>(entity =>
            {
                entity.HasKey(e => e.Otrcid);

                entity.ToTable("REGOTRCPLANS");

                entity.Property(e => e.Otrcid)
                    .HasMaxLength(8)
                    .HasColumnName("OTRCID");

                entity.Property(e => e.Locations)
                    .HasMaxLength(200)
                    .HasColumnName("LOCATIONS");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Otrcdownpayment).HasColumnName("OTRCDOWNPAYMENT");

                entity.Property(e => e.Otrcm10)
                    .HasColumnName("OTRCM10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm11)
                    .HasColumnName("OTRCM11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm12)
                    .HasColumnName("OTRCM12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm2)
                    .HasColumnName("OTRCM2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm3)
                    .HasColumnName("OTRCM3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm4)
                    .HasColumnName("OTRCM4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm5)
                    .HasColumnName("OTRCM5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm6)
                    .HasColumnName("OTRCM6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm7)
                    .HasColumnName("OTRCM7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm8)
                    .HasColumnName("OTRCM8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcm9)
                    .HasColumnName("OTRCM9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Otrcname)
                    .HasMaxLength(200)
                    .HasColumnName("OTRCNAME");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<RmFibermaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RM_FIBERMASTER");

                entity.Property(e => e.Address)
                    .HasColumnType("ntext")
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Coredetails)
                    .HasMaxLength(50)
                    .HasColumnName("COREDETAILS");

                entity.Property(e => e.Fibercount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("FIBERCOUNT");

                entity.Property(e => e.Icon).HasColumnName("ICON");

                entity.Property(e => e.Isclient)
                    .HasMaxLength(1)
                    .HasColumnName("ISCLIENT");

                entity.Property(e => e.Ispop)
                    .HasMaxLength(1)
                    .HasColumnName("ISPOP");

                entity.Property(e => e.Isroot)
                    .HasMaxLength(1)
                    .HasColumnName("ISROOT");

                entity.Property(e => e.Istrunk)
                    .HasMaxLength(1)
                    .HasColumnName("ISTRUNK");

                entity.Property(e => e.Lengthfromparent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("LENGTHFROMPARENT");

                entity.Property(e => e.Mediatype)
                    .HasMaxLength(1)
                    .HasColumnName("MEDIATYPE");

                entity.Property(e => e.Parentmediaid).HasColumnName("PARENTMEDIAID");

                entity.Property(e => e.Popid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POPID")
                    .IsFixedLength();

                entity.Property(e => e.Selicon).HasColumnName("SELICON");

                entity.Property(e => e.Terminationname)
                    .HasMaxLength(100)
                    .HasColumnName("TERMINATIONNAME");

                entity.Property(e => e.Trunkid).HasColumnName("TRUNKID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("USERID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Servicecallrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SERVICECALLRECORD");

                entity.Property(e => e.Callingnumber)
                    .HasMaxLength(10)
                    .HasColumnName("CALLINGNUMBER");

                entity.Property(e => e.Issue)
                    .HasMaxLength(500)
                    .HasColumnName("ISSUE");

                entity.Property(e => e.Issueassignedto)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEASSIGNEDTO");

                entity.Property(e => e.Issuecause)
                    .HasMaxLength(500)
                    .HasColumnName("ISSUECAUSE");

                entity.Property(e => e.Issueid)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEID");

                entity.Property(e => e.Issuereporteddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("ISSUEREPORTEDDATETIME");

                entity.Property(e => e.Issueresolveddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("ISSUERESOLVEDDATETIME");

                entity.Property(e => e.Issuetype)
                    .HasMaxLength(50)
                    .HasColumnName("ISSUETYPE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(50)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS")
                    .HasComment("Z = Developer archived");

                entity.Property(e => e.Supportcategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORTCATEGORY")
                    .IsFixedLength();

                entity.Property(e => e.Supporttype)
                    .HasMaxLength(10)
                    .HasColumnName("SUPPORTTYPE");

                entity.Property(e => e.Systemuserid)
                    .HasMaxLength(12)
                    .HasColumnName("SYSTEMUSERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Servicerequestlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SERVICEREQUESTLOGS");

                entity.Property(e => e.Actiontaken)
                    .HasMaxLength(500)
                    .HasColumnName("ACTIONTAKEN");

                entity.Property(e => e.Callbooknumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CALLBOOKNUMBER");

                entity.Property(e => e.Createdtimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDTIMESTAMP")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Issueid)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sessiondetail>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Username, e.Starttime, e.Stoptime });

                entity.ToTable("SESSIONDETAILS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Stoptime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOPTIME");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billcycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLCYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Clientip)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTIP");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("DATE");

                entity.Property(e => e.Downloadbytes).HasColumnName("DOWNLOADBYTES");

                entity.Property(e => e.Issplit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSPLIT")
                    .IsFixedLength();

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Rownum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWNUM");

                entity.Property(e => e.Snatip)
                    .HasMaxLength(50)
                    .HasColumnName("SNATIP");

                entity.Property(e => e.Time)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TIME");

                entity.Property(e => e.Totalbytes).HasColumnName("TOTALBYTES");

                entity.Property(e => e.Uploadbytes).HasColumnName("UPLOADBYTES");

                entity.Property(e => e.Usedtime)
                    .HasMaxLength(50)
                    .HasColumnName("USEDTIME");
            });

            modelBuilder.Entity<SmsserviceRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSServiceRequests");

                entity.Property(e => e.FirstReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.Issueid)
                    .HasMaxLength(50)
                    .HasColumnName("ISSUEID");

                entity.Property(e => e.ModOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedId).HasColumnName("ReceivedID");

                entity.Property(e => e.RequestMessage).HasMaxLength(500);

                entity.Property(e => e.ServiceRequestId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ServiceRequestID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Splittempsessiondetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPLITTEMPSESSIONDETAILS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billcycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLCYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Clientip)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTIP");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("DATE");

                entity.Property(e => e.Downloadbytes).HasColumnName("DOWNLOADBYTES");

                entity.Property(e => e.Rownum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWNUM");

                entity.Property(e => e.Snatip)
                    .HasMaxLength(50)
                    .HasColumnName("SNATIP");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Stoptime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOPTIME");

                entity.Property(e => e.Time)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TIME");

                entity.Property(e => e.Totalbytes).HasColumnName("TOTALBYTES");

                entity.Property(e => e.Uploadbytes).HasColumnName("UPLOADBYTES");

                entity.Property(e => e.Usedtime)
                    .HasMaxLength(50)
                    .HasColumnName("USEDTIME");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID")
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Subscriberledger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SUBSCRIBERLEDGER");

                entity.Property(e => e.Exdtpayment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EXDTPAYMENT")
                    .IsFixedLength();

                entity.Property(e => e.Instrumentid)
                    .HasMaxLength(20)
                    .HasColumnName("INSTRUMENTID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Specifications)
                    .HasMaxLength(200)
                    .HasColumnName("SPECIFICATIONS");

                entity.Property(e => e.Transactiondate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSACTIONDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Transactionid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TRANSACTIONID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Syseventlog>(entity =>
            {
                entity.HasKey(e => e.Logid);

                entity.ToTable("SYSEVENTLOG");

                entity.Property(e => e.Logid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGID");

                entity.Property(e => e.Event)
                    .HasMaxLength(1200)
                    .HasColumnName("EVENT");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Systemuserid)
                    .HasMaxLength(20)
                    .HasColumnName("SYSTEMUSERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Systemusermaster>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("SYSTEMUSERMASTER");

                entity.Property(e => e.Empid)
                    .HasMaxLength(20)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .HasColumnName("DESIGNATION");

                entity.Property(e => e.Dob)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Forgotpassword).HasColumnName("FORGOTPASSWORD");

                entity.Property(e => e.Locationrights)
                    .HasMaxLength(50)
                    .HasColumnName("LOCATIONRIGHTS");

                entity.Property(e => e.Mobilenum).HasColumnName("MOBILENUM");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Modulerights)
                    .HasMaxLength(50)
                    .HasColumnName("MODULERIGHTS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Priv)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("PRIV");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Whatsappno).HasColumnName("WHATSAPPNO");
            });

            modelBuilder.Entity<T1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T1");

                entity.Property(e => e.Actualdatatransfer).HasColumnName("ACTUALDATATRANSFER");

                entity.Property(e => e.Alloweddta).HasColumnName("ALLOWEDDTA");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid).HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(255)
                    .HasColumnName("billnumber");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(255)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Cgst).HasColumnName("cgst");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(255)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcyclecharges).HasColumnName("CURRENTCYCLECHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("cyclecharges");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Dta).HasColumnName("DTA");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(255)
                    .HasColumnName("emailid");

                entity.Property(e => e.Extracat5charges).HasColumnName("EXTRACAT5CHARGES");

                entity.Property(e => e.Extracat5length).HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extradatatransfer).HasColumnName("EXTRADATATRANSFER");

                entity.Property(e => e.Extradatatransfercharges).HasColumnName("EXTRADATATRANSFERCHARGES");

                entity.Property(e => e.Extraofccharges).HasColumnName("EXTRAOFCCHARGES");

                entity.Property(e => e.Extraofclength).HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Firstbill)
                    .HasMaxLength(255)
                    .HasColumnName("FIRSTBILL");

                entity.Property(e => e.Igst).HasColumnName("igst");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(255)
                    .HasColumnName("mobilenumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Netpayable).HasColumnName("netpayable");

                entity.Property(e => e.OtherChargesRemarks).HasMaxLength(255);

                entity.Property(e => e.Othercharges).HasColumnName("othercharges");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(255)
                    .HasColumnName("packagename");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(255)
                    .HasColumnName("paymentmode");

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Pdfgenerated)
                    .HasMaxLength(255)
                    .HasColumnName("PDFGenerated");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Proratedcyclecharges)
                    .HasMaxLength(255)
                    .HasColumnName("PRORATEDCYCLECHARGES");

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Sgst).HasColumnName("sgst");

                entity.Property(e => e.Totalcharges).HasColumnName("TOTALCHARGES");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Totaloutstandingwithlatefine).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(255)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(255)
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.Waivers).HasColumnName("waivers");

                entity.Property(e => e.WaiversRemarks).HasMaxLength(255);
            });

            modelBuilder.Entity<Tdtillfurthernotice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TDTILLFURTHERNOTICE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Reactivationflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REACTIVATIONFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Startdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Waiver).HasColumnName("WAIVER");
            });

            modelBuilder.Entity<Tempdatatransfer>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .IsClustered(false);

                entity.ToTable("TEMPDATATRANSFER");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Download).HasColumnName("DOWNLOAD");

                entity.Property(e => e.Sl)
                    .HasMaxLength(10)
                    .HasColumnName("SL");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Upload).HasColumnName("UPLOAD");
            });

            modelBuilder.Entity<Tempdatatransferdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPDATATRANSFERDETAILS");

                entity.Property(e => e.Cycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CYCLEID");

                entity.Property(e => e.Cycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Dt).HasColumnName("DT");

                entity.Property(e => e.Exdtpayment).HasColumnName("EXDTPAYMENT");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Temporarydisconnectiondetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPORARYDISCONNECTIONDETAILS");

                entity.Property(e => e.Enddate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Reactivationflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("REACTIVATIONFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Startdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Tfn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TFN")
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tempsessiondetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPSESSIONDETAILS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billcycletype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLCYCLETYPE")
                    .IsFixedLength();

                entity.Property(e => e.Clientip)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTIP");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("DATE");

                entity.Property(e => e.Downloadbytes).HasColumnName("DOWNLOADBYTES");

                entity.Property(e => e.Isduplicate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISDUPLICATE")
                    .IsFixedLength();

                entity.Property(e => e.Ismerged)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISMERGED")
                    .IsFixedLength();

                entity.Property(e => e.Isselfduplicate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSELFDUPLICATE")
                    .IsFixedLength();

                entity.Property(e => e.Issplit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISSPLIT")
                    .IsFixedLength();

                entity.Property(e => e.Rownum)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROWNUM");

                entity.Property(e => e.Snatip)
                    .HasMaxLength(50)
                    .HasColumnName("SNATIP");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Stoptime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOPTIME");

                entity.Property(e => e.Time)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TIME");

                entity.Property(e => e.Totalbytes).HasColumnName("TOTALBYTES");

                entity.Property(e => e.Uploadbytes).HasColumnName("UPLOADBYTES");

                entity.Property(e => e.Usedtime)
                    .HasMaxLength(50)
                    .HasColumnName("USEDTIME");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID")
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Testingservicecallrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTINGSERVICECALLRECORD");

                entity.Property(e => e.Callingnumber)
                    .HasMaxLength(10)
                    .HasColumnName("CALLINGNUMBER");

                entity.Property(e => e.Issue)
                    .HasMaxLength(500)
                    .HasColumnName("ISSUE");

                entity.Property(e => e.Issueassignedto)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEASSIGNEDTO");

                entity.Property(e => e.Issuecause)
                    .HasMaxLength(500)
                    .HasColumnName("ISSUECAUSE");

                entity.Property(e => e.Issueid)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEID");

                entity.Property(e => e.Issuereporteddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("ISSUEREPORTEDDATETIME");

                entity.Property(e => e.Issueresolveddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("ISSUERESOLVEDDATETIME");

                entity.Property(e => e.Issuetype)
                    .HasMaxLength(50)
                    .HasColumnName("ISSUETYPE");

                entity.Property(e => e.Modby)
                    .HasMaxLength(50)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Supportcategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SUPPORTCATEGORY")
                    .IsFixedLength();

                entity.Property(e => e.Supporttype)
                    .HasMaxLength(10)
                    .HasColumnName("SUPPORTTYPE");

                entity.Property(e => e.Systemuserid)
                    .HasMaxLength(12)
                    .HasColumnName("SYSTEMUSERID");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Testingservicerequestlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TESTINGSERVICEREQUESTLOGS");

                entity.Property(e => e.Actiontaken)
                    .HasMaxLength(500)
                    .HasColumnName("ACTIONTAKEN");

                entity.Property(e => e.Callbooknumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CALLBOOKNUMBER");

                entity.Property(e => e.Createdtimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDTIMESTAMP")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Issueid)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUEID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tmpbilldetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMPBILLDETAILS");

                entity.Property(e => e.Actualdatatransfer).HasColumnName("ACTUALDATATRANSFER");

                entity.Property(e => e.Alloweddta).HasColumnName("ALLOWEDDTA");

                entity.Property(e => e.Arrears).HasColumnName("ARREARS");

                entity.Property(e => e.Billcycleid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("BILLCYCLEID");

                entity.Property(e => e.Billdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLDATE");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billnumber)
                    .HasMaxLength(20)
                    .HasColumnName("BILLNUMBER");

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Cgst).HasColumnName("CGST");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(200)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Currentcyclecharges).HasColumnName("CURRENTCYCLECHARGES");

                entity.Property(e => e.Cyclecharges).HasColumnName("CYCLECHARGES");

                entity.Property(e => e.Daysbilled).HasColumnName("DAYSBILLED");

                entity.Property(e => e.Dta).HasColumnName("DTA");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Extracat5charges).HasColumnName("EXTRACAT5CHARGES");

                entity.Property(e => e.Extracat5length).HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extrachargespermb).HasColumnName("EXTRACHARGESPERMB");

                entity.Property(e => e.Extradatatransfer).HasColumnName("EXTRADATATRANSFER");

                entity.Property(e => e.Extradatatransfercharges).HasColumnName("EXTRADATATRANSFERCHARGES");

                entity.Property(e => e.Extraofccharges).HasColumnName("EXTRAOFCCHARGES");

                entity.Property(e => e.Extraofclength).HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Firstbill)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTBILL")
                    .IsFixedLength();

                entity.Property(e => e.Igst).HasColumnName("IGST");

                entity.Property(e => e.Iscancelled).HasColumnName("ISCANCELLED");

                entity.Property(e => e.Lastdateofpayment)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTDATEOFPAYMENT");

                entity.Property(e => e.Lastdateofpayment2)
                    .HasColumnType("date")
                    .HasColumnName("LASTDATEOFPAYMENT2");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Netpayable).HasColumnName("NETPAYABLE");

                entity.Property(e => e.OtherChargesRemarks).HasMaxLength(2000);

                entity.Property(e => e.Othercharges).HasColumnName("OTHERCHARGES");

                entity.Property(e => e.Otrc).HasColumnName("OTRC");

                entity.Property(e => e.Otrcdiscount).HasColumnName("OTRCDISCOUNT");

                entity.Property(e => e.Packagename)
                    .HasMaxLength(100)
                    .HasColumnName("PACKAGENAME");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Payments).HasColumnName("PAYMENTS");

                entity.Property(e => e.Pdfgenerated).HasColumnName("PDFGenerated");

                entity.Property(e => e.Persistentwaiver).HasColumnName("PERSISTENTWAIVER");

                entity.Property(e => e.Proratedcyclecharges).HasColumnName("PRORATEDCYCLECHARGES");

                entity.Property(e => e.Securitydeposit).HasColumnName("SECURITYDEPOSIT");

                entity.Property(e => e.Securitydepositdiscount).HasColumnName("SECURITYDEPOSITDISCOUNT");

                entity.Property(e => e.Servicetax).HasColumnName("SERVICETAX");

                entity.Property(e => e.Sgst).HasColumnName("SGST");

                entity.Property(e => e.Totalcharges).HasColumnName("TOTALCHARGES");

                entity.Property(e => e.Totaloutstanding).HasColumnName("TOTALOUTSTANDING");

                entity.Property(e => e.Totaloutstandingwithlatefine).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE");

                entity.Property(e => e.Totaloutstandingwithlatefine2).HasColumnName("TOTALOUTSTANDINGWITHLATEFINE2");

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Waivers).HasColumnName("WAIVERS");

                entity.Property(e => e.WaiversRemarks).HasMaxLength(2000);
            });

            modelBuilder.Entity<Tmpemailcampaign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpemailcampaign");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(150)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Tmpsessiondetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMPSESSIONDETAILS");

                entity.Property(e => e.Clientip)
                    .HasMaxLength(50)
                    .HasColumnName("CLIENTIP");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("DATE");

                entity.Property(e => e.Downloadbytes)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DOWNLOADBYTES");

                entity.Property(e => e.Snatip)
                    .HasMaxLength(50)
                    .HasColumnName("SNATIP");

                entity.Property(e => e.Starttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Stoptime)
                    .HasColumnType("datetime")
                    .HasColumnName("STOPTIME");

                entity.Property(e => e.Time)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TIME");

                entity.Property(e => e.Totalbytes)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TOTALBYTES");

                entity.Property(e => e.Uploadbytes)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPLOADBYTES");

                entity.Property(e => e.Usedtime)
                    .HasMaxLength(50)
                    .HasColumnName("USEDTIME");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<TmptableQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMPTableQueries");

                entity.Property(e => e.Billplanchangequeries).HasColumnName("billplanchangequeries");

                entity.Property(e => e.LedgerQueries).HasColumnName("ledgerQUERIES");

                entity.Property(e => e.LocationCode).HasMaxLength(5);
            });

            modelBuilder.Entity<UserAadharDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Aadharnumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Cef)
                    .HasMaxLength(50)
                    .HasColumnName("CEF");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("CreatedON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .HasColumnName("DOB");

                entity.Property(e => e.Ekyclink)
                    .HasMaxLength(500)
                    .HasColumnName("ekyclink");

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("ModifiedON");

                entity.Property(e => e.OtpsentMessage)
                    .HasMaxLength(500)
                    .HasColumnName("OTPSentMessage");

                entity.Property(e => e.OtpstatusCode)
                    .HasMaxLength(10)
                    .HasColumnName("OTPStatusCode");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .HasColumnName("PINCode");
            });

            modelBuilder.Entity<Userbillinginfo>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("USERBILLINGINFO");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Billenddate)
                    .HasColumnType("date")
                    .HasColumnName("BILLENDDATE");

                entity.Property(e => e.Billflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BILLFLAG")
                    .IsFixedLength();

                entity.Property(e => e.Billplanid)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANID");

                entity.Property(e => e.Billplanidbeforeforced)
                    .HasMaxLength(50)
                    .HasColumnName("BILLPLANIDBEFOREFORCED");

                entity.Property(e => e.Billstartdate)
                    .HasColumnType("date")
                    .HasColumnName("BILLSTARTDATE");

                entity.Property(e => e.Extracat5length)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EXTRACAT5LENGTH");

                entity.Property(e => e.Extraofclength)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("EXTRAOFCLENGTH");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDON");

                entity.Property(e => e.Outstanding).HasColumnName("OUTSTANDING");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENTMODE")
                    .IsFixedLength();

                entity.Property(e => e.Securityamount)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SECURITYAMOUNT");
            });

            modelBuilder.Entity<Userdetail>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("USERDETAILS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.LatitudeInstallation).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.LongitudeInstallation).HasColumnType("decimal(12, 9)");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("modby");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("modon");
            });

            modelBuilder.Entity<Usermaster>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Username });

                entity.ToTable("USERMASTER");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Aadharnumber)
                    .HasMaxLength(12)
                    .HasColumnName("AADHARNUMBER");

                entity.Property(e => e.Addproofname)
                    .HasMaxLength(200)
                    .HasColumnName("ADDPROOFNAME");

                entity.Property(e => e.AddproofnameBack)
                    .HasMaxLength(200)
                    .HasColumnName("ADDPROOFNAME_BACK");

                entity.Property(e => e.Addressprooftype)
                    .HasMaxLength(200)
                    .HasColumnName("ADDRESSPROOFTYPE");

                entity.Property(e => e.Altmobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("ALTMOBILENUMBER");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(8)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Cafannexurename)
                    .HasMaxLength(200)
                    .HasColumnName("CAFANNEXURENAME");

                entity.Property(e => e.Cafdocumentname)
                    .HasMaxLength(200)
                    .HasColumnName("CAFDOCUMENTNAME");

                entity.Property(e => e.Cafnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CAFNUMBER")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Connectiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONNECTIONDATE");

                entity.Property(e => e.Connectiondetails)
                    .HasMaxLength(500)
                    .HasColumnName("CONNECTIONDETAILS");

                entity.Property(e => e.Connectiontype)
                    .HasMaxLength(50)
                    .HasColumnName("CONNECTIONTYPE");

                entity.Property(e => e.Coradr)
                    .HasMaxLength(250)
                    .HasColumnName("CORADR");

                entity.Property(e => e.Customerid)
                    .HasColumnType("numeric(9, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.DeviceSerialNumber).HasMaxLength(50);

                entity.Property(e => e.Emailid)
                    .HasMaxLength(100)
                    .HasColumnName("EMAILID");

                entity.Property(e => e.Forgotpassword).HasColumnName("forgotpassword");

                entity.Property(e => e.Idproofname)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFNAME");

                entity.Property(e => e.IdproofnameBack)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFNAME_BACK");

                entity.Property(e => e.Idprooftype)
                    .HasMaxLength(200)
                    .HasColumnName("IDPROOFTYPE");

                entity.Property(e => e.Insadr)
                    .HasMaxLength(250)
                    .HasColumnName("INSADR");

                entity.Property(e => e.Installationconnectiontype)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSTALLATIONCONNECTIONTYPE");

                entity.Property(e => e.Landlinenumber)
                    .HasMaxLength(20)
                    .HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Lapid).HasColumnName("LAPID");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(3)
                    .HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Locationid)
                    .HasColumnName("LOCATIONID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Macaddress)
                    .HasMaxLength(50)
                    .HasColumnName("MACAddress");

                entity.Property(e => e.Mobilenumber)
                    .HasMaxLength(20)
                    .HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("NAME");

                entity.Property(e => e.Networkallocationstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NETWORKALLOCATIONSTATUS")
                    .IsFixedLength();

                entity.Property(e => e.OnudeviceSerialNumber)
                    .HasMaxLength(50)
                    .HasColumnName("ONUDeviceSerialNumber");

                entity.Property(e => e.Onumacaddress)
                    .HasMaxLength(50)
                    .HasColumnName("ONUMACAddress");

                entity.Property(e => e.OptAndroidBox)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Photofilename)
                    .HasMaxLength(200)
                    .HasColumnName("PHOTOFILENAME");

                entity.Property(e => e.Popid)
                    .HasMaxLength(8)
                    .HasColumnName("POPID");

                entity.Property(e => e.Previousisp)
                    .HasMaxLength(100)
                    .HasColumnName("PREVIOUSISP");

                entity.Property(e => e.Registrationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("REGISTRATIONDATE");

                entity.Property(e => e.Registrationid)
                    .HasMaxLength(8)
                    .HasColumnName("registrationid");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Signature)
                    .HasMaxLength(200)
                    .HasColumnName("SIGNATURE");

                entity.Property(e => e.Signaturefilename)
                    .HasMaxLength(200)
                    .HasColumnName("SIGNATUREFILENAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength();

                entity.Property(e => e.Usergstin)
                    .HasMaxLength(50)
                    .HasColumnName("USERGSTIN");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USERTYPE")
                    .IsFixedLength();

                entity.Property(e => e.Whatsappno)
                    .HasMaxLength(10)
                    .HasColumnName("WHATSAPPNO");
            });

            modelBuilder.Entity<Userpop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userpop");

                entity.Property(e => e.Connectiontype)
                    .HasMaxLength(255)
                    .HasColumnName("CONNECTIONTYPE");

                entity.Property(e => e.F6).HasMaxLength(255);

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("LOCATION ");

                entity.Property(e => e.PopId)
                    .HasMaxLength(255)
                    .HasColumnName("Pop ID");

                entity.Property(e => e.PopName)
                    .HasMaxLength(255)
                    .HasColumnName("Pop Name ");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Userstatuslog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERSTATUSLOG");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE");

                entity.Property(e => e.Logid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("datetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1500)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Status)
                    .HasMaxLength(150)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<Wad>(entity =>
            {
                entity.ToTable("WAD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Arrear).HasColumnName("ARREAR");

                entity.Property(e => e.Cycleid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CYCLEID");

                entity.Property(e => e.Dnb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DNB")
                    .HasDefaultValueSql("('F')")
                    .IsFixedLength();

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Waiver).HasColumnName("WAIVER");
            });

            modelBuilder.Entity<Wadtemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WADTEMP");

                entity.Property(e => e.Arrear).HasColumnName("ARREAR");

                entity.Property(e => e.Cycleid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CYCLEID");

                entity.Property(e => e.Dnb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DNB")
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Modby)
                    .HasMaxLength(20)
                    .HasColumnName("MODBY");

                entity.Property(e => e.Modon)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODON");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Userid)
                    .HasMaxLength(12)
                    .HasColumnName("USERID");

                entity.Property(e => e.Waiver).HasColumnName("WAIVER");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
