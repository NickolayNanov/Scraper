using System.Collections.Generic;

namespace Scrapper.Data.EfBet
{
    public class EfBetCountry
    {
        public EfBetCountry(string name)
        {
            this.Name = name;
            this.Leagues = new List<EfBetLeague>();
        }

        public string Name { get; set; }

        public List<EfBetLeague> Leagues { get; set; }
    }
}
