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
                columns: new[] { "PlayerId", "Assists", "Champion", "Deaths", "Kills", "Opponent", "Summoner", "Team" },
                values: new object[,]
                {
                    { 1, 7, "Caitlyn", 5, 14, "TAS", "Theroclease", "GURL" },
                    { 33, 17, "Morgana", 4, 3, "YUP", "XNek0X", "GURL" },
                    { 34, 2, "Lissandra", 5, 10, "BBZ", "XNek0X", "GURL" },
                    { 35, 11, "Brand", 4, 4, "DD", "XNek0X", "GURL" },
                    { 36, 4, "Malzahar", 3, 0, "INT", "XNek0X", "GURL" },
                    { 37, 3, "Brand", 5, 3, "PTP", "XNek0X", "GURL" },
                    { 38, 7, "Lissandra", 8, 12, "TAS", "XNek0X", "GURL" },
                    { 39, 9, "Le Blanc", 4, 3, "YUP", "XNek0X", "GURL" },
                    { 40, 3, "Veigar", 5, 2, "BBZ", "XNek0X", "GURL" },
                    { 41, 4, "Malzahar", 6, 3, "DD", "XNek0X", "GURL" },
                    { 42, 0, "Annie", 3, 1, "INT", "XNek0X", "GURL" },
                    { 43, 6, "Malzahar", 4, 3, "PTP", "XNek0X", "GURL" },
                    { 44, 5, "Pyke", 6, 1, "YUP", "Mr Turbo Int", "GURL" },
                    { 32, 12, "Malzahar", 6, 4, "TAS", "XNek0X", "GURL" },
                    { 45, 7, "Jinx", 6, 0, "BBZ", "Mr Turbo Int", "GURL" },
                    { 47, 8, "Leona", 7, 0, "INT", "Mr Turbo Int", "GURL" },
                    { 48, 11, "Leona", 9, 0, "PTP", "Mr Turbo Int", "GURL" },
                    { 49, 12, "Ashe", 8, 4, "TAS", "Mr Turbo Int", "GURL" },
                    { 50, 9, "Ezreal", 6, 6, "YUP", "Mr Turbo Int", "GURL" },
                    { 51, 0, "Xayah", 5, 1, "BBZ", "Mr Turbo Int", "GURL" },
                    { 52, 14, "Graves", 3, 3, "TAS", "TyrantKingTyrone", "GURL" },
                    { 53, 14, "Thresh", 9, 0, "TAS", "Vale Claddath", "GURL" },
                    { 54, 7, "Senna", 5, 3, "BBZ", "Vale Claddath", "GURL" },
                    { 55, 4, "Ashe", 5, 4, "DD", "Truelax21", "GURL" },
                    { 56, 2, "Trundle", 7, 3, "INT", "Truelax21", "GURL" },
                    { 57, 3, "Hecraim", 7, 3, "PTP", "Truelax21", "GURL" },
                    { 58, 8, "Nami", 3, 0, "DD", "Warlock Herald", "GURL" },
                    { 46, 10, "Lux", 3, 2, "DD", "Mr Turbo Int", "GURL" },
                    { 31, 7, "Nocturne", 10, 0, "DD", "Willow233", "GURL" },
                    { 30, 3, "Nunu", 4, 1, "BBZ", "Willow233", "GURL" },
                    { 29, 15, "Nunu", 8, 3, "YUP", "Willow233", "GURL" },
                    { 2, 8, "Jinx", 2, 15, "YUP", "Theroclease", "GURL" },
                    { 3, 12, "Ezreal", 1, 11, "DD", "Theroclease", "GURL" },
                    { 4, 3, "Tristina", 4, 7, "INT", "Theroclease", "GURL" },
                    { 5, 11, "Lucian", 7, 3, "PTP", "Theroclease", "GURL" },
                    { 6, 15, "Thresh", 4, 1, "TAS", "Theroclease", "GURL" },
                    { 7, 17, "Morgana", 7, 3, "YUP", "Theroclease", "GURL" },
                    { 8, 0, "Pyke", 6, 1, "BBZ", "Theroclease", "GURL" },
                    { 9, 0, "Ashe", 7, 2, "INT", "Theroclease", "GURL" },
                    { 10, 2, "Caitlyn", 5, 3, "PTP", "Theroclease", "GURL" },
                    { 11, 11, "Urgot", 2, 7, "YUP", "BakinPancakes", "GURL" },
                    { 12, 3, "Kled", 6, 3, "BBZ", "BakinPancakes", "GURL" },
                    { 13, 10, "Mordakaiser", 4, 11, "DD", "BakinPancakes", "GURL" },
                    { 14, 1, "Mordakaiser", 4, 3, "INT", "BakinPancakes", "GURL" },
                    { 15, 8, "Kled", 6, 6, "PTP", "BakinPancakes", "GURL" },
                    { 16, 9, "Mordakaiser", 7, 7, "TAS", "BakinPancakes", "GURL" },
                    { 17, 8, "Urgot", 4, 13, "YUP", "BakinPancakes", "GURL" },
                    { 18, 3, "Urgot", 5, 2, "BBZ", "BakinPancakes", "GURL" },
                    { 19, 4, "Urgot", 7, 3, "DD", "BakinPancakes", "GURL" },
                    { 20, 2, "Poppy", 6, 1, "INT", "BakinPancakes", "GURL" },
                    { 21, 5, "Kled", 7, 3, "PTP", "BakinPancakes", "GURL" },
                    { 22, 3, "Mordakaiser", 4, 3, "TAS", "Willow233", "GURL" },
                    { 23, 14, "Warwick", 10, 1, "YUP", "Willow233", "GURL" },
                    { 24, 11, "Skarner", 3, 2, "BBZ", "Willow233", "GURL" },
                    { 25, 20, "Ammumu", 4, 4, "DD", "Willow233", "GURL" },
                    { 26, 4, "Skarner", 5, 2, "INT", "Willow233", "GURL" },
                    { 27, 5, "Nocturne", 9, 6, "PTP", "Willow233", "GURL" },
                    { 28, 13, "Hecraim", 9, 4, "TAS", "Willow233", "GURL" },
                    { 59, 1, "Leona", 6, 0, "INT", "Unburdened", "GURL" },
                    { 60, 5, "Tahm Kench", 5, 0, "PTP", "Unburdened", "GURL" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
