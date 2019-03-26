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
    public partial class LoggedUserControl : UserControl
    {
        public string login { get; set; }
        DataBaseClass DB = new DataBaseClass();

        public LoggedUserControl()
        {
            InitializeComponent();
        }

        public void closeUserControls()
        {
            addBaseUserControl.Visible = false;
            deleteBaseUserControl.Visible = false;
            addCodesUserControl.Visible = false;
            addTemplateUserControl.Visible = false;
            deleteTemplateUserControl.Visible = false;
            auctionCombineUserControl.Visible = false;
            monitoringUserControl.Visible = false;
        }

        private void addBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            addBaseUserControl.login = login;
            addBaseUserControl.Visible = true;
            
        }

        private void deleteBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            deleteBaseUserControl.login = login;
            deleteBaseUserControl.loadBases();
            deleteBaseUserControl.Visible = true;
            
        }

        private void addCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            addCodesUserControl.login = login;
            addCodesUserControl.loadTables();
            addCodesUserControl.Visible = true;
            

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void addTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            addTemplateUserControl.login = login;
            addTemplateUserControl.Visible = true;
        }

        private void deleteTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            deleteTemplateUserControl.login = login;
            deleteTemplateUserControl.Visible = true;
            deleteTemplateUserControl.loadTemplates();
        }

        private void assignTemplateBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeUserControls();
            auctionCombineUserControl.login = login;
            auctionCombineUserControl.Visible = true;
        }

        private void monitoringToolStripButton_Click(object sender, EventArgs e)
        {
            closeUserControls();
            monitoringUserControl.login = login;
            monitoringUserControl.Visible = true;
            monitoringUserControl.loadMonits();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //Authorization
        private void authorizeButton_Click(object sender, EventArgs e)
        {
            AllegroRestAPIClass restAPI = new AllegroRestAPIClass(clientIdTextBox.Text, clientSecretTextBox.Text, login);
            if (clientIdTextBox.Text=="")
            {
                if(clientSecretTextBox.Text=="")
                {
                    MessageBox.Show("Wypełnij wszystkie pola");
                    return;
                }
                MessageBox.Show("Wypełnij wszystkie pola");
                return;
            }
            else
            if (clientSecretTextBox.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola");
                return;
            }

            //Save details
            if(saveDetailsCheckBox.Checked==true)
            {
                DB.executeDB("UPDATE users SET client_id = '" + clientIdTextBox.Text + "', client_secret = '" + clientSecretTextBox.Text + "' WHERE login = '" + login + "'");
            }
            else
            {
                DB.executeDB("UPDATE users SET client_id = '', client_secret = '' WHERE login = '" + login + "'");
            }
            //Add temporary data to DB
            DB.executeDB("INSERT INTO temporary_data_" + login + " (name, value) VALUES ('client_id', '" + clientIdTextBox.Text + "')");
            DB.executeDB("INSERT INTO temporary_data_" + login + " (name, value) VALUES ('client_secret', '" + clientSecretTextBox.Text + "')");
            //Execute connection method
            restAPI.auth();
        }


        private void startSendingButton_Click(object sender, EventArgs e)
        { 
            sendingTimer.Enabled = true;
            sendStatusLabel.Text = "Wysyłam";
            sendStatusLabel.BackColor = Color.Green;
        }

        private void sendingTimer_Tick(object sender, EventArgs e)
        {
            AllegroRestAPIClass restAPI = new AllegroRestAPIClass(clientIdTextBox.Text, clientSecretTextBox.Text, login);
            ManageOrdersClass manageOrders = new ManageOrdersClass(login);
            manageOrders.ordersToDB(restAPI.getOrders());
            manageOrders.sendNewOrdersFromList();
        }
    }
}
