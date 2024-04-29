using FinalAPIDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDemoAPI.Test.MockData
{
    public class DemoMockData
    {
        public static List<Player> GetPlayers()
        {
            return new List<Player>
            {
                new Player
                {
                    PlayerID = "1",
                    BirthYear = 1981,
                    BirthMonth = 12,
                    BirthDay = 27,
                    BirthCountry = "USA",
                    BirthState = "CO",
                    BirthCity = "Denver",
                    DeathYear = null,
                    DeathMonth = null,
                    DeathDay = null,
                    DeathCountry = "",
                    DeathState = "",
                    DeathCity = "",
                    NameFirst = "David",
                    NameLast = "Aardsma",
                    NameGiven = "David Allan",
                    Weight = 215,
                    Height = 75,
                    Bats = "R",
                    Throws = "R",
                    Debut = DateTime.Now,
                    FinalGame = DateTime.Now,
                    RetroID = "aardd001",
                    BbrefID = "aardsda01"
                },
                new Player
                {
                    PlayerID = "2",
                    BirthYear = 1981,
                    BirthMonth = 12,
                    BirthDay = 27,
                    BirthCountry = "USA",
                    BirthState = "CO",
                    BirthCity = "Denver",
                    DeathYear = null,
                    DeathMonth = null,
                    DeathDay = null,
                    DeathCountry = "",
                    DeathState = "",
                    DeathCity = "",
                    NameFirst = "David",
                    NameLast = "Aardsma",
                    NameGiven = "David Allan",
                    Weight = 215,
                    Height = 75,
                    Bats = "R",
                    Throws = "R",
                    Debut = DateTime.Now,
                    FinalGame = DateTime.Now,
                    RetroID = "aardd001",
                    BbrefID = "aardsda01"
                },
                new Player
                {
                    PlayerID = "3",
                    BirthYear = 1981,
                    BirthMonth = 12,
                    BirthDay = 27,
                    BirthCountry = "USA",
                    BirthState = "CO",
                    BirthCity = "Denver",
                    DeathYear = null,
                    DeathMonth = null,
                    DeathDay = null,
                    DeathCountry = "",
                    DeathState = "",
                    DeathCity = "",
                    NameFirst = "David",
                    NameLast = "Aardsma",
                    NameGiven = "David Allan",
                    Weight = 215,
                    Height = 75,
                    Bats = "R",
                    Throws = "R",
                    Debut = DateTime.Now,
                    FinalGame = DateTime.Now,
                    RetroID = "aardd001",
                    BbrefID = "aardsda01"
                }
            };
        }
    }
}
