using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Data;
using System.Net.Mail;

namespace AutoKeySenderApp
{
    class ManageOrdersClass
    {
        RootobjectOrders orders = new RootobjectOrders();
        DataBaseClass DB = new DataBaseClass();
        string login;

        public ManageOrdersClass(string login)
        {
            this.login = login;
        }

        //Convert JSON to object and save new orders
        public void ordersToDB(string response)
        {
            RootobjectOrders orders = JsonConvert.DeserializeObject<RootobjectOrders>(response);
            for(int i = orders.totalCount; i > 0; i--)
            {
                string exist = DB.singleDsToString(DB.selectFromDB("SELECT order_id FROM orders_" + login + " WHERE order_id = '" + orders.checkoutForms[i-1].id + "'"));
                if(exist == null)
                {
                    saveOrdersInDB(orders.checkoutForms[i-1].id, orders.checkoutForms[i - 1].buyer.login, orders.checkoutForms[i - 1].buyer.email, orders.checkoutForms[i - 1].lineItems[0].quantity, orders.checkoutForms[i - 1].lineItems[0].offer.name);
                }
            }
        }

        //Save orders from converted response to dataBase
        public void saveOrdersInDB (string order_id, string customer_login, string customer_email, int quantity, string offer_name)
        {
            DB.executeDB("INSERT INTO orders_" + login + "(order_id, customer_login, customer_email, quantity, offer_name) " +
                "VALUES ('"+order_id+"', '"+customer_login+"', '"+customer_email+"', '"+quantity.ToString()+"', '"+offer_name+"')");
        }

        //Look for new orders and send
        public void sendNewOrdersFromList()
        {
            DataTable newOrders = DB.selectFromDB("SELECT order_id, customer_email, quantity, offer_name FROM orders_" + login + " WHERE sent = '0'");
            
            for (int i = newOrders.Rows.Count; i > 0; i--)
            {
                string customer_email = newOrders.Rows[i - 1].ItemArray[1].ToString();
                string offer_name = newOrders.Rows[i - 1].ItemArray[3].ToString();
                string order_id = newOrders.Rows[i - 1].ItemArray[0].ToString();
                int quantity = Convert.ToInt32(newOrders.Rows[i - 1].ItemArray[2].ToString());
                for(int x = quantity; x>0; x--)
                {
                    sendCode(customer_email, createMessage(offer_name));
                }
                DB.executeDB("UPDATE orders_" + login + " SET sent = '1' WHERE order_id = '" + order_id + "'");            }
        }

        //Send email with code to customer
        public void sendCode (string email, string message)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("...@gmail.com", "pass");

            MailMessage mm = new MailMessage("...@gmail.com", email,"Twoj zakupiony kod", message);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        //Create message to send
        public string createMessage(string offerName)
        {
            DataTable offer = DB.selectFromDB("SELECT code_base, template FROM offers_" + login + " WHERE offer_name = '" + offerName + "'");
            string code_base = offer.Rows[0].ItemArray[0].ToString();
            string template = offer.Rows[0].ItemArray[1].ToString();

            string templateText = DB.singleDsToString(DB.selectFromDB("SELECT text FROM templates_" + login + " WHERE name = '" + template + "'"));
            string code = getCode(code_base);
            string messageToSend = templateText.Replace("[CODE]",code);
            return messageToSend;
        }

        //Get code from base and delete it from base
        private string getCode(string baseName)
        {
            DataTable codeDT = DB.selectFromDB("SELECT id, code FROM " + login + "_" + baseName + " LIMIT 1");
            string code = codeDT.Rows[0].ItemArray[1].ToString();
            string id = codeDT.Rows[0].ItemArray[0].ToString();
            DB.executeDB("DELETE FROM " + login + "_" + baseName + " WHERE id = '" + id + "'");
            return code;
        }
    }
}
