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
            listBox1.Items.Add($"namn: {results["name"]} född: {results["birth_year"]}");
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Rest starwars = new Rest();
            starwars.GetShips(this);
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
