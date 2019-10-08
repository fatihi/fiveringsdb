﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FiveRingsDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FiveRingsDb.Migrations
{
    [DbContext(typeof(FiveRingsDbContext))]
    partial class FiveRingsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:Enum:card_type", "event,province,attachment,character,holding,stronghold,role")
                .HasAnnotation("Npgsql:Enum:clan", "crab,crane,dragon,lion,neutral,phoenix,scorpion,unicorn")
                .HasAnnotation("Npgsql:Enum:element", "air,earth,fire,void,water,all")
                .HasAnnotation("Npgsql:Enum:keyword_type", "ancestral,composure,courtesy,covert,disguised,limited,no_attachments,pride,restricted,sincerity")
                .HasAnnotation("Npgsql:Enum:side", "conflict,province,dynasty,role")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("FiveRingsDb.Models.Card", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<List<Clan>>("AllowedClans");

                    b.Property<CardType>("CardType");

                    b.Property<Clan>("Clan");

                    b.Property<int>("DeckLimit");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsRestricted");

                    b.Property<bool>("IsUnique");

                    b.Property<string>("Name");

                    b.Property<int?>("RoleRestriction");

                    b.Property<Side>("Side");

                    b.Property<string>("Text");

                    b.Property<List<string>>("Traits");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Cards");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Card");
                });

            modelBuilder.Entity("FiveRingsDb.Models.Keyword", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardId");

                    b.Property<List<string>>("Exceptions");

                    b.Property<List<string>>("Restrictions");

                    b.Property<KeywordType>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Id");

                    b.ToTable("Keywords");
                });

            modelBuilder.Entity("FiveRingsDb.Models.PrintedCard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardId");

                    b.Property<string>("Illustrator");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Pack");

                    b.Property<string>("Position");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Id");

                    b.ToTable("PrintedCards");
                });

            modelBuilder.Entity("FiveRingsDb.Models.AttachmentCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int?>("Cost")
                        .HasColumnName("AttachmentCost");

                    b.Property<int?>("InfluenceCost")
                        .HasColumnName("AttachmentInfluenceCost");

                    b.Property<string>("MilitaryBonus");

                    b.Property<string>("PoliticalBonus");

                    b.HasDiscriminator().HasValue("AttachmentCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.CharacterCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int?>("Cost")
                        .HasColumnName("CharacterCost");

                    b.Property<int>("Glory");

                    b.Property<int?>("InfluenceCost")
                        .HasColumnName("CharacterInfluenceCost");

                    b.Property<string>("Military");

                    b.Property<string>("Political");

                    b.HasDiscriminator().HasValue("CharacterCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.EventCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int?>("Cost")
                        .HasColumnName("EventCost");

                    b.Property<int?>("InfluenceCost")
                        .HasColumnName("EventInfluenceCost");

                    b.HasDiscriminator().HasValue("EventCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.HoldingCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<string>("StrengthBonus")
                        .HasColumnName("HoldingStrengthBonus");

                    b.HasDiscriminator().HasValue("HoldingCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.ProvinceCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<Element>("Element");

                    b.Property<string>("Strength");

                    b.HasDiscriminator().HasValue("ProvinceCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.RoleCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.HasDiscriminator().HasValue("RoleCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.StrongholdCard", b =>
                {
                    b.HasBaseType("FiveRingsDb.Models.Card");

                    b.Property<int>("Fate");

                    b.Property<int>("Honor");

                    b.Property<int>("InfluencePool");

                    b.Property<string>("StrengthBonus")
                        .HasColumnName("StrongholdStrengthBonus");

                    b.HasDiscriminator().HasValue("StrongholdCard");
                });

            modelBuilder.Entity("FiveRingsDb.Models.Keyword", b =>
                {
                    b.HasOne("FiveRingsDb.Models.Card")
                        .WithMany("Keywords")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("FiveRingsDb.Models.PrintedCard", b =>
                {
                    b.HasOne("FiveRingsDb.Models.Card")
                        .WithMany("PackCards")
                        .HasForeignKey("CardId");
                });
#pragma warning restore 612, 618
        }
    }
}
