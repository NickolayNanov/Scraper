using Scrapper.Data.EfBet;
using Scrapper.Scraper;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace Scrapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IScraper<EfBetModel> efBet;

        public MainWindow()
        {
            InitializeComponent();
            efBet = new EfBetScraper();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Button.Content = "Scraping... please wait :)";
            Button.IsEnabled = false;
            string result = "";
            var coef = decimal.TryParse(Coef.Text, out decimal coeficient);
            await Task.Run(() =>
            {
                 result = efBet.Scrape(coeficient);
            });
            watch.Stop();
            Result.Text = result;
            Time.Content = (watch.ElapsedMilliseconds / 1000).ToString();
            Button.Content = "All data has been scraped";
            //Grid grid = new Grid();

            //foreach (var country in result.Countries)
            //{
            //    grid.RowDefinitions.Add(new RowDefinition());
            //    grid.ColumnDefinitions.Add(new ColumnDefinition());
            //    grid.ColumnDefinitions.Add(new ColumnDefinition());
            //    grid.ColumnDefinitions.Add(new ColumnDefinition());
            //    grid.ColumnDefinitions.Add(new ColumnDefinition());
            //    grid.ColumnDefinitions.Add(new ColumnDefinition());

            //    TextBox textBox = new TextBox();
            //    textBox.Text = country.Name;
            //    grid.Children.Add(textBox);
            //}
            //Gridec.Children.Add(grid);
        }
    }
}
