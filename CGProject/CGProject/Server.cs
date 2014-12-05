using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CGProject
{
    public class Server
    {
        public static string user;
        public static string pass;

        public void MakeConnection()
        {
            try
            {
                string myConnection = "datasoure=localhost;port=3306;username=root;password=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand(" select * database.edata ;", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void CloseConnection()
        {
            
        }
    }

}
