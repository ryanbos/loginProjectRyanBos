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
    public partial class homePage : UserControl
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //logInScreen lis = new logInScreen();
            //this.Controls.Add(lis);

            Form f = this.FindForm();
            f.Controls.Remove(this);
            logInScreen lis = new logInScreen();
            f.Controls.Add(lis);
            lis.Location = new Point((f.Width - lis.Width) / 2, (f.Height - lis.Height) / 2);
        }
    }
}
