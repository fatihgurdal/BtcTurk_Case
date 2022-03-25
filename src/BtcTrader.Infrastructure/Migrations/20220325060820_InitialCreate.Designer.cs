﻿// <auto-generated />
using System;
using BtcTrader.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BtcTrader.Infrastructure.Migrations
{
    [DbContext(typeof(BtcTraderContext))]
    [Migration("20220325060820_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BtcTrader.Domain.Entities.NotificationHistoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsSendEmail")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSendPushNotification")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSendSms")
                        .HasColumnType("boolean");

                    b.Property<string>("NotificationText")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("NotificationHistories", (string)null);
                });

            modelBuilder.Entity("BtcTrader.Domain.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("AllowEmailNotification")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowPushNotification")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowSmsNotification")
                        .HasColumnType("boolean");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<byte>("DayOfMonth")
                        .HasColumnType("smallint");

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