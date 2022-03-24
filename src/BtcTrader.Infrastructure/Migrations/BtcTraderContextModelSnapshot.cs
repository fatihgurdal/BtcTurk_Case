﻿// <auto-generated />
using System;
using BtcTrader.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BtcTrader.Infrastructure.Migrations
{
    [DbContext(typeof(BtcTraderContext))]
    partial class BtcTraderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BtcTrader.Domain.Entities.NotificationHistoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("IsSendEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSendPushNotification")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSendSms")
                        .HasColumnType("bit");

                    b.Property<int>("NotificationText")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("NotificationHistories", (string)null);
                });

            modelBuilder.Entity("BtcTrader.Domain.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("AllowEmailNotification")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowPushNotification")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowSmsNotification")
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<byte>("DayOfMonth")
                        .HasColumnType("tinyint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("BtcTrader.Domain.Entities.NotificationHistoryEntity", b =>
                {
                    b.HasOne("BtcTrader.Domain.Entities.OrderEntity", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}