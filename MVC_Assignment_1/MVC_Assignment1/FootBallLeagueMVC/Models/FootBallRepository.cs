using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootBallLeagueMVC.Models
{
    public class FootBallRepository
    {
        FootBallLeagueDBContext dBContext = new FootBallLeagueDBContext();

        public void AddLeagueDetails(FootBallLeague footBallLeague)
        {
            dBContext.leagues.Add(footBallLeague);
            dBContext.SaveChanges();
        }
    }
}