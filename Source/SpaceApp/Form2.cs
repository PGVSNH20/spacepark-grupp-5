using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

namespace SpaceApp
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        public dynamic Person { get; set; }
        public Form2(Form1 parent)
        {
            InitializeComponent();
            frm1 = parent;
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
                listBox.Items.Add($"{Person["name"]} äger skeppet {ship["name"]}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetAllShipsAsync();
        }

        public async Task<List<dynamic>> GetRandomShipsAsync()
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
                    if (results != null) listBox.Items.Add($"Shipname: {results["name"]} kostar {results["cost_in_credits"]}");
                }
            }
            catch (Exception)
            {
                listBox.Items.Add("Ops, något fel hände");
            }
            return ships;
        }

        public async void GetAllShipsAsync()
        {
            try
            {
                Rest starwars = new Rest();
                //hämta 5 sidor med starships
                for (var i = 1; i < 5; i++)
                {
                    var response = await starwars.StarWarsApiRequestAsync($"starships/?page={i}");
                    var ship = starwars.Deserialize<dynamic>(response);

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

        private void Form1_Load(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ShipIsSelected(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) MessageBox.Show($"{listBox.SelectedItem}");
            ParkButton.Enabled = true;
            Color green = Color.FromName("GreenYellow");
            ParkButton.BackColor = green;
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void ParkButton_Click(object sender, EventArgs e)
        {
            Form1 newform1 = new Form1();
            frm1 = newform1;
            frm1.Show();
            this.Hide();
        }
    }

    /*public class RundKnapp : Button
    {
        GraphicsPath p = new GraphicsPath();
        p.AddEllipse()
    }*/
}
