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
    public partial class DeleteBaseUserControl : UserControl
    {
        public string login;
        DataBaseClass DB = new DataBaseClass();

        public DeleteBaseUserControl()
        {
            InitializeComponent();
        }

        //Load bases to listView
        public void loadBases()
        {
            basesListView.Items.Clear();
            DataTable tableList = DB.selectFromDB("SHOW TABLES LIKE '" + login + "\\_%'");
            foreach (DataRow row in tableList.Rows)
            {
                ListViewItem item = new ListViewItem(DB.deletePrefix(row[0].ToString(), login));
                basesListView.Items.Add(item);
            }
        }

        //Delete checked base
        private void deleteBaseButton_Click(object sender, EventArgs e)
        {
            string baseToDelete = basesListView.SelectedItems[0].Text;
            DB.executeDB("DROP TABLE " + login + "_"+ baseToDelete);
            loadBases();
        }

    }
}
