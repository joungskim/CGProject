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
    public partial class MainForm : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private MySqlDataReader read;

        public MainForm()
        {
            InitializeComponent();
            populateGameList("");
            cardListBox.Items.Add("Please select game...");
        }

        /**************************************************************************/
        /* MainForm
         * Allows for controlling the movements of the MainForm
         */
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        /**************************************************************************/
        /* Games Listbox
         * This contains anything that deals with game 
         */
        private void gameListBox_Click(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            try
            {
                string selected = gameListBox.SelectedItem.ToString();
                populateCardList(searchGameTextBox.Text.ToString(), selected);
            }
            catch (Exception ex)
            {

            }
        }

        private void addGamesButton_Click(object sender, EventArgs e)
        {
            AddGame addForm = new AddGame();
            addForm.ShowDialog();
            gameListBox.Items.Clear();
            populateGameList(searchGameTextBox.Text.ToString());
        }

        private void populateGameList(string search)
        {
            if (!search.Equals("Search Games..."))
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("Select * from ccdb.game where ccdb.game.name like '%" + search + "%' ;");
                    while (read.Read())
                    {
                        gameListBox.Items.Add(read.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }

            else
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("Select * from ccdb.game ;");
                    while (read.Read())
                    {
                        gameListBox.Items.Add(read.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }
        }

        /**************************************************************************/
        /* Cards Listbox
         * This contains anything that deals with card
         */
        private void populateCardList(string search, string gameName)
        {
            if (!search.Equals("Search Cards..."))
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("Select * from ccdb.card, ccdb.game where ccdb.card.name like '%" + search + "%' and ccdb.game.name like '%" + gameName + "%' "
                        + "and ccdb.card.id_game = ccdb.game.id_game "
                        + ";");
                    while (read.Read())
                    {
                        cardListBox.Items.Add(read.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }

            else
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("Select * from ccdb.card where ccdb.card.name like '%" + gameName + "%' ;");
                    while (read.Read())
                    {
                        cardListBox.Items.Add(read.GetString("name"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }
        } //Needs Fixing

        private void addCardButton_Click(object sender, EventArgs e)
        {
            int gameId;

            Server s = new Server();
            try
            {
                read = s.MakeConnection("Select * from ccdb.game where ccdb.game.name like '%" + gameListBox.SelectedItem.ToString() + "' ;");
                read.Read();
                gameId = read.GetInt16("id_game");
                MessageBox.Show(gameId.ToString());
                AddCardsForm addForm = new AddCardsForm(gameId);
                addForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            s.CloseConnection();
        }

        /**************************************************************************/
        /* SEARCH BOXES
         * All the textbox event inserts for the MainForm
         */
        private void searchGameTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListBox.Items.Clear();
            populateGameList(searchGameTextBox.Text.ToString());
        }

        private void searchGameTextBox_Click(object sender, EventArgs e)
        {
            searchGameTextBox.Text = "";
        }

        private void searchGameTextBox_Leave(object sender, EventArgs e)
        {
            if (searchGameTextBox.Text.Equals(""))
            {
                searchGameTextBox.Text = "Search Games...";
            }
        }

        private void searchCardTextBox_Click(object sender, EventArgs e)
        {
            searchCardTextBox.Text = "";
        }

        private void searchCardTextBox_Leave(object sender, EventArgs e)
        {
            if (searchCardTextBox.Text.Equals(""))
            {
                searchCardTextBox.Text = "Search Cards...";
            }
        }
  

        /**************************************************************************/
    }
}
