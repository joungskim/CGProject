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
        private bool update = false;
        private string id_game;

        public AddGame()
        {
            InitializeComponent();
            companyTextBox.Clear();
            nameTextBox.Clear();
        }

        public void SetField(string name, string comp)
        {
            nameTextBox.Text = name;
            companyTextBox.Text = comp;
        }

        public string Id_game
        { set { id_game = value; } }

        public bool Update
        {
            set
            {
                update = value;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!companyTextBox.Text.ToString().Equals("") && !nameTextBox.Text.ToString().Equals(""))
            {
                string insertUpdate;
                Server s = new Server();
                try
                {
                    if (update)
                    {
                        insertUpdate = "UPDATE ccdb.game SET made_by = '" + companyTextBox.Text.ToString() + "'" + ", name= '" + nameTextBox.Text.ToString() + "' where id_game = '" + "" + "';";
                    }
                    else
                    {
                        insertUpdate = "INSERT INTO ccdb.game " +
                                                "(made_by, name) " +
                                                "VALUES " +
                                                "('" + companyTextBox.Text.ToString() + "'" + ", '" + nameTextBox.Text.ToString() + "') ;";
                    }
                    read = s.MakeConnection(insertUpdate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }
            update = false;
            id_game = "";
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            update = false;
            id_game = "";
            this.Hide();
        }
    }
}
