﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Entities;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(EFTestContext))]
    [Migration("20230316103838_landTaal")]
    partial class landTaal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.Property<string>("LandenISOLandCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("TalenISOTaalCode")
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("LandenISOLandCode", "TalenISOTaalCode");

                    b.HasIndex("TalenISOTaalCode");

                    b.ToTable("LandTaal");

                    b.HasData(
                        new
                        {
                            LandenISOLandCode = "BE",
                            TalenISOTaalCode = "de"
                        },
                        new
                        {
                            LandenISOLandCode = "DE",
                            TalenISOTaalCode = "de"
                        },
                        new
                        {
                            LandenISOLandCode = "LU",
                            TalenISOTaalCode = "de"
                        },
                        new
                        {
                            LandenISOLandCode = "BE",
                            TalenISOTaalCode = "fr"
                        },
                        new
                        {
                            LandenISOLandCode = "FR",
                            TalenISOTaalCode = "fr"
                        },
                        new
                        {
                            LandenISOLandCode = "LU",
                            TalenISOTaalCode = "fr"
                        },
                        new
                        {
                            LandenISOLandCode = "BE",
                            TalenISOTaalCode = "nl"
                        },
                        new
                        {
                            LandenISOLandCode = "NL",
                            TalenISOTaalCode = "nl"
                        });
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Property<string>("ISOLandCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<byte[]>("Aangepast")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("AantalInwoners")
                        .HasColumnType("int");

                    b.Property<string>("NISLandCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Oppervlakte")
                        .HasColumnType("real");

                    b.HasKey("ISOLandCode");

                    b.HasIndex("NISLandCode")
                        .IsUnique()
                        .HasFilter("[NISLandCode] IS NOT NULL");

                    b.HasIndex("Naam")
                        .IsUnique();

                    b.ToTable("Landen");

                    b.HasData(
                        new
                        {
                            ISOLandCode = "AT",
                            AantalInwoners = 8754413,
                            NISLandCode = "105",
                            Naam = "Oostenrijk",
                            Oppervlakte = 83871f
                        },
                        new
                        {
                            ISOLandCode = "BE",
                            AantalInwoners = 11500000,
                            NISLandCode = "150",
                            Naam = "België",
                            Oppervlakte = 30689f
                        },
                        new
                        {
                            ISOLandCode = "CH",
                            AantalInwoners = 8236303,
                            NISLandCode = "127",
                            Naam = "Zwitserland",
                            Oppervlakte = 41285f
                        },
                        new
                        {
                            ISOLandCode = "DE",
                            AantalInwoners = 80594017,
                            NISLandCode = "103",
                            Naam = "Duitsland",
                            Oppervlakte = 357022f
                        },
                        new
                        {
                            ISOLandCode = "DK",
                            AantalInwoners = 5605948,
                            NISLandCode = "108",
                            Naam = "Denemarken",
                            Oppervlakte = 43094f
                        },
                        new
                        {
                            ISOLandCode = "ES",
                            AantalInwoners = 48958159,
                            NISLandCode = "109",
                            Naam = "Spanje",
                            Oppervlakte = 505992f
                        },
                        new
                        {
                            ISOLandCode = "FR",
                            AantalInwoners = 62814233,
                            NISLandCode = "111",
                            Naam = "Frankrijk",
                            Oppervlakte = 674843f
                        },
                        new
                        {
                            ISOLandCode = "GB",
                            AantalInwoners = 64769452,
                            NISLandCode = "112",
                            Naam = "Verenigd Konijngkrijk",
                            Oppervlakte = 242495f
                        },
                        new
                        {
                            ISOLandCode = "IT",
                            AantalInwoners = 62137802,
                            NISLandCode = "128",
                            Naam = "Italië",
                            Oppervlakte = 300000f
                        },
                        new
                        {
                            ISOLandCode = "LU",
                            AantalInwoners = 594130,
                            NISLandCode = "113",
                            Naam = "Luxemburg",
                            Oppervlakte = 2586f
                        },
                        new
                        {
                            ISOLandCode = "NL",
                            AantalInwoners = 17424978,
                            NISLandCode = "129",
                            Naam = "Nederland",
                            Oppervlakte = 41873f
                        },
                        new
                        {
                            ISOLandCode = "NO",
                            AantalInwoners = 5367580,
                            NISLandCode = "121",
                            Naam = "Noorwegen",
                            Oppervlakte = 385207f
                        },
                        new
                        {
                            ISOLandCode = "PL",
                            AantalInwoners = 38476269,
                            NISLandCode = "139",
                            Naam = "Polen",
                            Oppervlakte = 311888f
                        },
                        new
                        {
                            ISOLandCode = "SE",
                            AantalInwoners = 9960487,
                            NISLandCode = "126",
                            Naam = "Zweden",
                            Oppervlakte = 450295f
                        },
                        new
                        {
                            ISOLandCode = "US",
                            AantalInwoners = 326625791,
                            NISLandCode = "402",
                            Naam = "Verenigde Staten",
                            Oppervlakte = 9826675f
                        });
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.Property<int>("StadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StadId"));

                    b.Property<byte[]>("Aangepast")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("IsoLandCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StadId");

                    b.HasIndex("IsoLandCode");

                    b.HasIndex("Naam")
                        .IsUnique();

                    b.ToTable("Staden");

                    b.HasData(
                        new
                        {
                            StadId = 1,
                            IsoLandCode = "BE",
                            Naam = "Brussel"
                        },
                        new
                        {
                            StadId = 2,
                            IsoLandCode = "BE",
                            Naam = "Antwerpen"
                        },
                        new
                        {
                            StadId = 3,
                            IsoLandCode = "BE",
                            Naam = "Luik"
                        },
                        new
                        {
                            StadId = 4,
                            IsoLandCode = "NL",
                            Naam = "Amsterdam"
                        },
                        new
                        {
                            StadId = 5,
                            IsoLandCode = "NL",
                            Naam = "Den Haag"
                        },
                        new
                        {
                            StadId = 6,
                            IsoLandCode = "NL",
                            Naam = "Rotterdam"
                        },
                        new
                        {
                            StadId = 7,
                            IsoLandCode = "DE",
                            Naam = "Berlijn"
                        },
                        new
                        {
                            StadId = 8,
                            IsoLandCode = "DE",
                            Naam = "Hamburg"
                        },
                        new
                        {
                            StadId = 9,
                            IsoLandCode = "DE",
                            Naam = "MÃ¼nchen"
                        },
                        new
                        {
                            StadId = 10,
                            IsoLandCode = "LU",
                            Naam = "Luxemburg"
                        },
                        new
                        {
                            StadId = 11,
                            IsoLandCode = "FR",
                            Naam = "Parijs"
                        },
                        new
                        {
                            StadId = 12,
                            IsoLandCode = "FR",
                            Naam = "Marseille"
                        });
                });

            modelBuilder.Entity("Model.Entities.Taal", b =>
                {
                    b.Property<string>("ISOTaalCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NaamNL")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NaamTaal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ISOTaalCode");

                    b.ToTable("Talen");

                    b.HasData(
                        new
                        {
                            ISOTaalCode = "bg",
                            NaamNL = "Bulgaars",
                            NaamTaal = "Ð±ÑŠÐ»Ð³Ð°Ñ€Ñ ÐºÐ¸"
                        },
                        new
                        {
                            ISOTaalCode = "cs",
                            NaamNL = "Tsjechisch",
                            NaamTaal = "Ä eÅ¡tina"
                        },
                        new
                        {
                            ISOTaalCode = "da",
                            NaamNL = "Deens",
                            NaamTaal = "dansk"
                        },
                        new
                        {
                            ISOTaalCode = "de",
                            NaamNL = "Duits",
                            NaamTaal = "Deutch"
                        },
                        new
                        {
                            ISOTaalCode = "el",
                            NaamNL = "Grieks",
                            NaamTaal = "ÎµÎ»Î»Î·Î½Î¹ÎºÎ¬"
                        },
                        new
                        {
                            ISOTaalCode = "en",
                            NaamNL = "Engels",
                            NaamTaal = "English"
                        },
                        new
                        {
                            ISOTaalCode = "es",
                            NaamNL = "Spaans",
                            NaamTaal = "espaÃ±ol"
                        },
                        new
                        {
                            ISOTaalCode = "et",
                            NaamNL = "Ests",
                            NaamTaal = "eesti keel"
                        },
                        new
                        {
                            ISOTaalCode = "fi",
                            NaamNL = "Fins",
                            NaamTaal = "suomi"
                        },
                        new
                        {
                            ISOTaalCode = "fr",
                            NaamNL = "Frans",
                            NaamTaal = "franÃ§ais"
                        },
                        new
                        {
                            ISOTaalCode = "ga",
                            NaamNL = "Iers",
                            NaamTaal = "Gaeilge"
                        },
                        new
                        {
                            ISOTaalCode = "hu",
                            NaamNL = "Hongaars",
                            NaamTaal = "magyar"
                        },
                        new
                        {
                            ISOTaalCode = "it",
                            NaamNL = "Italiaans",
                            NaamTaal = "italiano"
                        },
                        new
                        {
                            ISOTaalCode = "lt",
                            NaamNL = "Litouws",
                            NaamTaal = "lietuviÅ³ kalba"
                        },
                        new
                        {
                            ISOTaalCode = "lv",
                            NaamNL = "Lets",
                            NaamTaal = "latvieÅ¡u valoda"
                        },
                        new
                        {
                            ISOTaalCode = "mt",
                            NaamNL = "Maltees",
                            NaamTaal = "malti"
                        },
                        new
                        {
                            ISOTaalCode = "nl",
                            NaamNL = "Nederlands",
                            NaamTaal = "Nederlands"
                        },
                        new
                        {
                            ISOTaalCode = "pl",
                            NaamNL = "Pools",
                            NaamTaal = "polski"
                        },
                        new
                        {
                            ISOTaalCode = "pt",
                            NaamNL = "Portugees",
                            NaamTaal = "portuguÃªs"
                        },
                        new
                        {
                            ISOTaalCode = "ro",
                            NaamNL = "Roemeens",
                            NaamTaal = "romÃ¢nÄƒ"
                        },
                        new
                        {
                            ISOTaalCode = "sk",
                            NaamNL = "Slovaaks",
                            NaamTaal = "slovenÄ ina"
                        },
                        new
                        {
                            ISOTaalCode = "sl",
                            NaamNL = "Sloveens",
                            NaamTaal = "slovenÅ¡Ä ina"
                        },
                        new
                        {
                            ISOTaalCode = "sv",
                            NaamNL = "Zweeds",
                            NaamTaal = "svenka"
                        });
                });

            modelBuilder.Entity("LandTaal", b =>
                {
                    b.HasOne("Model.Entities.Land", null)
                        .WithMany()
                        .HasForeignKey("LandenISOLandCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Taal", null)
                        .WithMany()
                        .HasForeignKey("TalenISOTaalCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.Stad", b =>
                {
                    b.HasOne("Model.Entities.Land", "Land")
                        .WithMany("staden")
                        .HasForeignKey("IsoLandCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Land");
                });

            modelBuilder.Entity("Model.Entities.Land", b =>
                {
                    b.Navigation("staden");
                });
#pragma warning restore 612, 618
        }
    }
}