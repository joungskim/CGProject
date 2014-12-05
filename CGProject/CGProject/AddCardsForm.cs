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
                    file.ReadLine();
                    while(file.ReadLine()!= null)
                    {
                        line = file.ReadLine();
                        string[] values = line.Split(',');
                    
                        read = s.MakeConnection("INSERT INTO ccdb.card " +
                            "(name, cost, rarity, description, type, id_image, id_game) " +
                            "VALUES " +
                            "('" + values[0].ToString() + "'" + ", '" + Convert.ToInt16(values[1]) + "'" + ", '" + values[2].ToString() + "'" + ", '" + values[3].ToString() + "'" + ", '" + values[4].ToString() + "'" + ", '" + 0 +"', '" + gameId + "') ;");
                    }
                }
                catch(IOException)
                {

                }
            }
        }
    }
}
