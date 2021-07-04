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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            setTimer();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainCounter loginForm = new MainCounter();
            loginForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainCounter.disableClose = false;
            Blocker.disableClose = false;
            Application.Exit();
        }

        private void setTimer()
        {
            hrCtr.Text = Timer.getHours().ToString() + "hr";
            minCtr.Text = Timer.getMinutes().ToString() + "min";
            secCtr.Text = Timer.getSeconds().ToString() + "sec";
        }

        private void recordTimeToDB(int hours, int value)
        {
            DBConnector dbc = new DBConnector("INSERT INTO time_records (minutes,value) VALUES(" + hours + "," + value + ")", new System.Data.SqlServerCe.SqlCeCommand());
            dbc.conn.Close();
        }

        private void PCTimerManager_Load(object sender, EventArgs e)
        {
            setTimer();
        }

        private void add25min_Click(object sender, EventArgs e)
        {
            Timer.addMinutes(25);
            setTimer();
            recordTimeToDB(25, 5);
        }

        private void add30min_Click(object sender, EventArgs e)
        {
            Timer.addMinutes(30);
            setTimer();
            recordTimeToDB(30, 6);
        }

        private void add1hr_Click(object sender, EventArgs e)
        {
            Timer.addHours(1);
            setTimer();
            recordTimeToDB(60, 12);
        }

        private void add2hr_Click(object sender, EventArgs e)
        {
            Timer.addHours(2);
            setTimer();
            recordTimeToDB(120, 24);
        }

        private void recordsBtn_Click(object sender, EventArgs e)
        {
            Records recordsForm = new Records();
            recordsForm.Show();
        }
    }
}
