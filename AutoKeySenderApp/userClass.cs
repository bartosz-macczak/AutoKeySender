using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AutoKeySenderApp
{
    class userClass
    {
        //Login variables
        public string Login { get; set; }
        public string Password { get; set; }

        //Register variables
        public string registerLogin;
        public string registerEmail;
        public string registerPassword;
        public string registerRepeatPassword;
        public bool registerAcceptReg;

        //Check register proccess functions
        public bool loginCheck(string login)
        {
            if(login=="")
            {
                MessageBox.Show("Login box is empty!", "Error");
                return false;
            }
            DataBaseClass db = new DataBaseClass();
            string sql = "SELECT login FROM users WHERE login='" + login + "'";
            string z = db.singleDsToString(db.selectFromDB(sql));
            if (z == null)
                return true;
            else
            {
                MessageBox.Show("Account with this nick already exist!", "Error");
                return false;
            }
            
        }

        //Pass correctness
        public bool passCheck(string pass1, string pass2)
        {
            if (pass1 == "" || pass2 == "")
            {
                MessageBox.Show("Password box is empty!", "Error");
                return false;
            }
            if (pass1 == pass2)
            {
                //
                //Future: checking if password meets the conditions.
                //
                return true;
            }
            else
            {
                MessageBox.Show("Passwords are not the same!", "Error");
                return false;
            }
                
        }

        //Email correctness
        public bool emailCheck(string email)//To improve
        {
            if (email == "")
            {
                MessageBox.Show("E-mail box is empty!", "Error");
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Wrong e-mail!", "Error");
                return false;
            }
        }

        //Check if regulations accepted
        public bool regCheck(bool reg)
        {
            if (reg == true)
                return true;
            else
            {
                MessageBox.Show("You have to accept regulations and policy!", "Error");
                return false;
            }
        }

        //Encrypt password to SHA1
        public string passEncryprtSHA1(string pass)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach(byte b in re)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
