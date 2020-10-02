using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Stats.Models;
using Microsoft.EntityFrameworkCore;

namespace Stats.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlayersController : ControllerBase
  {
    private StatsContext _db;

    public PlayersController(StatsContext db)
    {
      _db = db;
    }

    // GET api/players
    [HttpGet]
    public ActionResult<IEnumerable<Player>> Get(string summoner, string champion, string role, string team, string opponent)
    {
      var query = _db.Players.AsQueryable();

      if (summoner != null)
      {
        query = query.Where(entry => entry.Summoner == summoner);
      }

      if (champion != null)
      {
        query = query.Where(entry => entry.Champion == champion);
      }

      if (team != null)
      {
        query = query.Where(entry => entry.Team == team);
      }

      if (opponent != null)
      {
        query = query.Where(entry => entry.Opponent == opponent);
      }

      if (role != null)
      {
        query = query.Where(entry => entry.Role == role);
      }
       return query.ToList();
    }

    // POST api/player
    [HttpPost]
    public void Post([FromBody] Player player)
    {
      _db.Players.Add(player);
      _db.SaveChanges();
    }
     // PUT api/player/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Player player)
    {
      player.PlayerId = id;
      _db.Entry(player).State = EntityState.Modified;
      _db.SaveChanges();
    }
     // DELETE api/animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var playerToDelete = _db.Players.FirstOrDefault(entry => entry.PlayerId == id);
      _db.Players.Remove(playerToDelete);
      _db.SaveChanges();
    }
  }
}