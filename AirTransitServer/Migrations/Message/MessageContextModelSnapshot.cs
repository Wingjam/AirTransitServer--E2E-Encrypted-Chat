﻿// <auto-generated />
using AirTransitServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AirTransitServer.Migrations.Message
{
    [DbContext(typeof(MessageContext))]
    partial class MessageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AirTransitServer.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
