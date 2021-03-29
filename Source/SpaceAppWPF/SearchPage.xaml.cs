using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SpaceAppWPF
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            var person = await StarWarsApi.SearchAsync(inputText.Text);
            var starShipPage = new StarShipPage();
            var nav = NavigationService.GetNavigationService(this);
            await Task.Run(async () =>
            {
                await Dispatcher.Invoke(async () =>
                {
                    try
                    {
                        //json-svaret är i key value pairs
                        var results = person["results"][0];
                        starShipPage.Person = results;
                        noPark.Visibility = Visibility.Hidden;
                        yesPark.Visibility = Visibility.Visible;
                        if (results != null)
                        {
                            resultsLabel.Content = $"namn: {results["name"]} född: {results["birth_year"]}";
                            resultsLabel.Visibility = Visibility.Visible;
                        }
                        await Task.Delay(1000);
                        nav.Navigate(starShipPage);
                        //Skriv ut från key value
                        //Console.WriteLine($"Namn: {results["name"]}, Födelseår: {results["birth_year"]}, Hårfärg: {results["hair_color"]}");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        noPark.Visibility = Visibility.Visible;
                        yesPark.Visibility = Visibility.Hidden;
                    }
                });
            });
        }
    }
}