using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTimer
{
    public partial class MainCounter : Form
    {
        //Lloyd John Borres Owns this Program
        public static Boolean disableClose = true;

        public MainCounter()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hrCtr.Text = Timer.getHours().ToString() + "h";
            minCtr.Text = Timer.getMinutes().ToString() + "m";
            secCtr.Text = Timer.getSeconds().ToString() + "s";

            Timer.decSec();

            if (Timer.getHours() == 0 && Timer.getMinutes() == 0 && Timer.getSeconds() == 0)
            {
                timer1.Stop();
                Blocker blockerForm = new Blocker();
                blockerForm.Show();
                this.Hide();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.ToString().Equals("eljay") && passwordTB.Text.ToString().Equals("eljay9676"))
            {
                timer1.Stop();
                Manager managerform = new Manager();
                managerform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void MainCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (disableClose == true)
            {
                MessageBox.Show("Please Login Program First to Close!");
                MainCounter loginForm = new MainCounter();
                loginForm.Show();
            }
        }
    }
}
