using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

namespace SpaceApp
{
    public partial class Form2 : Form
    {
        public dynamic Person { get; set; }
        List<dynamic> StarShips { get; set; } = new List<dynamic>();
        Form1 form1;
        ParkingTimerForm form3 { get; set; }
        public Form2(Form1 parent)
        {
            InitializeComponent();
            form3 = new ParkingTimerForm(this);
            form1 = parent;
        }

        public void ShowForm(dynamic person)
        {
            Person = person;
            this.ShowDialog();
        }

        private async void button1_Click_1Async(object sender, EventArgs e)
        {
            var list = await GetShipsFromSelectedPerson();
            if (list.Count != 0)
            {
                foreach (var ship in list)
                {
                    listBox.Items.Add($"{ship["name"]}, owned by {Person["name"]}");
                    StarShips.Add(ship);
                }
            } else
            {
                listBox.Items.Add($"{Person["name"]} doesn't own a starship");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetAllShipsAsync();
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
                        if (results != null)
                        {
                            StarShips.Add(results);
                            listBox.Items.Add($"{results["name"]}");
                        }
                    }
                }
            } 
            catch (Exception)
            {
                listBox.Items.Add("Ops, något fel hände");
            }
        }
        async Task<List<dynamic>> GetShipsFromSelectedPerson()
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

        private void ShipIsSelected(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) shipLabelSelected.Text = listBox.SelectedItem.ToString();
            Color green = Color.FromName("greenyellow");
            SelectShip.Enabled = true;
            SelectShip.BackColor = green;
        }

        //Välj skepp knapp
        private async void button1_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string[] shipname = listBox.SelectedItem.ToString().Split(',');
                foreach (var ship in StarShips.ToList())
                {
                    if (ship["name"] == shipname[0])
                    {
                        await Task.Delay(1000);
                        form3.ShowForm(Person, ship);
                        this.Hide();
                    }
                }
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}
