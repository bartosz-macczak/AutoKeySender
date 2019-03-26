using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AutoKeySenderApp
{
    public partial class AuctionCombineUserControl : UserControl
    {
        public string login;
        DataBaseClass DB = new DataBaseClass();
        Rootobject offers;

        public AuctionCombineUserControl()
        {
            InitializeComponent();
        }

        private void downloadAuctionsButton_Click(object sender, EventArgs e)
        {
            //RestAPI request
            string clientID = DB.singleDsToString(DB.selectFromDB("SELECT value FROM temporary_data_" + login + " WHERE name = 'client_id'"));
            string clientSecret = DB.singleDsToString(DB.selectFromDB("SELECT value FROM temporary_data_" + login + " WHERE name = 'client_secret'"));
            AllegroRestAPIClass restAPI = new AllegroRestAPIClass(clientID,clientSecret,login);
            offersToListView(restAPI.getOffers());
        }

        private void offersToListView(string offersJson)
        {
            var des = (Rootobject)Newtonsoft.Json.JsonConvert.DeserializeObject(offersJson, typeof(Rootobject));
            offers = des;
            auctionsListView.Items.Clear();
            loadBases();
            loadTemplates();
            for (int i = des.totalCount; i > 0; i--)
            {
                auctionsListView.Items.Add(des.offers[i - 1].name);
            }  
        }

        //Load base list to combo box
        private void loadBases()
        {
            basesComboBox.Items.Clear();
            DataTable basesList = DB.selectFromDB("SHOW TABLES LIKE '" + login + "\\_%'");
            foreach (DataRow row in basesList.Rows)
            {
                basesComboBox.Items.Add(DB.deletePrefix(row[0].ToString(), login));
            }
        }
        //Load templates list to combo box
        private void loadTemplates()
        {
            templatesComboBox.Items.Clear();
            DataTable templatesList = DB.selectFromDB("SELECT name FROM templates_" + login);
            foreach (DataRow row in templatesList.Rows)
            {
                templatesComboBox.Items.Add(row[0].ToString());
            }
        }
        //Creates monit combination
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            //Check if form is marked correctly
            if(basesComboBox.SelectedIndex > -1 && templatesComboBox.SelectedIndex > -1 && auctionsListView.SelectedItems.Count == 1)
            {
                int active;
                if (activeRadioButton.Checked == true)
                    active = 1;
                else
                    active = 0;

                string offer_id = "";
                for(int i = offers.totalCount;i>0;i--)
                {
                    if(offers.offers[i-1].name == auctionsListView.SelectedItems[0].Text)
                    {
                        offer_id = offers.offers[i - 1].id;
                    }
                }

                //Check if combination name exist
                if (DB.singleDsToString(DB.selectFromDB("SELECT monit_name FROM offers_" + login + " WHERE monit_name = '" + monitNameTextBox.Text + "'")) == null)
                {
                    //Creating combination of offer, code and template
                    DB.executeDB("INSERT INTO offers_" + login + " (monit_name, offer_id, offer_name, code_base, template, active) " +
                        "VALUES ('" + monitNameTextBox.Text + "', '" + offer_id + "', '" + auctionsListView.SelectedItems[0].Text + "', '" + basesComboBox.SelectedItem.ToString() + "', '" + templatesComboBox.SelectedItem.ToString() + "', '" + active + "')");

                }
                else
                {
                    MessageBox.Show("Monitoring o tej nazwie już istenieje.");
                }

            }
            else
            {
                MessageBox.Show("Nie wybrano wszystkich parametrów.");
            }


        }
    }
}
