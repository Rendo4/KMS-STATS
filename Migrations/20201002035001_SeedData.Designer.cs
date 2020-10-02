﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stats.Models;

namespace Stats.Migrations
{
    [DbContext(typeof(StatsContext))]
    [Migration("20201002035001_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Stats.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Assists");

                    b.Property<string>("Champion");

                    b.Property<int>("Deaths");

                    b.Property<int>("Kills");

                    b.Property<string>("Opponent");

                    b.Property<string>("Summoner");

                    b.Property<string>("Team");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            Assists = 7,
                            Champion = "Caitlyn",
                            Deaths = 5,
                            Kills = 14,
                            Opponent = "TAS",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 2,
                            Assists = 8,
                            Champion = "Jinx",
                            Deaths = 2,
                            Kills = 15,
                            Opponent = "YUP",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 3,
                            Assists = 12,
                            Champion = "Ezreal",
                            Deaths = 1,
                            Kills = 11,
                            Opponent = "DD",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 4,
                            Assists = 3,
                            Champion = "Tristina",
                            Deaths = 4,
                            Kills = 7,
                            Opponent = "INT",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 5,
                            Assists = 11,
                            Champion = "Lucian",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 6,
                            Assists = 15,
                            Champion = "Thresh",
                            Deaths = 4,
                            Kills = 1,
                            Opponent = "TAS",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 7,
                            Assists = 17,
                            Champion = "Morgana",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "YUP",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 8,
                            Assists = 0,
                            Champion = "Pyke",
                            Deaths = 6,
                            Kills = 1,
                            Opponent = "BBZ",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 9,
                            Assists = 0,
                            Champion = "Ashe",
                            Deaths = 7,
                            Kills = 2,
                            Opponent = "INT",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 10,
                            Assists = 2,
                            Champion = "Caitlyn",
                            Deaths = 5,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "Theroclease",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 11,
                            Assists = 11,
                            Champion = "Urgot",
                            Deaths = 2,
                            Kills = 7,
                            Opponent = "YUP",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 12,
                            Assists = 3,
                            Champion = "Kled",
                            Deaths = 6,
                            Kills = 3,
                            Opponent = "BBZ",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 13,
                            Assists = 10,
                            Champion = "Mordakaiser",
                            Deaths = 4,
                            Kills = 11,
                            Opponent = "DD",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 14,
                            Assists = 1,
                            Champion = "Mordakaiser",
                            Deaths = 4,
                            Kills = 3,
                            Opponent = "INT",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 15,
                            Assists = 8,
                            Champion = "Kled",
                            Deaths = 6,
                            Kills = 6,
                            Opponent = "PTP",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 16,
                            Assists = 9,
                            Champion = "Mordakaiser",
                            Deaths = 7,
                            Kills = 7,
                            Opponent = "TAS",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 17,
                            Assists = 8,
                            Champion = "Urgot",
                            Deaths = 4,
                            Kills = 13,
                            Opponent = "YUP",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 18,
                            Assists = 3,
                            Champion = "Urgot",
                            Deaths = 5,
                            Kills = 2,
                            Opponent = "BBZ",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 19,
                            Assists = 4,
                            Champion = "Urgot",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "DD",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 20,
                            Assists = 2,
                            Champion = "Poppy",
                            Deaths = 6,
                            Kills = 1,
                            Opponent = "INT",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 21,
                            Assists = 5,
                            Champion = "Kled",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "BakinPancakes",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 22,
                            Assists = 3,
                            Champion = "Mordakaiser",
                            Deaths = 4,
                            Kills = 3,
                            Opponent = "TAS",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 23,
                            Assists = 14,
                            Champion = "Warwick",
                            Deaths = 10,
                            Kills = 1,
                            Opponent = "YUP",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 24,
                            Assists = 11,
                            Champion = "Skarner",
                            Deaths = 3,
                            Kills = 2,
                            Opponent = "BBZ",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 25,
                            Assists = 20,
                            Champion = "Ammumu",
                            Deaths = 4,
                            Kills = 4,
                            Opponent = "DD",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 26,
                            Assists = 4,
                            Champion = "Skarner",
                            Deaths = 5,
                            Kills = 2,
                            Opponent = "INT",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 27,
                            Assists = 5,
                            Champion = "Nocturne",
                            Deaths = 9,
                            Kills = 6,
                            Opponent = "PTP",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 28,
                            Assists = 13,
                            Champion = "Hecraim",
                            Deaths = 9,
                            Kills = 4,
                            Opponent = "TAS",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 29,
                            Assists = 15,
                            Champion = "Nunu",
                            Deaths = 8,
                            Kills = 3,
                            Opponent = "YUP",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 30,
                            Assists = 3,
                            Champion = "Nunu",
                            Deaths = 4,
                            Kills = 1,
                            Opponent = "BBZ",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 31,
                            Assists = 7,
                            Champion = "Nocturne",
                            Deaths = 10,
                            Kills = 0,
                            Opponent = "DD",
                            Summoner = "Willow233",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 32,
                            Assists = 12,
                            Champion = "Malzahar",
                            Deaths = 6,
                            Kills = 4,
                            Opponent = "TAS",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 33,
                            Assists = 17,
                            Champion = "Morgana",
                            Deaths = 4,
                            Kills = 3,
                            Opponent = "YUP",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 34,
                            Assists = 2,
                            Champion = "Lissandra",
                            Deaths = 5,
                            Kills = 10,
                            Opponent = "BBZ",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 35,
                            Assists = 11,
                            Champion = "Brand",
                            Deaths = 4,
                            Kills = 4,
                            Opponent = "DD",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 36,
                            Assists = 4,
                            Champion = "Malzahar",
                            Deaths = 3,
                            Kills = 0,
                            Opponent = "INT",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 37,
                            Assists = 3,
                            Champion = "Brand",
                            Deaths = 5,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 38,
                            Assists = 7,
                            Champion = "Lissandra",
                            Deaths = 8,
                            Kills = 12,
                            Opponent = "TAS",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 39,
                            Assists = 9,
                            Champion = "Le Blanc",
                            Deaths = 4,
                            Kills = 3,
                            Opponent = "YUP",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 40,
                            Assists = 3,
                            Champion = "Veigar",
                            Deaths = 5,
                            Kills = 2,
                            Opponent = "BBZ",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 41,
                            Assists = 4,
                            Champion = "Malzahar",
                            Deaths = 6,
                            Kills = 3,
                            Opponent = "DD",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 42,
                            Assists = 0,
                            Champion = "Annie",
                            Deaths = 3,
                            Kills = 1,
                            Opponent = "INT",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 43,
                            Assists = 6,
                            Champion = "Malzahar",
                            Deaths = 4,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "XNek0X",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 44,
                            Assists = 5,
                            Champion = "Pyke",
                            Deaths = 6,
                            Kills = 1,
                            Opponent = "YUP",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 45,
                            Assists = 7,
                            Champion = "Jinx",
                            Deaths = 6,
                            Kills = 0,
                            Opponent = "BBZ",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 46,
                            Assists = 10,
                            Champion = "Lux",
                            Deaths = 3,
                            Kills = 2,
                            Opponent = "DD",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 47,
                            Assists = 8,
                            Champion = "Leona",
                            Deaths = 7,
                            Kills = 0,
                            Opponent = "INT",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 48,
                            Assists = 11,
                            Champion = "Leona",
                            Deaths = 9,
                            Kills = 0,
                            Opponent = "PTP",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 49,
                            Assists = 12,
                            Champion = "Ashe",
                            Deaths = 8,
                            Kills = 4,
                            Opponent = "TAS",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 50,
                            Assists = 9,
                            Champion = "Ezreal",
                            Deaths = 6,
                            Kills = 6,
                            Opponent = "YUP",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 51,
                            Assists = 0,
                            Champion = "Xayah",
                            Deaths = 5,
                            Kills = 1,
                            Opponent = "BBZ",
                            Summoner = "Mr Turbo Int",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 52,
                            Assists = 14,
                            Champion = "Graves",
                            Deaths = 3,
                            Kills = 3,
                            Opponent = "TAS",
                            Summoner = "TyrantKingTyrone",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 53,
                            Assists = 14,
                            Champion = "Thresh",
                            Deaths = 9,
                            Kills = 0,
                            Opponent = "TAS",
                            Summoner = "Vale Claddath",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 54,
                            Assists = 7,
                            Champion = "Senna",
                            Deaths = 5,
                            Kills = 3,
                            Opponent = "BBZ",
                            Summoner = "Vale Claddath",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 55,
                            Assists = 4,
                            Champion = "Ashe",
                            Deaths = 5,
                            Kills = 4,
                            Opponent = "DD",
                            Summoner = "Truelax21",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 56,
                            Assists = 2,
                            Champion = "Trundle",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "INT",
                            Summoner = "Truelax21",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 57,
                            Assists = 3,
                            Champion = "Hecraim",
                            Deaths = 7,
                            Kills = 3,
                            Opponent = "PTP",
                            Summoner = "Truelax21",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 58,
                            Assists = 8,
                            Champion = "Nami",
                            Deaths = 3,
                            Kills = 0,
                            Opponent = "DD",
                            Summoner = "Warlock Herald",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 59,
                            Assists = 1,
                            Champion = "Leona",
                            Deaths = 6,
                            Kills = 0,
                            Opponent = "INT",
                            Summoner = "Unburdened",
                            Team = "GURL"
                        },
                        new
                        {
                            PlayerId = 60,
                            Assists = 5,
                            Champion = "Tahm Kench",
                            Deaths = 5,
                            Kills = 0,
                            Opponent = "PTP",
                            Summoner = "Unburdened",
                            Team = "GURL"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}