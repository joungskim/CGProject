using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CGProject
{
    public partial class AddCardsForm : Form
    {
        private MySqlDataReader read;
        private int gameId;
        public AddCardsForm(int gameId)
        {
            InitializeComponent();
            this.gameId = gameId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            string line;
            OpenFileDialog x = new OpenFileDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(x.FileName);
                try
                {
                    string line1 = file.ReadLine();
                        while ((line = file.ReadLine()) != null)
                        {
                            if (!AddCard(line1, line.Split(',')))
                            {
                               // MessageBox.Show("There was an error reading the file\nWith columns " + line1 + " and the line read in as " + line);
                                
                            }
                        }
                }
                catch(IOException ex)
                {
                    MessageBox.Show("Invalid Format\n" + ex.Message);
                }
            }

        }
        public bool AddCard(string colNames, string[] colVals)
        {
            try
            {
                if (colNames.Contains("name"))
                    {
                        Server s = new Server();
                        string[] colName = colNames.Split(',');
                            string insert = "INSERT INTO ccdb.card (" + colNames + ",id_game) VALUES  (";
                            for (int i = 0; i < colVals.Count() ;i++ )
                            {
                                if (colName[i] == "cost")
                                {
                                    insert += colVals[i] + ",";
                                }
                                else
                                {
                                    insert += "'" + colVals[i] + "'" + ",";
                                }
                            }
                            insert += "'" + gameId + "') ;";
                            read = s.MakeConnection(insert);
                            s.CloseConnection();
                        }
                    else
                    {
                        MessageBox.Show("File does not include required field name!");
                    }
                return true;
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
