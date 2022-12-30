using System.Collections.Generic;

namespace Scrapper.Data.EfBet
{
    public class EfBetCategory
    {
        public EfBetCategory(string name)
        {
            this.Name = name;
            this.Countries = new List<EfBetCountry>();
        }

        public string Name { get; set; }

        public List<EfBetCountry> Countries { get; set; }
    }
}
