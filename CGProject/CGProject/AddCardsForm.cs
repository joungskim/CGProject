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
                    line = file.ReadLine();
                    string[] header = line.Split(',');
                    if (header.Contains("name"))
                    {
                        string insertString = "";
                        foreach (string Str in header)
                        {
                            insertString += (Str + ",");
                        }
                        while (file.ReadLine() != null)
                        {
                            line = file.ReadLine();
                            string[] values = line.Split(',');
                            string insert = "INSERT INTO ccdb.card (" + insertString + " id_game) VALUES  (";
                            for (int i = 0; i < values.Count() ;i++ )
                            {
                                if (header[i] == "cost")
                                {
                                    insert += values[i] + ",";
                                }
                                else
                                {
                                    insert += "'" + values[i] + "'" + ",";
                                }
                            }
                            insert += "'" + gameId + "') ;";
                            read = s.MakeConnection(insert);
                            s.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("File does not include required field name!");
                    }
                }
                catch(IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
