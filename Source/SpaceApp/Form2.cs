using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

namespace SpaceApp
{
    public partial class Form2 : Form
    {
        public dynamic Person { get; set; }
        public Form2()
        {
            InitializeComponent();                      
        }

        public void ShowForm(dynamic person)
        {
            Person = person;
            this.ShowDialog();
        }

        private async void button1_Click_1Async(object sender, EventArgs e)
        {
            //var ships = await GetShipsAsync();
            var list = await GetShipsFromSelectedPerson();
            foreach (var ship in list)
            {
                listBox1.Items.Add($"{Person["name"]} äger skeppet {ship["name"]}");
            }
        }

        public async Task<List<dynamic>> GetShipsAsync()
        {
            List<dynamic> ships = new List<dynamic>();
            Rest starwars = new Rest();
            Random rand = new Random();

            try
            {
                var page = rand.Next(1, 5);
                var response = await starwars.StarWarsApiRequestAsync($"starships/?page={page}");
                var ship = starwars.Deserialize<dynamic>(response);

                //Få ut 3 st random ship åt gången när man klickar på sök-knappen
                for (var i = 0; i < 3; i++)
                {
                    var randomship = rand.Next(1, 10);
                    var results = ship["results"][randomship];
                    ships.Add(results);
                    if (results != null) listBox1.Items.Add($"Shipname: {results["name"]} kostar {results["cost_in_credits"]}");
                }
            }
            catch (Exception)
            {
                listBox1.Items.Add("Ops, något fel hände");
            }
            return ships;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void label1_ClickAsync(object sender, EventArgs e)
        {

        }

        public async Task<List<dynamic>> GetShipsFromSelectedPerson()
        {
            Rest starwars = new Rest();
            var ships = Person["starships"];
            List<dynamic> shiplist = new List<dynamic>();
            foreach (var ship in ships)
            {
                //"https://swapi.dev/api/starships/12/"

                var newship = ship.Remove(0, 21);
                var response = await starwars.StarWarsApiRequestAsync(newship);
                var starship = starwars.Deserialize<dynamic>(response);
                shiplist.Add(starship);
            }
            return shiplist;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    /*public class RundKnapp : Button
    {
        GraphicsPath p = new GraphicsPath();
        p.AddEllipse()
    }*/
}
