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
        private string user;
        private string pass;
        public Server(string user, string pass)
        {
            this.user = user;
            this.pass = pass;

        }
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
                DataSet ds = new DataSet();
                MessageBox.Show(Success!);
                myConn.close();

            }
            catch(Exeception ex)
            {
                MessageBox.Show(ex.message);
            }

        }
        public void CloseConnection()
        {
            
        }
    }

}
