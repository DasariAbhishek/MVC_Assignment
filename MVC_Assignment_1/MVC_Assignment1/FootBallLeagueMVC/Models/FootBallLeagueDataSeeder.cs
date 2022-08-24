using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootBallLeagueMVC.Models
{
    public class FootBallLeagueDataSeeder : DropCreateDatabaseIfModelChanges<FootBallLeagueDBContext>
    {
        protected override void Seed(FootBallLeagueDBContext context)
        {
            FootBallLeague league1 = new FootBallLeague()
            {
                MatchID = 1001,
                TeamName1 = "Italy",
                TeamName2 = "France",
                Status = "Win",
                WinningTeam = "France",
                Points = 4
            };
            FootBallLeague league2 = new FootBallLeague()
            {
                MatchID = 1002,
                TeamName1 = "Brazil",
                TeamName2 = "Portugal",
                Status = "Draw",
                WinningTeam = null,
                Points = 2
            };
            FootBallLeague league3 = new FootBallLeague()
            {
                MatchID = 1003,
                TeamName1 = "England",
                TeamName2 = "Japan",
                Status = "Win",
                WinningTeam = "England",
                Points = 4
            };
            FootBallLeague league4 = new FootBallLeague()
            {
                MatchID = 1004,
                TeamName1 = "USA",
                TeamName2 = "Russia",
                Status = "Win",
                WinningTeam = "Russia",
                Points = 4
            };
            FootBallLeague league5 = new FootBallLeague()
            {
                MatchID = 1005,
                TeamName1 = "Portugal",
                TeamName2 = "Italy",
                Status = "Draw",
                WinningTeam = null,
                Points = 2
            };
            FootBallLeague league6 = new FootBallLeague()
            {
                MatchID = 1006,
                TeamName1 = "Brazil",
                TeamName2 = "France",
                Status = "Win",
                WinningTeam = "Brazil",
                Points = 4
            };
            FootBallLeague league7 = new FootBallLeague()
            {
                MatchID = 1007,
                TeamName1 = "England",
                TeamName2 = "Russia",
                Status = "Win",
                WinningTeam = "Russia",
                Points = 4
            };
            FootBallLeague league8 = new FootBallLeague()
            {
                MatchID = 1008,
                TeamName1 = "Japan",
                TeamName2 = "USA",
                Status = "Draw",
                WinningTeam = null,
                Points = 2
            };
            context.leagues.Add(league1);
            context.leagues.Add(league2);
            context.leagues.Add(league3);
            context.leagues.Add(league4);
            context.leagues.Add(league5);
            context.leagues.Add(league6);
            context.leagues.Add(league7);
            context.leagues.Add(league8);
            base.Seed(context);
        }
    }
}