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
    public partial class AddCodesUserControl : UserControl
    {
        public string login;
        public string openedTable;
        DataBaseClass DB = new DataBaseClass();

        public AddCodesUserControl()
        {
            InitializeComponent();
        }

        //Load codes from selected table
        private void chooseBaseButton_Click(object sender, EventArgs e)
        {
            loadCodes();
        }

        //Load codes from table
        public void loadCodes()
        {
            if(chooseAddCodeListView.SelectedItems.Count==0)
            {
                return;
            }
            else
            {
                codesListView.Items.Clear();
                string tableToOpen = chooseAddCodeListView.SelectedItems[0].Text;
                openedTable = tableToOpen;
                DataTable tableList = DB.selectFromDB("SELECT code FROM " + login + "_" + tableToOpen);
                foreach (DataRow row in tableList.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        codesListView.Items.Add(item);
                    }
            }
        }
            

        //Load tables to listView
        public void loadTables()
        {
            chooseAddCodeListView.Items.Clear();
            DataTable tableList = DB.selectFromDB("SHOW TABLES LIKE '" + login + "\\_%'");
            foreach (DataRow row in tableList.Rows)
            {
                ListViewItem item = new ListViewItem(DB.deletePrefix(row[0].ToString(), login));
                chooseAddCodeListView.Items.Add(item);
            }
        }

        //Delete code from DB table
        private void deleteCodeButton_Click(object sender, EventArgs e)
        {
            if(codesListView.SelectedItems.Count==0)
            {
                return;
            }
            else
            {
                string codeToDelete = codesListView.SelectedItems[0].Text;
                DB.executeDB("DELETE FROM "+ login + "_" + openedTable + " WHERE code = '" + codeToDelete+"'");
                loadCodes();
            }
        }

        //Add code to DB table
        private void addCodeButton_Click(object sender, EventArgs e)
        {
            if (addCodesTextBox.Text == "")
            {
                return;
            }
            else
            {
                for (int i = 0; i < addCodesTextBox.Lines.Length; ++i)
                {
                    string code = addCodesTextBox.Lines[i];
                    DB.executeDB("INSERT INTO " + login + "_" + openedTable + " (code) VALUES ('" + code + "')");
                }
                addCodesTextBox.Clear();
                loadCodes();
            }
        }
    }
}
