﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

namespace SpaceApp
{
    public partial class Form2 : Form
    {
        public dynamic Person { get; set; }
        Form1 form1;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            form1 = parent;
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

        private void ShipIsSelected(object sender, EventArgs e)
        {
            Color green = Color.FromName("greenyellow");
            SelectShip.Enabled = true;
            SelectShip.BackColor = green;          
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) MessageBox.Show($"{listBox.SelectedItem}");
            ParkingTimerForm timer = new ParkingTimerForm();
            await Task.Delay(1000);
            timer.Show();
            this.Hide();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    /*public class RundKnapp : Button
    {
        GraphicsPath p = new GraphicsPath();
        p.AddEllipse()
    }*/
}
