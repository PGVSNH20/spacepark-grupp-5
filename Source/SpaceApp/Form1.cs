using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

namespace SpaceApp
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
        }

        private async void button1_Click_1Async(object sender, EventArgs e)
        {
            Rest starwars = new Rest();
            var person = await starwars.SearchAsync(textInput.Text);
            try
            {
                //json-svaret är i key value pairs
                var results = person["results"][0];
                yesPark.Visible = true;
                noPark.Visible = false;
                if (results != null) listbox.Items.Add($"namn: {results["name"]} född: {results["birth_year"]}");
                await Task.Delay(1000);
                this.Hide();
                form2.ShowForm(results);
                //Skriv ut från key value
                //Console.WriteLine($"Namn: {results["name"]}, Födelseår: {results["birth_year"]}, Hårfärg: {results["hair_color"]}");
            }
            catch (ArgumentOutOfRangeException)
            {
                noPark.Visible = true;
                yesPark.Visible = false;
            }
        }
        private async void label1_ClickAsync(object sender, EventArgs e)
        {
            Rest starwars = new Rest();
            var results = await starwars.SearchAsync(textInput.Text);
            SpaceParkContext db = new SpaceParkContext();
            Database.PrintFromDatabase(db, this);
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    /*public class RundKnapp : Button
    {
        GraphicsPath p = new GraphicsPath();
        p.AddEllipse(1, 1, this.width - 4, this.width - 4);
        this.region = new Region(p);
    }*/
}
