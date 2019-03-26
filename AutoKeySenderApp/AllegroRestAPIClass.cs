using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace AutoKeySenderApp
{
    class AllegroRestAPIClass
    {
        public bool connected = false;
        DataBaseClass DB = new DataBaseClass();
        string login = "";
        string clientID = "";
        string clientSecret = "";

        public AllegroRestAPIClass(string clientID,string clientSecret, string login)
        {
            this.clientID = clientID;
            this.clientSecret = clientSecret;
            this.login = login;
        }
         
        //Authorize device/app
        public void auth()
        {
            //API authorization
            string basic = Base64Encode(clientID + ":" + clientSecret);

            var client = new RestClient("https://allegro.pl.allegrosandbox.pl");
            var request = new RestRequest
            {
                Method = Method.POST,
                Resource = "/auth/oauth/device"
            };
            request.AddHeader("Authorization","Basic "+basic);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("client_id", clientID);

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(content);

            //If pass is wrong
            if(loginResponse.error_description=="Bad credentials")
            {
                MessageBox.Show("Błędne dane.");
                return;
            }

            GoToSite(loginResponse.verification_uri_complete);

            //Timer to finish authorization after response
            Timer timer = new Timer();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick1);
            timer.Interval = 6000;
            timer.Start();

            void timer_Tick1(object sender, EventArgs e)
            {
                if(timer_Tick(loginResponse.device_code, basic)==true)
                {
                    timer.Stop();
                }
                else if (timer_Tick(loginResponse.device_code, basic) == null || timer_Tick(loginResponse.device_code, basic) == false)
                {
                    timer.Stop();
                    MessageBox.Show("Wystąpił błąd, spróbuj ponownie.");
                }
            }

        }

        //Timer method
        private bool? timer_Tick(string deviceCode, string basic)
        {
            //Access token
            var clientAccess = new RestClient("https://allegro.pl.allegrosandbox.pl");
            var requestAccess = new RestRequest
            {
                Method = Method.POST,
                Resource = "auth/oauth/token?grant_type=urn%3Aietf%3Aparams%3Aoauth%3Agrant-type%3Adevice_code&device_code=" + deviceCode
            };
            requestAccess.AddHeader("Authorization", "Basic " + basic);

            IRestResponse response = clientAccess.Execute(requestAccess);
            var content = response.Content;

            AccessResponse accessResponse = JsonConvert.DeserializeObject<AccessResponse>(content);
            DB.executeDB("INSERT INTO temporary_data_" + login + " (name, value) VALUES ('access_token', '" + accessResponse.access_token + "')");

            //Check if connected
            if (accessResponse.token_type == "bearer")
            {
                MessageBox.Show("Autoryzowano pomyślnie.");
                connected = true;
                return true;
            }
            else if (accessResponse.error == "authorization_pending" || 
                    accessResponse.error == "slow_down" || 
                    accessResponse.error == "access_denied")
            {
                return null;
            }        
            else
                return false;
        }

        //Get all offers list
        public string getOffers()
        {
            string token = DB.singleDsToString(DB.selectFromDB("SELECT value FROM temporary_data_" + login + " WHERE name = 'access_token'"));
            var client = new RestClient("https://api.allegro.pl.allegrosandbox.pl");
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "/sale/offers"
            };
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Accept", "application/vnd.allegro.beta.v1+json");
            request.AddHeader("Content-Type", "application/vnd.allegro.beta.v1+json");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }

        //Get all orders list
        public string getOrders()
        {
            string token = DB.singleDsToString(DB.selectFromDB("SELECT value FROM temporary_data_" + login + " WHERE name = 'access_token'"));
            var client = new RestClient("https://api.allegro.pl.allegrosandbox.pl");
            var request = new RestRequest
            {
                Method = Method.GET,
                Resource = "/order/checkout-forms?status=READY_FOR_PROCESSING"
            };
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Accept", "application/vnd.allegro.beta.v1+json");
            //request.AddHeader("Content-Type", "application/vnd.allegro.beta.v1+json");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            return content;
        }

        //Encode pass to authorize
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        //Open link in browser
        public static void GoToSite(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }


}
