using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NotificationApi.DBModels
{
    public partial class notificationContext : DbContext
    {
        public notificationContext()
        {
        }

        public notificationContext(DbContextOptions<notificationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NotificationDetail> NotificationDetails { get; set; } = null!;
        public virtual DbSet<NotificationMaster> NotificationMasters { get; set; } = null!;
        public virtual DbSet<PopMaster> PopMasters { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotificationDetail>(entity =>
            {
                entity.HasKey(e => e.NotificationDetailsId);

                entity.HasIndex(e => e.NotificationMasterId, "IX_NotificationDetails_NotificationMasterId");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.InvalidWhatsappNumbers).HasColumnName("invalidWhatsappNumbers");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.WhatsAppNumber).HasColumnName("whatsAppNumber");

                entity.HasOne(d => d.NotificationMaster)
                    .WithMany(p => p.NotificationDetails)
                    .HasForeignKey(d => d.NotificationMasterId);
            });

            modelBuilder.Entity<NotificationMaster>(entity =>
            {
                entity.Property(e => e.IsNotificationSent).HasColumnName("isNotificationSent");

                entity.Property(e => e.SentBy).HasColumnName("sentBy");

                entity.Property(e => e.TemplateMessage).HasColumnName("templateMessage");

                entity.Property(e => e.TemplateName).HasColumnName("templateName");

                entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            });

            modelBuilder.Entity<PopMaster>(entity =>
            {
                entity.HasKey(e => e.Popid);

                entity.Property(e => e.Popid).HasColumnName("POPID");

                entity.Property(e => e.Address).HasColumnName("ADDRESS");

                entity.Property(e => e.Contactperson).HasColumnName("CONTACTPERSON");

                entity.Property(e => e.Landlinenumber).HasColumnName("LANDLINENUMBER");

                entity.Property(e => e.Mobilenumber).HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Popname).HasColumnName("POPNAME");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("User");
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("userMasters");

                entity.HasIndex(e => e.Popid, "IX_userMasters_POPID");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Mobilenumber).HasColumnName("MOBILENUMBER");

                entity.Property(e => e.Popid).HasColumnName("POPID");

                entity.Property(e => e.Whatsappno).HasColumnName("WHATSAPPNO");

                entity.HasOne(d => d.Pop)
                    .WithMany(p => p.UserMasters)
                    .HasForeignKey(d => d.Popid);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
