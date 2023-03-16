using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Model.Entities;

public class EFTestContext : DbContext
{
    public DbSet<Land> Landen { get; set; }
    public DbSet<Stad> Staden { get; set; }

    public DbSet<Taal> Talen { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
    {
        optionsBuilder.UseSqlServer(	// (1)
                   "Server=(localdb)\\mssqllocaldb;Database=EFTest;" +
                   "Trusted_Connection=true;encrypt=false",  	// (2)
                   options => options.MaxBatchSize(150));

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Land
        modelBuilder.Entity<Land>()
            .HasKey(l => l.ISOLandCode);
        modelBuilder.Entity<Land>()
                .Property(l => l.ISOLandCode)
                .HasMaxLength(2);
        modelBuilder.Entity<Land>()
                .Property(l => l.NISLandCode)
                .HasMaxLength(3);
        modelBuilder.Entity<Land>()
                .HasIndex(l => l.NISLandCode)
                .IsUnique();
        modelBuilder.Entity<Land>()
                .Property(l => l.Naam)
                .HasMaxLength(50);
        modelBuilder.Entity<Land>()
                .HasIndex(l => l.Naam)
                .IsUnique();
        // Taal
        modelBuilder.Entity<Taal>()
           .HasKey(t => t.ISOTaalCode);
        modelBuilder.Entity<Taal>()
                .Property(t => t.ISOTaalCode)
                .HasMaxLength(2);
        modelBuilder.Entity<Taal>()
                .Property(t => t.NaamNL)
                .HasMaxLength(50);
        modelBuilder.Entity<Taal>()
                .Property(t => t.NaamTaal)
                .HasMaxLength(50);

        //Stad
        modelBuilder.Entity<Stad>()
           .HasKey(s => s.StadId);
        modelBuilder.Entity<Stad>()
                .Property(s => s.StadId)
                .ValueGeneratedOnAdd();
        modelBuilder.Entity<Stad>()
                .Property(s => s.Naam)
                .HasMaxLength(50);
        modelBuilder.Entity<Stad>()
                .HasIndex(s => s.Naam)
                .IsUnique();
        modelBuilder.Entity<Stad>()
            .Property(s => s.IsoLandCode)
            .HasMaxLength(2);

        


        // Seeding
          #region landData
        modelBuilder.Entity<Land>().HasData(
            
            new Land { ISOLandCode = "AT" , NISLandCode = "105" , Naam = "Oostenrijk" , 
                AantalInwoners = 8754413 , Oppervlakte = 83871f},

            new Land
            {
                ISOLandCode = "BE",
                NISLandCode = "150",
                Naam = "België",
                AantalInwoners = 11500000,
                Oppervlakte = 30689f
            },
            new Land
            {
                ISOLandCode = "CH",
                NISLandCode = "127",
                Naam = "Zwitserland",
                AantalInwoners = 8236303,
                Oppervlakte = 41285f
            }, 
            new Land
            {
                ISOLandCode = "DE",
                NISLandCode = "103",
                Naam = "Duitsland",
                AantalInwoners = 80594017,
                Oppervlakte = 357022f
            },
            new Land
            {
                ISOLandCode = "DK",
                NISLandCode = "108",
                Naam = "Denemarken",
                AantalInwoners = 5605948,
                Oppervlakte = 43094f
            },
            new Land
            {
                ISOLandCode = "ES",
                NISLandCode = "109",
                Naam = "Spanje",
                AantalInwoners = 48958159,
                Oppervlakte = 505992f
            },
            new Land
            {
                ISOLandCode = "FR",
                NISLandCode = "111",
                Naam = "Frankrijk",
                AantalInwoners = 62814233,
                Oppervlakte = 674843f
            },
            new Land
            {
                ISOLandCode = "GB",
                NISLandCode = "112",
                Naam = "Verenigd Konijngkrijk",
                AantalInwoners = 64769452,
                Oppervlakte = 242495f
            },
            new Land
            {
                ISOLandCode = "IT",
                NISLandCode = "128",
                Naam = "Italië",
                AantalInwoners = 62137802,
                Oppervlakte = 300000f
            },
            new Land
            {
                ISOLandCode = "LU",
                NISLandCode = "113",
                Naam = "Luxemburg",
                AantalInwoners = 594130,
                Oppervlakte = 2586f
            },
             new Land
             {
                 ISOLandCode = "NL",
                 NISLandCode = "129",
                 Naam = "Nederland",
                 AantalInwoners = 17424978,
                 Oppervlakte = 41873f
             },
             new Land
             {
                 ISOLandCode = "NO",
                 NISLandCode = "121",
                 Naam = "Noorwegen",
                 AantalInwoners = 5367580,
                 Oppervlakte = 385207f
             },
             new Land
             {
                 ISOLandCode = "PL",
                 NISLandCode = "139",
                 Naam = "Polen",
                 AantalInwoners = 38476269,
                 Oppervlakte = 311888f
             },
             new Land
             {
                 ISOLandCode = "SE",
                 NISLandCode = "126",
                 Naam = "Zweden",
                 AantalInwoners = 9960487,
                 Oppervlakte = 450295f
             },
             new Land
             {
                 ISOLandCode = "US",
                 NISLandCode = "402",
                 Naam = "Verenigde Staten",
                 AantalInwoners = 326625791,
                 Oppervlakte = 9826675f
             } );

        #endregion

        #region stadData

        modelBuilder.Entity<Stad>().HasData(

            new Stad { StadId = 1, Naam = "Brussel", IsoLandCode = "BE" },
                new Stad { StadId = 2, Naam = "Antwerpen", IsoLandCode = "BE" },
                new Stad { StadId = 3, Naam = "Luik", IsoLandCode = "BE" },
                new Stad { StadId = 4, Naam = "Amsterdam", IsoLandCode = "NL" },
                new Stad { StadId = 5, Naam = "Den Haag", IsoLandCode = "NL" },
                new Stad { StadId = 6, Naam = "Rotterdam", IsoLandCode = "NL" },
                new Stad { StadId = 7, Naam = "Berlijn", IsoLandCode = "DE" },
                new Stad { StadId = 8, Naam = "Hamburg", IsoLandCode = "DE" },
                new Stad { StadId = 9, Naam = "MÃ¼nchen", IsoLandCode = "DE" },
                new Stad { StadId = 10, Naam = "Luxemburg", IsoLandCode = "LU" },
                new Stad { StadId = 11, Naam = "Parijs", IsoLandCode = "FR" },
                new Stad { StadId = 12, Naam = "Marseille", IsoLandCode = "FR" }

            );

        #endregion

        #region TaalData

        modelBuilder.Entity<Taal>().HasData(
            new Taal { ISOTaalCode = "bg", NaamNL = "Bulgaars", NaamTaal = "Ð±ÑŠÐ»Ð³Ð°Ñ€Ñ ÐºÐ¸" },
                new Taal { ISOTaalCode = "cs", NaamNL = "Tsjechisch", NaamTaal = "Ä eÅ¡tina" },
                new Taal { ISOTaalCode = "da", NaamNL = "Deens", NaamTaal = "dansk" },
                new Taal { ISOTaalCode = "de", NaamNL = "Duits", NaamTaal = "Deutch" },
                new Taal { ISOTaalCode = "el", NaamNL = "Grieks", NaamTaal = "ÎµÎ»Î»Î·Î½Î¹ÎºÎ¬" },
                new Taal { ISOTaalCode = "en", NaamNL = "Engels", NaamTaal = "English" },
                new Taal { ISOTaalCode = "es", NaamNL = "Spaans", NaamTaal = "espaÃ±ol" },
                new Taal { ISOTaalCode = "et", NaamNL = "Ests", NaamTaal = "eesti keel" },
                new Taal { ISOTaalCode = "fi", NaamNL = "Fins", NaamTaal = "suomi" },
                new Taal { ISOTaalCode = "fr", NaamNL = "Frans", NaamTaal = "franÃ§ais" },
                new Taal { ISOTaalCode = "ga", NaamNL = "Iers", NaamTaal = "Gaeilge" },
                new Taal { ISOTaalCode = "hu", NaamNL = "Hongaars", NaamTaal = "magyar" },
                new Taal { ISOTaalCode = "it", NaamNL = "Italiaans", NaamTaal = "italiano" },
                new Taal { ISOTaalCode = "lt", NaamNL = "Litouws", NaamTaal = "lietuviÅ³ kalba" },
                new Taal { ISOTaalCode = "lv", NaamNL = "Lets", NaamTaal = "latvieÅ¡u valoda" },
                new Taal { ISOTaalCode = "mt", NaamNL = "Maltees", NaamTaal = "malti" },
                new Taal { ISOTaalCode = "nl", NaamNL = "Nederlands", NaamTaal = "Nederlands" },
                new Taal { ISOTaalCode = "pl", NaamNL = "Pools", NaamTaal = "polski" },
                new Taal { ISOTaalCode = "pt", NaamNL = "Portugees", NaamTaal = "portuguÃªs" },
                new Taal { ISOTaalCode = "ro", NaamNL = "Roemeens", NaamTaal = "romÃ¢nÄƒ" },
                new Taal { ISOTaalCode = "sk", NaamNL = "Slovaaks", NaamTaal = "slovenÄ ina" },
                new Taal { ISOTaalCode = "sl", NaamNL = "Sloveens", NaamTaal = "slovenÅ¡Ä ina" },
                new Taal { ISOTaalCode = "sv", NaamNL = "Zweeds", NaamTaal = "svenka" }


            );

        #endregion



        modelBuilder
        .Entity<Land>()
        .HasMany(l => l.Talen)
        .WithMany(l => l.Landen)
        .UsingEntity(j => j.HasData(

            new { LandenISOLandCode = "BE", TalenISOTaalCode = "de" },
            new { LandenISOLandCode = "DE", TalenISOTaalCode = "de" },
            new { LandenISOLandCode = "LU", TalenISOTaalCode = "de" },
            new { LandenISOLandCode = "BE", TalenISOTaalCode = "fr" },
            new { LandenISOLandCode = "FR", TalenISOTaalCode = "fr" },
            new { LandenISOLandCode = "LU", TalenISOTaalCode = "fr" },
            new { LandenISOLandCode = "BE", TalenISOTaalCode = "nl" },
            new { LandenISOLandCode = "NL", TalenISOTaalCode = "nl" }

            ));

    }


}
