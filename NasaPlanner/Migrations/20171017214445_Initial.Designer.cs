using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NasaPlanner.Models;

namespace NasaPlanner.Migrations
{
    [DbContext(typeof(NasaPlannerDbContext))]
    [Migration("20171017214445_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("NasaPlanner.Models.Crew", b =>
                {
                    b.Property<int>("CrewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CrewId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("NasaPlanner.Models.Mission", b =>
                {
                    b.Property<int>("MissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Days");

                    b.Property<string>("MissionName");

                    b.Property<int>("Tasks");

                    b.HasKey("MissionId");

                    b.ToTable("Missions");
                });
        }
    }
}
