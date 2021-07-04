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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            setupRecords();
            displayRecords();
        }

        private void setupRecords()
        {
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.HeaderText = "No.";
            idCol.DataPropertyName = "recordno";
            this.recordsView.Columns.Add(idCol);

            DataGridViewTextBoxColumn minCol = new DataGridViewTextBoxColumn();
            minCol.HeaderText = "Minutes";
            minCol.DataPropertyName = "minutes";
            this.recordsView.Columns.Add(minCol);

            DataGridViewTextBoxColumn valueCol = new DataGridViewTextBoxColumn();
            valueCol.HeaderText = "Value";
            valueCol.DataPropertyName = "value";
            this.recordsView.Columns.Add(valueCol);

            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn();
            dateCol.HeaderText = "Date";
            dateCol.DataPropertyName = "date";
            this.recordsView.Columns.Add(dateCol);
        }

        private void displayRecords()
        {
            DBConnector dbc = new DBConnector("SELECT recordno,minutes,value,date FROM time_records ORDER BY date ASC", "time_records");
            this.recordsView.DataSource = dbc.ds;
            recordsView.DataMember = "time_records";
            dbc.conn.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearData cleardataForm = new ClearData();
            cleardataForm.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            displayRecords();
        }

    }
}
