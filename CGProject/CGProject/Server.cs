using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CGProject
{
    public class Server
    {
        private  MySqlConnection myConn;
        private string user;
        private string pass;
        public Server(string user, string pass)
        {
            this.user = user;
            this.pass = pass;

        }
        public MySqlDataReader MakeConnection(string query)
        {
                //This line will be used a lot 
                
                string myConnection = "datasource=70.179.174.145;port=3306;username=Sven;password=jkim";
                myConn = new MySqlConnection(myConnection);
                MySqlCommand cb = new MySqlCommand(query,myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = cb.ExecuteReader();
                return myReader;
                
        }
        public void CloseConnection()
        {
            myConn.Close();
        }
    }

}
