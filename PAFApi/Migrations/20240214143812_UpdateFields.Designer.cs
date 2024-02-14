﻿// <auto-generated />
using System;
using Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PAFApi.Migrations
{
    [DbContext(typeof(ApplicationDb))]
    [Migration("20240214143812_UpdateFields")]
    partial class UpdateFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("PAFApi.Models.Address", b =>
                {
                    b.Property<int>("AddressKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BuildingNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeliveryPointSuffix")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DependentLocality")
                        .HasColumnType("TEXT");

                    b.Property<string>("DependentThoroughfareDescriptor")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoubleDependentLocality")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LocalityKey")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NumberOfHouseholds")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrganisationKey")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrganisationName")
                        .HasColumnType("TEXT");

                    b.Property<string>("POBox")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostTown")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostcodeType")
                        .HasColumnType("TEXT");

                    b.Property<string>("SUOrganisationIndicator")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubBuildingName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThoroughfareDescriptor")
                        .HasColumnType("TEXT");

                    b.Property<string>("UDPRN")
                        .HasColumnType("TEXT");

                    b.HasKey("AddressKey");

                    b.ToTable("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
