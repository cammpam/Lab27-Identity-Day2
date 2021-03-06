﻿// <auto-generated />
using Lab27Cameron.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab27Cameron.Migrations
{
    [DbContext(typeof(Lab27CameronContext))]
    [Migration("20171018221943_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab27Cameron.Models.ApplicationUser", b =>
                {
                    b.Property<int>("ApplicationUserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Role")
                        .IsRequired();

                    b.Property<string>("Role2");

                    b.HasKey("ApplicationUserID");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("Lab27Cameron.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contributor1")
                        .IsRequired();

                    b.Property<string>("Contributor1Role")
                        .IsRequired();

                    b.Property<string>("Contributor2");

                    b.Property<string>("Contributor2Role");

                    b.Property<string>("Contributor3");

                    b.Property<string>("Contributor3Role");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("SongID");

                    b.ToTable("Song");
                });
#pragma warning restore 612, 618
        }
    }
}
