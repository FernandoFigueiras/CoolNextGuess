// <auto-generated />
using System;
using System.Collections.Generic;
using CollNextGuess.Infrastructure.Dal.PostgresSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CollNextGuess.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CollNextGuess.Core.Entities.GamePlay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentRound")
                        .HasColumnType("integer");

                    b.Property<string>("DeckAtPlay")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMultiPlayer")
                        .HasColumnType("boolean");

                    b.Property<int>("NumberOfPlayers")
                        .HasMaxLength(4)
                        .HasColumnType("integer");

                    b.Property<List<string>>("PlayerNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.ToTable("GamePlays");
                });

            modelBuilder.Entity("CollNextGuess.Core.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("GamePlayId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int>("Turn")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GamePlayId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CollNextGuess.Core.Entities.Player", b =>
                {
                    b.HasOne("CollNextGuess.Core.Entities.GamePlay", null)
                        .WithMany("Players")
                        .HasForeignKey("GamePlayId");
                });

            modelBuilder.Entity("CollNextGuess.Core.Entities.GamePlay", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
