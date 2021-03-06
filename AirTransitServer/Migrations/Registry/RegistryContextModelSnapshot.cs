﻿// <auto-generated />
using AirTransitServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace AirTransitServer.Migrations
{
    [DbContext(typeof(RegistryContext))]
    partial class RegistryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AirTransitServer.Models.Registry", b =>
                {
                    b.Property<string>("PhoneNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PublicKey")
                        .IsRequired();

                    b.HasKey("PhoneNumber");

                    b.ToTable("Registries");
                });
#pragma warning restore 612, 618
        }
    }
}
