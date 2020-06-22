﻿// <auto-generated />
using System;
using Calls.NetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calls.NetCore.Migrations
{
    [DbContext(typeof(CallsDbContext))]
    [Migration("20200622082051_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Calls.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CallerId")
                        .HasColumnType("int");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<int?>("ReceiverId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CallerId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("Calls");
                });

            modelBuilder.Entity("Calls.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("Calls.Call", b =>
                {
                    b.HasOne("Calls.PhoneNumber", "Caller")
                        .WithMany()
                        .HasForeignKey("CallerId");

                    b.HasOne("Calls.PhoneNumber", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");
                });
#pragma warning restore 612, 618
        }
    }
}