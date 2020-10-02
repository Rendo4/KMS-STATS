using Microsoft.EntityFrameworkCore;

namespace Stats.Models
{
  public class StatsContext : DbContext
  {
    public StatsContext(DbContextOptions<StatsContext> options)
      : base(options)
    {
    }

    public DbSet<Player> Players { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
     { 
      builder.Entity<Player>()
        .HasData(
          new Player { PlayerId = 1, Summoner = "Theroclease", Team = "GURL", Opponent = "TAS", Champion = "Caitlyn", Kills = 14, Deaths = 5, Assists = 7 },
          new Player { PlayerId = 2, Summoner = "Theroclease", Team = "GURL", Opponent = "YUP", Champion = "Jinx", Kills = 15, Deaths = 2, Assists = 8 },
          new Player { PlayerId = 3, Summoner = "Theroclease", Team = "GURL", Opponent = "DD", Champion = "Ezreal", Kills = 11, Deaths = 1, Assists = 12 },
          new Player { PlayerId = 4, Summoner = "Theroclease", Team = "GURL", Opponent = "INT", Champion = "Tristina", Kills = 7, Deaths = 4, Assists = 3 },
          new Player { PlayerId = 5, Summoner = "Theroclease", Team = "GURL", Opponent = "PTP", Champion = "Lucian", Kills = 3, Deaths = 7, Assists = 11 },
          new Player { PlayerId = 6, Summoner = "Theroclease", Team = "GURL", Opponent = "TAS", Champion = "Thresh", Kills = 1, Deaths = 4, Assists = 15 },
          new Player { PlayerId = 7, Summoner = "Theroclease", Team = "GURL", Opponent = "YUP", Champion = "Morgana", Kills = 3, Deaths = 7, Assists = 17 },
          new Player { PlayerId = 8, Summoner = "Theroclease", Team = "GURL", Opponent = "BBZ", Champion = "Pyke", Kills = 1, Deaths = 6, Assists = 0 },
          new Player { PlayerId = 9, Summoner = "Theroclease", Team = "GURL", Opponent = "INT", Champion = "Ashe", Kills = 2, Deaths = 7, Assists = 0 },
          new Player { PlayerId = 10, Summoner = "Theroclease", Team = "GURL", Opponent = "PTP", Champion = "Caitlyn", Kills = 3, Deaths = 5, Assists = 2 },
          new Player { PlayerId = 11, Summoner = "BakinPancakes", Team = "GURL", Opponent = "YUP", Champion = "Urgot", Kills = 7, Deaths = 2, Assists = 11 },
          new Player { PlayerId = 12, Summoner = "BakinPancakes", Team = "GURL", Opponent = "BBZ", Champion = "Kled", Kills = 3, Deaths = 6, Assists = 3 },
          new Player { PlayerId = 13, Summoner = "BakinPancakes", Team = "GURL", Opponent = "DD", Champion = "Mordakaiser", Kills = 11, Deaths = 4, Assists = 10 },
          new Player { PlayerId = 14, Summoner = "BakinPancakes", Team = "GURL", Opponent = "INT", Champion = "Mordakaiser", Kills = 3, Deaths = 4, Assists = 1 },
          new Player { PlayerId = 15, Summoner = "BakinPancakes", Team = "GURL", Opponent = "PTP", Champion = "Kled", Kills = 6, Deaths = 6, Assists = 8 },
          new Player { PlayerId = 16, Summoner = "BakinPancakes", Team = "GURL", Opponent = "TAS", Champion = "Mordakaiser", Kills = 7, Deaths = 7, Assists = 9 },
          new Player { PlayerId = 17, Summoner = "BakinPancakes", Team = "GURL", Opponent = "YUP", Champion = "Urgot", Kills = 13, Deaths = 4, Assists = 8 },
          new Player { PlayerId = 18, Summoner = "BakinPancakes", Team = "GURL", Opponent = "BBZ", Champion = "Urgot", Kills = 2, Deaths = 5, Assists = 3 },
          new Player { PlayerId = 19, Summoner = "BakinPancakes", Team = "GURL", Opponent = "DD", Champion = "Urgot", Kills = 3, Deaths = 7, Assists = 4 },
          new Player { PlayerId = 20, Summoner = "BakinPancakes", Team = "GURL", Opponent = "INT", Champion = "Poppy", Kills = 1, Deaths = 6, Assists = 2 },
          new Player { PlayerId = 21, Summoner = "BakinPancakes", Team = "GURL", Opponent = "PTP", Champion = "Kled", Kills = 3, Deaths = 7, Assists = 5 },
          new Player { PlayerId = 22, Summoner = "Willow233", Team = "GURL", Opponent = "TAS", Champion = "Mordakaiser", Kills = 3, Deaths = 4, Assists = 3 },
          new Player { PlayerId = 23, Summoner = "Willow233", Team = "GURL", Opponent = "YUP", Champion = "Warwick", Kills = 1, Deaths = 10, Assists = 14 },
          new Player { PlayerId = 24, Summoner = "Willow233", Team = "GURL", Opponent = "BBZ", Champion = "Skarner", Kills = 2, Deaths = 3, Assists = 11 },
          new Player { PlayerId = 25, Summoner = "Willow233", Team = "GURL", Opponent = "DD", Champion = "Ammumu", Kills = 4, Deaths = 4, Assists = 20 },
          new Player { PlayerId = 26, Summoner = "Willow233", Team = "GURL", Opponent = "INT", Champion = "Skarner", Kills = 2, Deaths = 5, Assists = 4 },
          new Player { PlayerId = 27, Summoner = "Willow233", Team = "GURL", Opponent = "PTP", Champion = "Nocturne", Kills = 6, Deaths = 9, Assists = 5 },
          new Player { PlayerId = 28, Summoner = "Willow233", Team = "GURL", Opponent = "TAS", Champion = "Hecraim", Kills = 4, Deaths = 9, Assists = 13 },
          new Player { PlayerId = 29, Summoner = "Willow233", Team = "GURL", Opponent = "YUP", Champion = "Nunu", Kills = 3, Deaths = 8, Assists = 15 },
          new Player { PlayerId = 30, Summoner = "Willow233", Team = "GURL", Opponent = "BBZ", Champion = "Nunu", Kills = 1, Deaths = 4, Assists = 3 },
          new Player { PlayerId = 31, Summoner = "Willow233", Team = "GURL", Opponent = "DD", Champion = "Nocturne", Kills = 0, Deaths = 10, Assists = 7 },
          new Player { PlayerId = 32, Summoner = "XNek0X", Team = "GURL", Opponent = "TAS", Champion = "Malzahar", Kills = 4, Deaths = 6, Assists = 12 },          
          new Player { PlayerId = 33, Summoner = "XNek0X", Team = "GURL", Opponent = "YUP", Champion = "Morgana", Kills = 3, Deaths = 4, Assists = 17 },
          new Player { PlayerId = 34, Summoner = "XNek0X", Team = "GURL", Opponent = "BBZ", Champion = "Lissandra", Kills = 10, Deaths = 5, Assists = 2 },
          new Player { PlayerId = 35, Summoner = "XNek0X", Team = "GURL", Opponent = "DD", Champion = "Brand", Kills = 4, Deaths = 4, Assists = 11 },
          new Player { PlayerId = 36, Summoner = "XNek0X", Team = "GURL", Opponent = "INT", Champion = "Malzahar", Kills = 0, Deaths = 3, Assists = 4 },
          new Player { PlayerId = 37, Summoner = "XNek0X", Team = "GURL", Opponent = "PTP", Champion = "Brand", Kills = 3, Deaths = 5, Assists = 3 },
          new Player { PlayerId = 38, Summoner = "XNek0X", Team = "GURL", Opponent = "TAS", Champion = "Lissandra", Kills = 12, Deaths = 8, Assists = 7 },
          new Player { PlayerId = 39, Summoner = "XNek0X", Team = "GURL", Opponent = "YUP", Champion = "Le Blanc", Kills = 3, Deaths = 4, Assists = 9 },
          new Player { PlayerId = 40, Summoner = "XNek0X", Team = "GURL", Opponent = "BBZ", Champion = "Veigar", Kills = 2, Deaths = 5, Assists = 3 },
          new Player { PlayerId = 41, Summoner = "XNek0X", Team = "GURL", Opponent = "DD", Champion = "Malzahar", Kills = 3, Deaths = 6, Assists = 4 }, 
          new Player { PlayerId = 42, Summoner = "XNek0X", Team = "GURL", Opponent = "INT", Champion = "Annie", Kills = 1, Deaths = 3, Assists = 0 },
          new Player { PlayerId = 43, Summoner = "XNek0X", Team = "GURL", Opponent = "PTP", Champion = "Malzahar", Kills = 3, Deaths = 4, Assists = 6 },
          new Player { PlayerId = 44, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "YUP", Champion = "Pyke", Kills = 1, Deaths = 6, Assists = 5 },
          new Player { PlayerId = 45, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "BBZ", Champion = "Jinx", Kills = 0, Deaths = 6, Assists = 7 },
          new Player { PlayerId = 46, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "DD", Champion = "Lux", Kills = 2, Deaths = 3, Assists = 10 },
          new Player { PlayerId = 47, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "INT", Champion = "Leona", Kills = 0, Deaths = 7, Assists = 8 },
          new Player { PlayerId = 48, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "PTP", Champion = "Leona", Kills = 0, Deaths = 9, Assists = 11 },
          new Player { PlayerId = 49, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "TAS", Champion = "Ashe", Kills = 4, Deaths = 8, Assists = 12 },
          new Player { PlayerId = 50, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "YUP", Champion = "Ezreal", Kills = 6, Deaths = 6, Assists = 9 },
          new Player { PlayerId = 51, Summoner = "Mr Turbo Int", Team = "GURL", Opponent = "BBZ", Champion = "Xayah", Kills = 1, Deaths = 5, Assists = 0 },
          new Player { PlayerId = 52, Summoner = "TyrantKingTyrone", Team = "GURL", Opponent = "TAS", Champion = "Graves", Kills = 3, Deaths = 3, Assists = 14 },
          new Player { PlayerId = 53, Summoner = "Vale Claddath", Team = "GURL", Opponent = "TAS", Champion = "Thresh", Kills = 0, Deaths = 9, Assists = 14 },
          new Player { PlayerId = 54, Summoner = "Vale Claddath", Team = "GURL", Opponent = "BBZ", Champion = "Senna", Kills = 3, Deaths = 5, Assists = 7 },
          new Player { PlayerId = 55, Summoner = "Truelax21", Team = "GURL", Opponent = "DD", Champion = "Ashe", Kills = 4, Deaths = 5, Assists = 4 },
          new Player { PlayerId = 56, Summoner = "Truelax21", Team = "GURL", Opponent = "INT", Champion = "Trundle", Kills = 3, Deaths = 7, Assists = 2 },
          new Player { PlayerId = 57, Summoner = "Truelax21", Team = "GURL", Opponent = "PTP", Champion = "Hecraim", Kills = 3, Deaths = 7, Assists = 3 },
          new Player { PlayerId = 58, Summoner = "Warlock Herald", Team = "GURL", Opponent = "DD", Champion = "Nami", Kills = 0, Deaths = 3, Assists = 8 },
          new Player { PlayerId = 59, Summoner = "Unburdened", Team = "GURL", Opponent = "INT", Champion = "Leona", Kills = 0, Deaths = 6, Assists = 1 },
          new Player { PlayerId = 60, Summoner = "Unburdened", Team = "GURL", Opponent = "PTP", Champion = "Tahm Kench", Kills = 0, Deaths = 5, Assists = 5 }                   
          );
    }
  }
}