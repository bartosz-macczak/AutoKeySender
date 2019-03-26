using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace AutoKeySenderApp
{
    class DataBaseClass
    {
        private string globalConnDetails = "datasource=localhost;database=autokeysender;port=3306;username=root;password=";
        
        //MySql commands with return data
        public DataTable selectFromDB(string sql)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(globalConnDetails);
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
                connection.Open();
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
            catch 
            {
                MessageBox.Show("Connection error.", "Error!");
                return null;
            }

        }



        //MySql commands without return data
        public void executeDB(string sql)
        {
            MySqlConnection connection = new MySqlConnection(globalConnDetails);
            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Data Inserted");
                }
                else
                {
                    //MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
 
        //Convert DataTable with 1 record to string
        public string singleDsToString(DataTable ds)
        {
            foreach (DataRow row in ds.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    return item.ToString();
                }
                return null;
            }
            return null;
        }

        //Creating a new table for codes
        public void createCodeBase(string login, string dbName)
        {
            string fullTablename = login + "_" + dbName;
            string sql= "SHOW TABLES LIKE '" + fullTablename +"'";

            if (selectFromDB(sql).Rows.Count==1)
            {
                MessageBox.Show("Baza o tej nazwie już istnieje!");
            }
            else
            {
                    sql = "CREATE TABLE IF NOT EXISTS `" + fullTablename + "` " +
                                "(`id` int(10) NOT NULL auto_increment," +
                                "`code` varchar(255)," +
                                "`add_date` datetime," +
                                "PRIMARY KEY( `id` ));";
                            executeDB(sql);
                MessageBox.Show("Baza została utworzona");
            }

        }

        //Deleting table with codes
        public void deleteCodeBase(string login, string dbName)
        {
            string sql = "DROP TABLE" + login + "_" + dbName;
            executeDB(sql);
        }

        //Delete prefix from table name
        public string deletePrefix(string DBname, string prefix)
        {
            DBname = DBname.Substring(prefix.Length + 1);
            return DBname;
        }
    }
}
