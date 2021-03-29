using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace SpaceAppWPF
{
    /// <summary>
    /// Interaction logic for StarShipPage.xaml
    /// </summary>
    public partial class StarShipPage : Page
    {
        public dynamic Person { get; set; }

        public StarShipPage()
        {
            InitializeComponent();
        }

        private async void GetAllShips(object sender, RoutedEventArgs e)
        {
            try
            {
                //hämta 5 sidor med starships
                for (var i = 1; i < 5; i++)
                {
                    var response = await StarWarsApi.StarWarsApiRequestAsync($"starships/?page={i}");
                    var ship = StarWarsApi.Deserialize<dynamic>(response);

                    //Skriv ut hela sidan med skepp
                    for (var j = 0; j < ship["results"].Count; j++)
                    {
                        var results = ship["results"][j];
                        if (results != null) listBox.Items.Add($"{results["name"]}      cost: {results["cost_in_credits"]}");
                    }
                }
            }
            catch (Exception)
            {
                listBox.Items.Add("Ops, något fel hände");
            }
        }

        private async void GetMyShips(object sender, RoutedEventArgs e)
        {
            var ships = Person["starships"];
                if (ships.Count != 0)
                {
                    foreach (var ship in ships)
                    {
                        var newShip = ship.Remove(0, 21);
                        var response = await StarWarsApi.StarWarsApiRequestAsync(newShip);
                        var starship = StarWarsApi.Deserialize<dynamic>(response);
                        var item = $"{Person["name"]} owns a {starship["name"]}";
                        listBox.Items.Add(item);
                    }
                }
                else
                {
                    listBox.Items.Add($"{Person["name"]} doesn't own a starship");
                }
        }
        private async void ShipIsSelected(object sender, MouseButtonEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                ParkTimer timer = new ParkTimer();
                var nav = NavigationService.GetNavigationService(this);
                MessageBox.Show($"You chose the ship: {listBox.SelectedItem}");
                await Task.Delay(3000);
                nav.Navigate(timer);
            }
        }
    }
}