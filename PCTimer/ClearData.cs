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
    public partial class ClearData : Form
    {
        public ClearData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("pleasedeletealldata"))
            {
                DBConnector dbc = new DBConnector("DELETE FROM time_records", new System.Data.SqlServerCe.SqlCeCommand());
                dbc.conn.Close();
                MessageBox.Show("Data Cleared!");
            }
            else
            {
                MessageBox.Show("Invalid Password!");
            }
            this.Hide();
        }
    }
}
