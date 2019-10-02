﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetRestfulAPI.Models;

namespace dotnetRestfulAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20191002051140_AddSimpleModel2")]
    partial class AddSimpleModel2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotnetRestfulAPI.Models.simpleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommandLine");

                    b.Property<string>("HowTo");

                    b.Property<string>("PlatForm");

                    b.HasKey("Id");

                    b.ToTable("simpleModel");
                });
#pragma warning restore 612, 618
        }
    }
}
