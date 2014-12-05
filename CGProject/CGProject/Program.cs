using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CGProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlDataReader myReader;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Server a = new Server("a", "b");
            try
            {
                myReader = a.MakeConnection("select * from sakila.actor ;");
                while(myReader.Read())
                {
                    string sName = myReader.GetString("first_name");
                    MessageBox.Show(sName);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            a.CloseConnection();

            
             
        }
    }
}
