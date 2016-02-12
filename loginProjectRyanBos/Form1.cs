using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginProjectRyanBos
{
    public partial class Form1 : Form
    {
        public static string username = "djkhaled";
        public static string password = "lions";
        int test = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextBox.Text == "djkhaled" && passTextBox.Text == "lions" )
            {
                

                homePage hp = new homePage();
                hp.Location = new Point((Width - hp.Width), (this.Height = hp.Height));
                this.Controls.Add(hp);
            }
        }
    }
}
