using System;
using System.Collections.Generic;
using System.Text;

namespace Scrapper.Data.EfBet
{
    public class EfBetLeague
    {
        public EfBetLeague(string leagueName)
        {
            this.LeagueName = leagueName;
            this.Matches = new List<EfBetMatch>();
        }

        public string LeagueName { get; set; }

        public List<EfBetMatch> Matches { get; set; }
    }
}
