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
    public partial class Blocker : Form
    {
        //Lloyd John Borres Owns this Program
        public static Boolean disableClose = true;

        public Blocker()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text.ToString().Equals("eljay") && passwordTB.Text.ToString().Equals("eljay9676"))
            {
                Manager managerform = new Manager();
                managerform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void Blocker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (disableClose == true)
            {
                MessageBox.Show("Please Login Program First to Close!");
                Blocker blockerForm = new Blocker();
                blockerForm.Show();
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 161;
            const int WM_SYSCOMMAND = 274;
            const int HTCAPTION = 2;
            const int SC_MOVE = 61456;

            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam.ToInt32() == SC_MOVE))
            {
                return;
            }

            if ((m.Msg == WM_NCLBUTTONDOWN) && (m.WParam.ToInt32() == HTCAPTION))
            {
                return;
            }

            base.WndProc(ref m);
        }
    }
}
