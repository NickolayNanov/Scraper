using System.Collections.Generic;

namespace Scrapper.Data.EfBet
{
    public class EfBetModel
    {
        public EfBetModel()
        {
            this.Categories = new List<EfBetCategory>();
        }

        public List<EfBetCategory> Categories { get; set; }
    }
}
