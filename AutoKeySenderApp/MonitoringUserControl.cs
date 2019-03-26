using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKeySenderApp
{
    public partial class MonitoringUserControl : UserControl
    {
        DataBaseClass DB = new DataBaseClass();
        public string login;

        public MonitoringUserControl()
        {
            InitializeComponent();
        }

        //Load monits to DataGridView
        public void loadMonits()
        {
            DataTable monits = DB.selectFromDB("SELECT monit_name, offer_name, code_base, template, active FROM offers_" + login);
            monitsDataGridView.DataSource = monits;
        }

        //Delete selected monit
        private void deleteMonitButton_Click(object sender, EventArgs e)
        {
            int rowindex = monitsDataGridView.CurrentCell.RowIndex;
            DB.executeDB("DELETE FROM offers_" + login + " WHERE monit_name = '" + monitsDataGridView.Rows[rowindex].Cells[0].Value.ToString() + "'");
            loadMonits();
        }
    }
}
