using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballClubController : ControllerBase
    {
        public List<string> FootballClubs = new List<string>()
        {
            "Real Madrid CF",
            "FC Barcelona",
            "Manchester United",
            "Manchester City",
            "Liverpool",
            "Arsenal",
            "Bayern Munich",
            "Borussia Dortmund",
            "PSG",
            "RB Leipzig",
            "Juventus",
            "Inter Milan",
            "AC Milan"
        };

        [HttpGet]
        public List<string> GetClub() 
        {
            return FootballClubs;
        }

        [HttpGet("{id}")]
        public string GetClubbyId(int id)
        {
            return FootballClubs.ElementAtOrDefault(id);
        }

        [HttpDelete("{id}")]
        public List<string> DelClub(int id)
        {
            FootballClubs.Remove(GetClubbyId(id));
            return FootballClubs;
        }

        [HttpPut("{id}")]
        public List<string> ChangeClub(int id, string newClub)
        {
            FootballClubs[id] = newClub;
            return FootballClubs;
        }

        [HttpPost]
        public List<string> AddClub(string newClub)
        {
            FootballClubs.Add(newClub);
            return FootballClubs;
        }

    }
}
