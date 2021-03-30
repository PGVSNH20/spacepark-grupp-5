using System;
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
                if (results != null)
                {
                    nameLabel.Visible = true;
                    nameLabel.Text = $"name: {results["name"]}, id: {results["birth_year"]}";
                }
                    await Task.Delay(1000);
                this.Hide();
                form2.ShowForm(results);
            }
            catch (ArgumentOutOfRangeException)
            {
                nameLabel.Visible = false;
                noPark.Visible = true;
                yesPark.Visible = false;
            }
        }
    }
}
