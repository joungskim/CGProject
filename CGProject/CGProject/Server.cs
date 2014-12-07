using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;

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



        public void MakeImageConnectionInsert(string query, byte[] image)
        {
            using (myConn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass))
            using (var cmd = myConn.CreateCommand())
            {
                myConn.Open();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("?Image", image);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }




        //THIS WORKS PERFECT NO TOUCHY
        public byte[] MakeImageConnectionExtract(string querry)
        {
            using (myConn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass))
            using (var cmd = myConn.CreateCommand())
            {
                myConn.Open();
                cmd.CommandText = querry;
                MySqlCommand command = new MySqlCommand(querry, myConn);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null; //Keeps returning Null? Sql Command Seems fine
                    }
                    reader.Read();
                    byte[] bits = (byte[])reader[1];
                    return bits;
                }
            }
        }
    }



}
