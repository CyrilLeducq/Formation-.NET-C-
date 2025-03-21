﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzApi.Data;

#nullable disable

namespace PizzApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PizzApi.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "bacon",
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "mozzarella",
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "champignon",
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "emmental",
                            PizzaId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "cantal",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "mozzarella",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "fromage de chèvre",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "gruyère",
                            PizzaId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "sauce tomate",
                            PizzaId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "mozzarella",
                            PizzaId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "basilic",
                            PizzaId = 3
                        },
                        new
                        {
                            Id = 12,
                            Name = "boeuf",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 13,
                            Name = "mozzarella",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 14,
                            Name = "maïs",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 15,
                            Name = "tomates",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 16,
                            Name = "oignon",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 17,
                            Name = "coriandre",
                            PizzaId = 4
                        },
                        new
                        {
                            Id = 18,
                            Name = "jambon",
                            PizzaId = 5
                        },
                        new
                        {
                            Id = 19,
                            Name = "champignons",
                            PizzaId = 5
                        },
                        new
                        {
                            Id = 20,
                            Name = "mozzarella",
                            PizzaId = 5
                        },
                        new
                        {
                            Id = 21,
                            Name = "mozzarella",
                            PizzaId = 6
                        },
                        new
                        {
                            Id = 22,
                            Name = "pepperoni",
                            PizzaId = 6
                        },
                        new
                        {
                            Id = 23,
                            Name = "tomates",
                            PizzaId = 6
                        },
                        new
                        {
                            Id = 24,
                            Name = "champignons",
                            PizzaId = 7
                        },
                        new
                        {
                            Id = 25,
                            Name = "roquette",
                            PizzaId = 7
                        },
                        new
                        {
                            Id = 26,
                            Name = "artichauts",
                            PizzaId = 7
                        },
                        new
                        {
                            Id = 27,
                            Name = "aubergine",
                            PizzaId = 7
                        });
                });

            modelBuilder.Entity("PizzApi.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageLink")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageLink = "/images/bacon.jpg",
                            Name = "Bacon",
                            Price = 12m
                        },
                        new
                        {
                            Id = 2,
                            ImageLink = "/images/cheese.jpg",
                            Name = "4 fromages",
                            Price = 11m
                        },
                        new
                        {
                            Id = 3,
                            ImageLink = "/images/margherita.jpg",
                            Name = "Margherita",
                            Price = 10m
                        },
                        new
                        {
                            Id = 4,
                            ImageLink = "/images/meaty.jpg",
                            Name = "Mexicaine",
                            Price = 12m
                        },
                        new
                        {
                            Id = 5,
                            ImageLink = "/images/mushroom.jpg",
                            Name = "Reine",
                            Price = 11m
                        },
                        new
                        {
                            Id = 6,
                            ImageLink = "/images/pepperoni.jpg",
                            Name = "Pepperoni",
                            Price = 11m
                        },
                        new
                        {
                            Id = 7,
                            ImageLink = "/images/veggie.jpg",
                            Name = "Végétarienne",
                            Price = 10m
                        });
                });

            modelBuilder.Entity("PizzApi.Models.Users.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PizzApi.Models.Users.Pizzaiolo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pizzaiolos");
                });

            modelBuilder.Entity("PizzApi.Models.Ingredient", b =>
                {
                    b.HasOne("PizzApi.Models.Pizza", "Pizza")
                        .WithMany("Ingredients")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("PizzApi.Models.Pizza", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
