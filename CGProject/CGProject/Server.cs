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
        
        private MySqlConnection myConn;
        private MySqlCommand cmd;

                
  	public MySqlDataReader MakeConnection(string query)
        {
            string myConnection = "datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass;
            //string myConnection = "datasource=localhost;port=3306;username=" + user + ";password=" + pass;
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

        /*************************************************************************
         * Insert with prepared statement. 
         * The tableName represents the table which you would like to insert into
         * valNames gives the names of the table columns in List<string>
         * valValues gives the values of the correspoding valName
         * So if you had two list TEST1 and TEST2
         * TEST1[0] <=> TEST2[0] are connected
         */
        public void MakeConnectionInsertParse(string tableName, List<string> valNames, List<string> valValues)
        {
            try
            {
                string myConnection = "datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass;

                //builds the names of the tables to string;
                string atName = "(" + valNames[0].ToString() + "";
                string valName = "(@j0";
                List<string> listAtNames = new List<string>();
                listAtNames.Add("@j0");

                for (int i = 1; i < valNames.Count; i++)
                {
                    atName += ", " + valNames[i];
                }
                atName += ")";

                //builds the values string for prepared statement
                for (int i = 1; i < valValues.Count; i++)
                {
                    valName += ", @j" + i + "";
                    listAtNames.Add("@j" + i);
                }
                valName += ")";

                string query = "Insert into ccdb." + tableName + " " + atName + " VALUES " + valName + " ;";

                //sets the command text
                //string myConnection = "datasource=localhost;port=3306;username=" + user + ";password=" + pass;

                myConn = new MySql.Data.MySqlClient.MySqlConnection(myConnection);
                cmd = new MySqlCommand(null, myConn);
                cmd.CommandText = query;
                myConn.Open();
                MySqlParameter param;

                //inserts values into @ prepared statements.
                for (int i = 0; i < listAtNames.Count; i++)
                {
                    string temp = listAtNames[i];
                    param = new MySqlParameter(temp, MySqlDbType.VarChar, 1000);
                    param.Value = valValues[i].ToString();
                    cmd.Parameters.Add(param);
                }
                /*
                for (int i = 0; i < listAtNames.Count; i++)
                {
                    cmd.Parameters[listAtNames[i]].Value = valValues[i].ToString();
                }
                 */
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }

            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public void MakeImageConnectionInsert(string query, byte[] image)
        {
            using (myConn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass))
            //using (myConn = new MySqlConnection("datasource=localhost;port=3306;username=" + user + ";password=" + pass));
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
            using (myConn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass)); 
            //using (myConn = new MySqlConnection("datasource=localhost;port=3306;username=" + user + ";password=" + pass));
            string myConnection = "localhost;port=3306;username=" + user + ";password=" + pass;
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
