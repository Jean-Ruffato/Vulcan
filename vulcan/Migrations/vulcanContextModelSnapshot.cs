﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vulcan.Models;

namespace vulcan.Migrations
{
    [DbContext(typeof(VulcanContext))]
    partial class vulcanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("vulcan.Models.Scan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Host");

                    b.Property<string>("OperatingSystem");

                    b.Property<int>("ScanID");

                    b.Property<int>("ScanStatus");

                    b.Property<string>("SoftwareName");

                    b.Property<string>("SoftwareVersion");

                    b.Property<int>("VulnerabilitiesQuantity");

                    b.HasKey("ID");

                    b.ToTable("Scan");
                });

            modelBuilder.Entity("vulcan.Models.Vulnerabilities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccessComplexity");

                    b.Property<string>("Authentication");

                    b.Property<string>("AvaliabilityImpact");

                    b.Property<string>("ConfidentialityImpact");

                    b.Property<string>("Description");

                    b.Property<string>("GainedAccess");

                    b.Property<int>("Gravity");

                    b.Property<string>("IntegrityImpact");

                    b.Property<string>("Product");

                    b.Property<int?>("ScanID");

                    b.Property<double>("Score");

                    b.Property<string>("Type");

                    b.Property<string>("Vendor");

                    b.Property<string>("Version");

                    b.Property<string>("VulnerabilitieID");

                    b.HasKey("ID");

                    b.HasIndex("ScanID");

                    b.ToTable("Vulnerabilities");
                });

            modelBuilder.Entity("vulcan.Models.Vulnerabilities", b =>
                {
                    b.HasOne("vulcan.Models.Scan")
                        .WithMany("FoundVulnerabilitie")
                        .HasForeignKey("ScanID");
                });
#pragma warning restore 612, 618
        }
    }
}
