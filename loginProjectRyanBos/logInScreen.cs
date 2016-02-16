using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginProjectRyanBos
{
    public partial class logInScreen : UserControl
    {
        homePage hp = new homePage();
        public static string username = "bobross";
        public static string password = "happytrees";

        public logInScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == username && passTextBox.Text == password)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                homePage hp = new homePage();
                f.Controls.Add(hp);
                hp.Location = new Point((f.Width - hp.Width) / 2, (f.Height - hp.Height) / 2);
            }
            else
            {
                label3.Text = "There are no mistakes, just happy acidents";
                userTextBox.Text = "";
                passTextBox.Text = "";
            }
                    
            }
        }
    }

