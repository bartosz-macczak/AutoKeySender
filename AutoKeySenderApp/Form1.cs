using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AutoKeySenderApp
{
    public partial class Form1 : Form
    {
        DataBaseClass DB = new DataBaseClass();
        userClass user = new userClass();

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Login process
        private void loginButton_Click(object sender, EventArgs e)
        {
            user.Login = loginBox.Text;
            user.Password = passBox.Text;
            loggedUserControl.clientIdTextBox.Text = DB.singleDsToString(DB.selectFromDB("SELECT client_id FROM users WHERE login = '" + user.Login + "'"));
            loggedUserControl.clientSecretTextBox.Text = DB.singleDsToString(DB.selectFromDB("SELECT client_secret FROM users WHERE login = '" + user.Login + "'"));
            if(loggedUserControl.clientIdTextBox.Text!="")
            {
                loggedUserControl.saveDetailsCheckBox.Checked = true;
            }

            DataTable userDetails = DB.selectFromDB("SELECT pass FROM users WHERE login='"+user.Login+"'");

            //Encrypt password from form
            user.Password = "salt" + user.Password + "aks";
            string pass = user.passEncryprtSHA1(user.Password);

            //Check password from login form
            if (DB.singleDsToString(userDetails)==null)
            {
                MessageBox.Show("Błędny login.", "Logowanie");
            }
            else if(DB.singleDsToString(userDetails)==pass)
            {
                loggedUserControl.Visible = true;
            }
            else
            {
                MessageBox.Show("Błędne hasło.", "Logowanie");
            }
            loggedUserControl.login = user.Login;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerUserControl.Visible = true;
        }

        //Call before closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Na pewno chcesz zamknąć program?", string.Empty, MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            if (result == DialogResult.Yes)
            {
                DB.executeDB("TRUNCATE TABLE temporary_data_" + user.Login + "");
            }
            
        }
    }
}
