using System;
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
    public partial class addPlayer : Form
    {
        private int pID;
        private MySqlDataReader read;
        public addPlayer()
        {
            InitializeComponent();
        }
        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if(!PlayerNameTextBox.Text.ToString().Equals("") && !PlayerNameTextBox.Text.ToString().Equals(""))
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("INSERT INTO ccdb.player " +
                                                "(player_name) " +
                                                "VALUES " +
                                                "('" + PlayerNameTextBox.Text.ToString()+"') ;");
                    //read = s.MakeConnection("Select MAX from ccdb.player ;");
                    //read.Read();
                    //pID = read.GetInt32("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }

            this.Hide();
        }
    }
}
