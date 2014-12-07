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
            populatePlayersListBox();
            if (!(gameListBox.Items.Count == 0)) gameListBox.SetSelected(0, true);
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
        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            try
            {
                string selected = gameListBox.SelectedItem.ToString();
                string selectedID = selected.Substring(0, selected.IndexOf(":"));
                populateCardList(searchCardTextBox.Text.ToString(), selectedID);
                updateCardCount(selectedID);
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

        private void updateCardCount(string gameID)
        {
            if (Convert.ToInt32(gameID) > 0)
            {
                Server s = new Server();
                try
                {
                    //SELECT COUNT(*) FROM fooTable;
                    string _querry_string = "Select Count(*) as count from ccdb.card as card where card.id_game = " + gameID + ";";
                    read = s.MakeConnection(_querry_string);
                    read.Read();
                    gameCardCountLabel.Text = "Game Card Count: " + read.GetString("count");
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
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            try
            {
                AddCardsForm addForm = new AddCardsForm(Convert.ToInt32(gameListBox.SelectedItem.ToString().Substring(0, gameListBox.SelectedItem.ToString().IndexOf(":"))));
                addForm.ShowDialog();
                cardListBox.Items.Clear();
                populateCardList(searchCardTextBox.Text.ToString(), gameListBox.SelectedItem.ToString().Substring(0, gameListBox.SelectedItem.ToString().IndexOf(":")));
                if (!(cardListBox.Items.Count == 0)) cardListBox.SetSelected(0, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void deleteCardButton_Click(object sender, EventArgs e)
        {
            cardNameTextBox.Clear();
            rarityTextBox.Clear();
            costTextBox.Clear();
            typeTextBox.Clear();
            descriptionRichTextBox.Clear();


            Server s = new Server();
            if (!(cardListBox.SelectedIndex == -1))
            {
                try
                {
                    int index;
                    if (cardListBox.SelectedIndex > 0) index = cardListBox.SelectedIndex - 1;
                    else index = 0;

                    string deleteValue = "SET SQL_SAFE_UPDATES = 0; Delete from ccdb.card where ccdb.card.id_game = '" + gameListBox.SelectedItem.ToString().Substring(0, gameListBox.SelectedItem.ToString().IndexOf(":")) + "' and ccdb.card.name = '" + cardListBox.SelectedItem.ToString() + "' ;";
                    read = s.MakeConnection(deleteValue);
                    cardListBox.Items.Clear();
                    populateCardList(searchCardTextBox.Text.ToString(), gameListBox.SelectedItem.ToString().Substring(0, gameListBox.SelectedItem.ToString().IndexOf(":")));
                    if (!(cardListBox.Items.Count == 0)) cardListBox.SetSelected(index, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }
        }

        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                populateInformationFields(cardListBox.SelectedItem.ToString());
            }

            catch (Exception ex)
            {

            }
        }

        /**************************************************************************/
        /* Card Information and Images
         * This contains anything that deals with Information or images relating to cards/games
         */

        private void populateInformationFields(string cardID)
        {

            Server s = new Server();
            try
            {
                _querry_string = "Select * from ccdb.card as card where card.name = '" + cardID + "' ;"; //Need to change card.name to card.id_card
                read = s.MakeConnection(_querry_string);
                read.Read();

                cardNameTextBox.Text = read.GetString("name");

                var checkNull = read.GetOrdinal("rarity");

                if (!read.IsDBNull(checkNull)) rarityTextBox.Text = read.GetString("rarity");

                else rarityTextBox.Text = "N/A";

                checkNull = read.GetOrdinal("cost");

                if (!read.IsDBNull(checkNull)) costTextBox.Text = read.GetString("cost");

                else costTextBox.Text = "N/A";

                checkNull = read.GetOrdinal("type");

                if (!read.IsDBNull(checkNull)) typeTextBox.Text = read.GetString("type");

                else typeTextBox.Text = "N/A";

                checkNull = read.GetOrdinal("description");

                if (!read.IsDBNull(checkNull)) descriptionRichTextBox.Text = read.GetString("description");

                else descriptionRichTextBox.Text = "No Description Available";

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

        private void searchCardTextBox_TextChanged(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            string selected = gameListBox.SelectedItem.ToString();
            string selectedID = selected.Substring(0, selected.IndexOf(":"));
            populateCardList(searchCardTextBox.Text.ToString(), selectedID);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }


        /**************************************************************************/
        /* 
         * The Text box for players
         * Anything to deal with players in THIS section
         */
        private void populatePlayersListBox()
        {
            Server s = new Server();
            try
            {
                read = s.MakeConnection("Select * from ccdb.player ;");
                while (read.Read())
                {
                    playerListBox.Items.Add(read.GetInt32("id_player") + ": " + read.GetString("player_name"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            s.CloseConnection();
        }




        private void addPlayerButton_Click_1(object sender, EventArgs e)
        {
            addPlayer addPlayerForm = new addPlayer();
            addPlayerForm.ShowDialog();
            playerListBox.Items.Clear();
            populatePlayersListBox();
        }

        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cardListBox.Items.Clear();
            try
            {
                string selected = playerListBox.SelectedItem.ToString();
                string[] selectedID = selected.Split(':');
                populatePlayerInformation(selectedID[0].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populatePlayerInformation(string id_player)
        {
            Server s = new Server();
            try
            {
                _querry_string = "Select * from ccdb.player as player where player.id_player = '" + id_player + "' ;"; //Need to change card.name to card.id_card
                read = s.MakeConnection(_querry_string);
                read.Read();
                player1NameTextBox.Text = read.GetString("player_name");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            s.CloseConnection();
        }


        /**************************************************************************/
    }
}
