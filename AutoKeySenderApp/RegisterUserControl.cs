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
    public partial class RegisterUserControl : UserControl
    {
        userClass user = new userClass();

        public RegisterUserControl()
        {
            InitializeComponent();
        }

        private void confirmRegisterButton_Click(object sender, EventArgs e)
        {
            //Register form variables
            userClass user = new userClass();
            user.registerLogin = loginBox.Text;
            user.registerEmail = emailBox.Text;
            user.registerPassword = user.passEncryprtSHA1("salt"+passwordBox.Text+"aks");
            user.registerRepeatPassword = user.passEncryprtSHA1("salt"+repeatPasswordBox.Text+"aks");
            user.registerAcceptReg = regCheckBox.Checked;

            //Check correctness of details
            bool emailCheck = user.emailCheck(user.registerEmail);
            bool passCheck = user.passCheck(user.registerPassword, user.registerRepeatPassword);
            bool loginCheck = user.loginCheck(user.registerLogin);
            bool regCheck = user.regCheck(user.registerAcceptReg);

            if(emailCheck==true && passCheck==true && loginCheck==true && regCheck==true)
            {
                DataBaseClass db = new DataBaseClass();
                //Create new user in DB
                string sql = "INSERT INTO users (login, pass , email) VALUES ('"+user.registerLogin+"','"+user.registerPassword+"','"+user.registerEmail+"')";
                db.executeDB(sql);
                //Create templates data table
                db.executeDB("CREATE TABLE IF NOT EXISTS `templates_" + user.registerLogin + "` (" +
                    "`id` int(10) NOT NULL auto_increment," +
                    "`name` varchar(255)," +
                    "`text` varchar(255)," +
                    "PRIMARY KEY( `id` )" +
                    "); ");
                //Create temp data table
                db.executeDB("CREATE TABLE IF NOT EXISTS `temporary_data_" + user.registerLogin + "` (" +
                    "`id` int(10) NOT NULL auto_increment," +
                    "`name` varchar(255)," +
                    "`value` varchar(1000)," +
                    "PRIMARY KEY( `id` )" +
                    "); ");
                //Create offers data table
                db.executeDB("CREATE TABLE `offers_" + user.registerLogin + "` (" +
                    "`id` INT(10) NOT NULL AUTO_INCREMENT," +
                    "`monit_name` CHAR(200) NULL DEFAULT NULL," +
                    "`offer_id` INT(30) NULL DEFAULT NULL," +
                    "`offer_name` VARCHAR(255) NULL DEFAULT NULL," +
                    "`code_base` VARCHAR(255) NULL DEFAULT NULL," +
                    "`template` VARCHAR(255) NULL DEFAULT NULL," +
                    "`active` BIT(1) NULL DEFAULT NULL," +
                    "PRIMARY KEY(`id`))" +
                    "COLLATE = 'utf8_general_ci'" +
                    "ENGINE = InnoDB" +
                    "; ");
                //Create orders datatable
                db.executeDB("CREATE TABLE `orders_" + user.registerLogin + "` (" +
                    "`order_id` CHAR(100) NULL DEFAULT NULL," +
                    "`customer_login` CHAR(50) NULL DEFAULT NULL," +
                    "`customer_email` CHAR(50) NULL DEFAULT NULL," +
                    "`quantity` INT(11) NULL DEFAULT NULL," +
                    "`offer_name` CHAR(50) NULL DEFAULT NULL," +
                    "`sent` TINYINT(4) NULL DEFAULT '0')" +
                    "COLLATE = 'utf8_general_ci'" +
                    "ENGINE = InnoDB;");
                MessageBox.Show("Registered!", "Success");
                this.Visible = false;
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
