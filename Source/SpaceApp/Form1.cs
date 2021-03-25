using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using SpacePark;

namespace SpaceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Rest starwars = new Rest();
            var results = starwars.Search(textBox1.Text);
            listBox1.Items.Add(results["name"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<dynamic> GetShips()
        {
            Rest starwars = new Rest();
            List<dynamic> pageships = new List<dynamic>();
            List<dynamic> ships = new List<dynamic>();

            for (var i = 1; i < 5; i++)
            {
                IRestResponse response = starwars.StarWarsApiRequest($"starships/?page={i}");
                var pageship = starwars.Deserialize<dynamic>(response);
                pageships.Add(pageship);
            }

            foreach (var ship in pageships)
            {
                for (var i = 0; i < ship["results"].Count; i++)
                {
                    var results = ship["results"][i];
                    ships.Add(results);
                    if (results != null) listBox1.Items.Add($"Shipname: {results["name"]} kostar {results["cost_in_credits"]}");
                }
            }

            return ships;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GetShips();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    /*public class RundKnapp : Button
    {
        GraphicsPath p = new GraphicsPath();
        p.AddEllipse()
    }*/
}
