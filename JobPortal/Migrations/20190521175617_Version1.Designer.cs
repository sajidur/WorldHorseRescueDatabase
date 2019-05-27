﻿// <auto-generated />
using System;
using JobPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobPortal.Migrations
{
    [DbContext(typeof(HorseRegistrationDbContext))]
    [Migration("20190521175617_Version1")]
    partial class Version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobPortal.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("JobPortal.Models.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Dam");

                    b.Property<string>("DamAssociation");

                    b.Property<string>("DamNumber");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("HorseName");

                    b.Property<string>("MembershipStatus");

                    b.Property<string>("MembershipType");

                    b.Property<string>("RegistrationAssociation");

                    b.Property<string>("RegistrationAssociationNumber");

                    b.Property<string>("RegistrationNumber");

                    b.Property<string>("Sire");

                    b.Property<string>("SireRegistrationAssociation");

                    b.Property<string>("SireRegistrationNumber");

                    b.HasKey("Id");

                    b.ToTable("Horses");
                });

            modelBuilder.Entity("JobPortal.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<int?>("HorseId");

                    b.Property<string>("MemberNumber");

                    b.Property<string>("MembershipStatus");

                    b.Property<string>("MembershipType");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.HasIndex("HorseId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("JobPortal.Models.Member", b =>
                {
                    b.HasOne("JobPortal.Models.Horse", "Horse")
                        .WithMany("Members")
                        .HasForeignKey("HorseId");
                });
#pragma warning restore 612, 618
        }
    }
}
