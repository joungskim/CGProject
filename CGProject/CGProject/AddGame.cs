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

    public partial class AddGame : Form
    {

        private MySqlDataReader read;

        public AddGame()
        {
            InitializeComponent();
            companyTextBox.Clear();
            nameTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(!companyTextBox.Text.ToString().Equals("") && !nameTextBox.Text.ToString().Equals(""))
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("INSERT INTO ccdb.game " +
                                                "(made_by, name) " +
                                                "VALUES " +
                                                "('" + companyTextBox.Text.ToString() + "'" + ", '" + nameTextBox.Text.ToString() + "') ;");
                    read = s.MakeConnection("Select * from sakila.actor ;");
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
