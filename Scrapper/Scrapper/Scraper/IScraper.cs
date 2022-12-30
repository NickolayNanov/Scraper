using System.Threading.Tasks;

namespace Scrapper.Scraper
{
    public interface IScraper<T>
    {
       string Scrape(decimal maxCoef);
    }
}
