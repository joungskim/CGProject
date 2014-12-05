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
        public static string user;
        public static string pass;
        
        private  MySqlConnection myConn;
        

                
  	public MySqlDataReader MakeConnection(string query)
        {
                string myConnection = "datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass;
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
