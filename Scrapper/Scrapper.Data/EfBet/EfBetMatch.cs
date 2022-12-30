namespace Scrapper.Data.EfBet
{
    public class EfBetMatch
    {
        public EfBetMatch(string date, string teams, decimal c1, decimal d, decimal c2)
        {
            this.Date = date;
            this.Teams = teams;
            this.FirstTeamCoef = c1;
            this.Draw = d;
            this.SecondTeamCoef = c2;
        }

        public EfBetMatch(string date, string teams, decimal c1, decimal c2)
        {
            this.Date = date;
            this.Teams = teams;
            this.FirstTeamCoef = c1;
            this.SecondTeamCoef = c2;
        }

        public string Category { get; set; }

        public string Counrty { get; set; }

        public string League { get; set; }

        public string Date { get; set; }

        public string Teams { get; set; }

        public decimal FirstTeamCoef { get; set; }

        public decimal Draw { get; set; }

        public decimal SecondTeamCoef { get; set; }
    }
}
