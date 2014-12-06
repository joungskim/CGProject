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


            using (var conn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("?Image", image);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public byte[] MakeImageConnectionExtract(string querry)
        {
            using (var conn = new MySqlConnection("datasource=70.179.174.145;port=3306;username=" + user + ";password=" + pass))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = querry;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }
                    DataTable dt = new DataTable();
                    MySqlDataAdapter sda = new MySqlDataAdapter(querry,conn);
                    sda.Fill(dt);
                    byte[] bits = new byte[0];
                    return (byte[])dt.Rows[0][0];
                    /*
                    const int CHUNK_SIZE = 2 * 1024;
                    byte[] buffer = new byte[CHUNK_SIZE];
                    long bytesRead;
                    long fieldOffset = 0;
                    using (var stream = new MemoryStream())
                    {
                        while ((bytesRead = reader.GetBytes(reader.GetOrdinal("Image"), fieldOffset, buffer, 0, buffer.Length)) > 0)
                        {
                            stream.Write(buffer, 0, (int)bytesRead);
                            fieldOffset += bytesRead;
                        }
                        return stream.ToArray();
                    }
                     */
                }
            }
        }
    }



}
