﻿// <auto-generated />
using AnimalFacts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalFacts.solution.Migrations
{
    [DbContext(typeof(AnimalFactsContext))]
    [Migration("20220815221738_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalFacts.Models.Fact", b =>
                {
                    b.Property<int>("FactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FactId");

                    b.ToTable("Facts");

                    b.HasData(
                        new
                        {
                            FactId = 1,
                            AnimalType = "Mammal",
                            Description = "River otters will ATTACK PEOPLE",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 2,
                            AnimalType = "Mammal",
                            Description = "Sea otters will KILL FOR A GOOD TIME",
                            Species = "Otter"
                        },
                        new
                        {
                            FactId = 3,
                            AnimalType = "Amphibian",
                            Description = "Just touching the golden poison dart frog WILL KILL YOU",
                            Species = "Poison Dart Frog"
                        },
                        new
                        {
                            FactId = 4,
                            AnimalType = "Reptile",
                            Description = "Some horned lizards SQUIRT BLOOD FROM THEIR EYES",
                            Species = "Horned Lizard"
                        },
                        new
                        {
                            FactId = 5,
                            AnimalType = "Mollusk",
                            Description = "Cone snails shoot you with a DEADLY HARPOON",
                            Species = "Cone Snail"
                        },
                        new
                        {
                            FactId = 6,
                            AnimalType = "Arachnids",
                            Description = "Female black widow spiders EAT THE MALE WHILE MATING",
                            Species = "Black Widow"
                        },
                        new
                        {
                            FactId = 7,
                            AnimalType = "Mammal",
                            Description = "Vampire bats FEED ON THE BLOOD OF MAMMALS, INCLUDING HUMANS",
                            Species = "Vampire Bat"
                        },
                        new
                        {
                            FactId = 8,
                            AnimalType = "Mammal",
                            Description = "Male platypuses have POISONOUS SPURS",
                            Species = "Platypus"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
