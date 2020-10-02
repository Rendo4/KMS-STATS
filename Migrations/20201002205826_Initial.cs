using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stats.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Summoner = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true),
                    Opponent = table.Column<string>(nullable: true),
                    Champion = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Kills = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "Assists", "Champion", "Deaths", "Kills", "Opponent", "Role", "Summoner", "Team" },
                values: new object[,]
                {
                    { 1, 7, "Caitlyn", 5, 14, "TAS", "ADC", "Theroclease", "GURL" },
                    { 88, 21, "Lux", 2, 2, "GURL", "ADC", "Ssunrise", "BBZ" },
                    { 87, 10, "Caitlyn", 1, 7, "DD", "ADC", "Ssunrise", "BBZ" },
                    { 86, 5, "Viktor", 2, 1, "YUP2", "MID", "Huebs", "BBZ" },
                    { 85, 10, "Azir", 4, 4, "TAS2", "MID", "Huebs", "BBZ" },
                    { 84, 8, "Yone", 6, 3, "PTP2", "MID", "Huebs", "BBZ" },
                    { 83, 0, "Yauso", 5, 1, "INT2", "MID", "Huebs", "BBZ" },
                    { 82, 7, "Yone", 5, 5, "GURL", "MID", "Huebs", "BBZ" },
                    { 81, 5, "Jarvan-IV", 5, 1, "YUP2", "JNG", "Rârgh", "BBZ" },
                    { 80, 11, "Hecraim", 4, 2, "TAS2", "JNG", "Rârgh", "BBZ" },
                    { 79, 10, "Sejuani", 10, 0, "PTP2", "JNG", "Rârgh", "BBZ" },
                    { 78, 2, "Zac", 5, 0, "INT2", "JNG", "Rârgh", "BBZ" },
                    { 77, 14, "Hecraim", 3, 3, "GURL2", "JNG", "Rârgh", "BBZ" },
                    { 89, 2, "Caitlyn", 3, 1, "INT", "ADC", "Ssunrise", "BBZ" },
                    { 76, 19, "Hecraim", 1, 1, "DD2", "JNG", "Rârgh", "BBZ" },
                    { 74, 3, "Galio", 8, 3, "TAS", "SUP", "Rârgh", "BBZ" },
                    { 73, 3, "Sejuani", 8, 2, "INT", "JNG", "Rârgh", "BBZ" },
                    { 72, 13, "Sejuani", 6, 7, "GURL", "JNG", "Rârgh", "BBZ" },
                    { 71, 8, "Hecraim", 2, 1, "DD", "JNG", "Rârgh", "BBZ" },
                    { 70, 6, "Mordakaiser", 2, 5, "YUP2", "TOP", "ShieldedValor", "BBZ" },
                    { 69, 11, "Rumble", 2, 4, "TAS2", "TOP", "ShieldedValor", "BBZ" },
                    { 68, 4, "Sylas", 4, 3, "PTP2", "TOP", "ShieldedValor", "BBZ" },
                    { 67, 10, "Rumble", 1, 2, "INT2", "TOP", "ShieldedValor", "BBZ" },
                    { 66, 9, "Shen", 0, 4, "GURL2", "TOP", "ShieldedValor", "BBZ" },
                    { 65, 18, "Shen", 1, 4, "DD2", "TOP", "ShieldedValor", "BBZ" },
                    { 64, 1, "Jax", 3, 10, "YUP", "TOP", "ShieldedValor", "BBZ" },
                    { 63, 5, "Ornn", 4, 1, "TAS", "TOP", "ShieldedValor", "BBZ" },
                    { 75, 6, "Veigar", 5, 3, "YUP", "MID", "Rârgh", "BBZ" },
                    { 62, 6, "Riven", 5, 4, "PTP", "TOP", "ShieldedValor", "BBZ" },
                    { 90, 4, "Kindred", 5, 6, "PTP", "JNG", "Ssunrise", "BBZ" },
                    { 92, 7, "Kog'Maw", 4, 5, "YUP", "ADC", "Ssunrise", "BBZ" },
                    { 118, 8, "Lucian", 3, 8, "TAS2", "ADC", "Chris-Sunga", "BBZ" },
                    { 117, 7, "Zilean", 2, 3, "GURL2", "MID", "Chris-Sunga", "BBZ" },
                    { 116, 12, "Azir", 4, 8, "DD2", "MID", "Chris-Sunga", "BBZ" },
                    { 115, 9, "Lee-sin", 4, 4, "YUP", "JNG", "Chris-Sunga", "BBZ" },
                    { 114, 3, "Le-Blanc", 4, 2, "TAS", "MID", "Chris-Sunga", "BBZ" },
                    { 113, 7, "Galio", 6, 0, "PTP", "MID", "Chris-Sunga", "BBZ" },
                    { 112, 3, "Syndra", 3, 2, "INT", "MID", "Chris-Sunga", "BBZ" },
                    { 111, 8, "Oriana", 1, 2, "DD", "MID", "Chris-Sunga", "BBZ" },
                    { 110, 9, "Gnar", 4, 8, "GURL", "TOP", "AllMightTheHero", "BBZ" },
                    { 109, 7, "Gnar", 1, 5, "DD", "TOP", "AllMightTheHero", "BBZ" },
                    { 108, 5, "Shen", 4, 0, "YUP2", "SUP", "Luciferalfa", "BBZ" },
                    { 107, 14, "Braum", 9, 1, "TAS2", "SUP", "Luciferalfa", "BBZ" },
                    { 91, 4, "Kindred", 7, 4, "TAS", "JNG", "Ssunrise", "BBZ" },
                    { 106, 3, "Leona", 6, 1, "PTP2", "SUP", "Luciferalfa", "BBZ" },
                    { 104, 12, "Galio", 1, 1, "GURL2", "SUP", "Luciferalfa", "BBZ" },
                    { 103, 17, "Galio", 2, 2, "DD2", "SUP", "Luciferalfa", "BBZ" },
                    { 102, 11, "Lulu", 3, 0, "YUP", "SUP", "Luciferalfa", "BBZ" },
                    { 101, 7, "Senna", 2, 1, "TAS", "SUP", "Luciferalfa", "BBZ" },
                    { 100, 6, "Nautalis", 9, 2, "PTP", "SUP", "Luciferalfa", "BBZ" },
                    { 99, 3, "Morgana", 6, 0, "INT", "SUP", "Luciferalfa", "BBZ" },
                    { 98, 12, "Sona", 1, 3, "GURL", "SUP", "Luciferalfa", "BBZ" },
                    { 97, 12, "Morgana", 0, 0, "DD", "SUP", "Luciferalfa", "BBZ" },
                    { 96, 3, "Miss-Fortune", 3, 7, "PTP2", "ADC", "Ssunrise", "BBZ" },
                    { 95, 3, "Kai'sa", 3, 0, "INT2", "ADC", "Ssunrise", "BBZ" },
                    { 94, 5, "Kai'sa", 1, 14, "GURL2", "ADC", "Ssunrise", "BBZ" },
                    { 93, 10, "Kai'sa", 1, 14, "DD2", "ADC", "Ssunrise", "BBZ" },
                    { 105, 2, "Galio", 7, 0, "INT2", "SUP", "Luciferalfa", "BBZ" },
                    { 61, 2, "Maoki", 5, 1, "INT", "TOP", "ShieldedValor", "BBZ" },
                    { 60, 5, "Tahm Kench", 5, 0, "PTP2", "SUP", "Unburdened", "GURL" },
                    { 59, 1, "Leona", 6, 0, "INT2", "SUP", "Unburdened", "GURL" },
                    { 27, 5, "Nocturne", 9, 6, "PTP", "JNG", "Willow233", "GURL" },
                    { 26, 4, "Skarner", 5, 2, "INT", "JNG", "Willow233", "GURL" },
                    { 25, 20, "Ammumu", 4, 4, "DD", "JNG", "Willow233", "GURL" },
                    { 24, 11, "Skarner", 3, 2, "BBZ", "JNG", "Willow233", "GURL" },
                    { 23, 14, "Warwick", 10, 1, "YUP", "JNG", "Willow233", "GURL" },
                    { 22, 3, "Mordakaiser", 4, 3, "TAS", "TOP", "Willow233", "GURL" },
                    { 21, 5, "Kled", 7, 3, "PTP2", "TOP", "BakinPancakes", "GURL" },
                    { 20, 2, "Poppy", 6, 1, "INT2", "TOP", "BakinPancakes", "GURL" },
                    { 19, 4, "Urgot", 7, 3, "DD2", "TOP", "BakinPancakes", "GURL" },
                    { 18, 3, "Urgot", 5, 2, "BBZ2", "TOP", "BakinPancakes", "GURL" },
                    { 17, 8, "Urgot", 4, 13, "YUP2", "TOP", "BakinPancakes", "GURL" },
                    { 16, 9, "Mordakaiser", 7, 7, "TAS2", "TOP", "BakinPancakes", "GURL" },
                    { 28, 13, "Hecraim", 9, 4, "TAS2", "JNG", "Willow233", "GURL" },
                    { 15, 8, "Kled", 6, 6, "PTP", "TOP", "BakinPancakes", "GURL" },
                    { 13, 10, "Mordakaiser", 4, 11, "DD", "TOP", "BakinPancakes", "GURL" },
                    { 12, 3, "Kled", 6, 3, "BBZ", "TOP", "BakinPancakes", "GURL" },
                    { 11, 11, "Urgot", 2, 7, "YUP", "TOP", "BakinPancakes", "GURL" },
                    { 10, 2, "Caitlyn", 5, 3, "PTP2", "ADC", "Theroclease", "GURL" },
                    { 9, 0, "Ashe", 7, 2, "INT2", "ADC", "Theroclease", "GURL" },
                    { 8, 0, "Pyke", 6, 1, "BBZ2", "SUP", "Theroclease", "GURL" },
                    { 7, 17, "Morgana", 7, 3, "YUP2", "SUP", "Theroclease", "GURL" },
                    { 6, 15, "Thresh", 4, 1, "TAS2", "SUP", "Theroclease", "GURL" },
                    { 5, 11, "Lucian", 7, 3, "PTP", "ADC", "Theroclease", "GURL" },
                    { 4, 3, "Tristina", 4, 7, "INT", "ADC", "Theroclease", "GURL" },
                    { 3, 12, "Ezreal", 1, 11, "DD", "ADC", "Theroclease", "GURL" },
                    { 2, 8, "Jinx", 2, 15, "YUP", "ADC", "Theroclease", "GURL" },
                    { 14, 1, "Mordakaiser", 4, 3, "INT", "TOP", "BakinPancakes", "GURL" },
                    { 29, 15, "Nunu", 8, 3, "YUP2", "JNG", "Willow233", "GURL" },
                    { 30, 3, "Nunu", 4, 1, "BBZ2", "JNG", "Willow233", "GURL" },
                    { 31, 7, "Nocturne", 10, 0, "DD2", "JNG", "Willow233", "GURL" },
                    { 58, 8, "Nami", 3, 0, "DD2", "SUP", "Warlock-Herald", "GURL" },
                    { 57, 3, "Hecraim", 7, 3, "PTP2", "JNG", "Truelax21", "GURL" },
                    { 56, 2, "Trundle", 7, 3, "INT2", "JNG", "Truelax21", "GURL" },
                    { 55, 4, "Ashe", 5, 4, "DD2", "ADC", "Truelax21", "GURL" },
                    { 54, 7, "Senna", 5, 3, "BBZ", "SUP", "Vale-Claddath", "GURL" },
                    { 53, 14, "Thresh", 9, 0, "TAS", "SUP", "Vale-Claddath", "GURL" },
                    { 52, 14, "Graves", 3, 3, "TAS", "JNG", "TyrantKingTyrone", "GURL" },
                    { 51, 0, "Xayah", 5, 1, "BBZ2", "ADC", "Mr-Turbo-Int", "GURL" },
                    { 50, 9, "Ezreal", 6, 6, "YUP2", "ADC", "Mr-Turbo-Int", "GURL" },
                    { 49, 12, "Ashe", 8, 4, "TAS2", "ADC", "Mr-Turbo-Int", "GURL" },
                    { 48, 11, "Leona", 9, 0, "PTP", "SUP", "Mr-Turbo-Int", "GURL" },
                    { 47, 8, "Leona", 7, 0, "INT", "SUP", "Mr-Turbo-Int", "GURL" },
                    { 46, 10, "Lux", 3, 2, "DD", "SUP", "Mr-Turbo-Int", "GURL" },
                    { 45, 7, "Jinx", 6, 0, "BBZ", "ADC", "Mr-Turbo-Int", "GURL" },
                    { 44, 5, "Pyke", 6, 1, "YUP", "SUP", "Mr-Turbo-Int", "GURL" },
                    { 43, 6, "Malzahar", 4, 3, "PTP2", "MID", "XNek0X", "GURL" },
                    { 42, 0, "Annie", 3, 1, "INT2", "MID", "XNek0X", "GURL" },
                    { 41, 4, "Malzahar", 6, 3, "DD2", "MID", "XNek0X", "GURL" },
                    { 40, 3, "Veigar", 5, 2, "BBZ2", "MID", "XNek0X", "GURL" },
                    { 39, 9, "Le-Blanc", 4, 3, "YUP2", "MID", "XNek0X", "GURL" },
                    { 38, 7, "Lissandra", 8, 12, "TAS2", "MID", "XNek0X", "GURL" },
                    { 37, 3, "Brand", 5, 3, "PTP", "MID", "XNek0X", "GURL" },
                    { 36, 4, "Malzahar", 3, 0, "INT", "MID", "XNek0X", "GURL" },
                    { 35, 11, "Brand", 4, 4, "DD", "MID", "XNek0X", "GURL" },
                    { 34, 2, "Lissandra", 5, 10, "BBZ", "MID", "XNek0X", "GURL" },
                    { 33, 17, "Morgana", 4, 3, "YUP", "MID", "XNek0X", "GURL" },
                    { 32, 12, "Malzahar", 6, 4, "TAS", "MID", "XNek0X", "GURL" },
                    { 119, 0, "Kai'sa", 3, 6, "TUP2", "ADC", "Chris-Sunga", "BBZ" },
                    { 120, 4, "Varus", 7, 1, "PTP", "ADC", "Abhi Kris", "BBZ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
