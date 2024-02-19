﻿// <auto-generated />
using Cardmangment.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cardmangment.Migrations
{
    [DbContext(typeof(EFcore_data))]
    partial class EFcore_dataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Cardmangment.EFCore.Card", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("CVC")
                        .HasColumnType("integer");

                    b.Property<string>("bankname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cardday")
                        .HasColumnType("integer");

                    b.Property<string>("cardname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cardnumber")
                        .HasColumnType("integer");

                    b.Property<string>("cardtype")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cardyear")
                        .HasColumnType("integer");

                    b.Property<int>("customerid")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("customerid");

                    b.ToTable("card");
                });

            modelBuilder.Entity("Cardmangment.EFCore.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("TC")
                        .HasColumnType("integer");

                    b.Property<string>("firtsname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Cardmangment.EFCore.Card", b =>
                {
                    b.HasOne("Cardmangment.EFCore.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
