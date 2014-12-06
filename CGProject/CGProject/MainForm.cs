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
        private string _querry_string;

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
                string selectedID = selected.Substring(0, selected.IndexOf(":"));
                populateCardList(searchCardTextBox.Text.ToString(), selectedID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (!search.Equals("Search Games...") && !search.Equals(""))
            {
                Server s = new Server();
                try
                {
                    _querry_string = "Select * from ccdb.game where ccdb.game.name like '%" + search + "%' ;";
                    read = s.MakeConnection(_querry_string);
                    while (read.Read())
                    {
                        gameListBox.Items.Add(read.GetInt32("id_game") + ": " + read.GetString("name"));
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
                        gameListBox.Items.Add(read.GetInt32("id_game") + ": " + read.GetString("name"));
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
        private void populateCardList(string search, string gameID)
        {
            if (!search.Equals("Search Cards...") && !search.Equals(""))
            {
                Server s = new Server();
                try
                {
                    _querry_string = "Select * from ccdb.card as card, ccdb.game as game where card.id_game = game.id_game and"
                    + " game.id_game = '" + gameID + "' and card.name like '%" + search + "%' ;";
                    read = s.MakeConnection(_querry_string);
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
                    _querry_string = "Select * from ccdb.card where ccdb.card.id_game = '" + gameID + "' ;";
                    read = s.MakeConnection(_querry_string);
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
            Server s = new Server();
            try
            {

                AddCardsForm addForm = new AddCardsForm(Convert.ToInt32(gameListBox.SelectedItem.ToString().Substring( 0,gameListBox.SelectedItem.ToString().IndexOf(":"))));
                addForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
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

        private void searchCardTextBox_TextChanged(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            string selected = gameListBox.SelectedItem.ToString();
            string selectedID = selected.Substring(0, selected.IndexOf(":"));
            populateCardList(searchCardTextBox.Text.ToString(), selectedID);
        }
  

        /**************************************************************************/
    }
}
