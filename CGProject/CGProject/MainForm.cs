using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace CGProject
{
    public partial class MainForm : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private string _querry_string;
        private string _current_card_image_path;
        private string _current_game_id;
        private string _current_game_name;
        private string _card_path;
        private string _game_path;
        private string _player_path;
        private string _player_id;
        private string _player_name;

        private MySqlDataReader read;

        public MainForm()
        {
            InitializeComponent();
            populateGameList("");
            populatePlayListForGame();
            populatePlayersListBox();
            if (!(gameListBox.Items.Count == 0)) gameListBox.SetSelected(0, true);
            if (!(playerListBox.Items.Count == 0)) playerListBox.SetSelected(0, true);
            if(!allGameRadio.Checked) allGameRadio.PerformClick();
            importCardImageButton.Enabled = false;
            if (!(cardListBox.Items.Count == 0)) cardListBox.SetSelected(0, true);
            saveImage.Enabled = false;
            saveManImageButton.Enabled = false;
            playerSaveButton.Enabled = false;
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
            addCardButton.Enabled = true;

            if (!(gameListBox.SelectedIndex < 0))
            {
                cardListBox.Items.Clear();
                try
                {
                    _current_game_name = gameListBox.SelectedItem.ToString();
                    _current_game_id = _current_game_name.Substring(0, _current_game_name.IndexOf(":"));
                    populateCardList(searchCardTextBox.Text.ToString(), _current_game_name);
                    updateCardCount(_current_game_id);
                    if (!(cardListBox.Items.Count == 0)) cardListBox.SetSelected(0, true);
                    displaySelectedGameImage();
                    populatePlayListForGame();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private string importGameImageFunction()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                saveManImageButton.Enabled = true;
                string picPath = dlg.FileName.ToString();
                gameImage.ImageLocation = picPath;
                gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                return picPath;
            }

            return "";
        }

        private void importManImageButton_Click(object sender, EventArgs e)
        {
            _game_path = importGameImageFunction();
        }

        private void saveManImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_game_path.Equals("") && !(gameImage.Image == null))
                {
                    int imageId;
                    Server s = new Server();
                    string insert;
                    using (var ms = new MemoryStream())
                    {
                        gameImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        insert = "INSERT INTO ccdb.images (image) VALUES (?Image)";
                        s.MakeImageConnectionInsert(insert, ms.ToArray());
                    }

                    insert = " Select Max(ccdb.images.id_image) as id_image From ccdb.images ;";
                    read = s.MakeConnection(insert);
                    read.Read();
                    imageId = read.GetInt32("id_image");
                    s.CloseConnection();

                    insert = "UPDATE ccdb.game SET id_image = " + imageId + " WHERE ccdb.game.id_game = '" + _current_game_id + "' ; ";
                    read = s.MakeConnection(insert);
                    read.Read();
                    s.CloseConnection();

                    displaySelectedGameImage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            saveManImageButton.Enabled = false;
        }
       
        private void displaySelectedGameImage()
        {
            try
            {
                Server s = new Server();
                byte[] image = s.MakeImageConnectionExtract("select * from ccdb.images, ccdb.game where ccdb.game.id_game = '" + _current_game_id + "' and ccdb.game.id_image = ccdb.images.id_image ;");
                if (image == null)
                {
                    gameImage.Image = null;
                    return;
                }

                MemoryStream stream = new MemoryStream(image);
                gameImage.Image = System.Drawing.Bitmap.FromStream(stream);
                gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /**************************************************************************/
        /* Cards
         * This contains anything that deals with card
         */

        //populates the card list when called.
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

        //opens the addcard dialogue and refreshes the list of cards.
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

        //deletes the current selected card if a card is selected.
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

        //selects when the index changes this changes the fields for card information.
        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //I think this removes all the memory used for it I dont remember
            if(cardImage.Image !=null)
            {
                cardImage.Image.Dispose();
            }
            cardImage.Image = null;
            try
            {
                importCardImageButton.Enabled = true;
                populateInformationFields(cardListBox.SelectedItem.ToString());
                displaySelectedCardImage();
            }

            catch (Exception ex)
            {

            }
        }

        //Opens connection to the database and stores the id_image to the selected card.
        private void importCardImageButton_Click(object sender, EventArgs e)
        {
            _card_path = importCardImageFunction();
            
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_card_path.Equals("") && !(cardImage.Image == null))
                {
                    int imageId;
                    Server s = new Server();
                    string insert;
                    using (var ms = new MemoryStream())
                    {
                        cardImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        insert = "INSERT INTO ccdb.images (image) VALUES (?Image)";
                        s.MakeImageConnectionInsert(insert, ms.ToArray());
                    }

                    insert = " Select Max(ccdb.images.id_image) as id_image From ccdb.images ;";
                    read = s.MakeConnection(insert);
                    read.Read();
                    imageId = read.GetInt32("id_image");
                    s.CloseConnection();

                    insert = "UPDATE ccdb.card SET id_image = " + imageId + " WHERE ccdb.card.name = '" + cardListBox.SelectedItem.ToString() + "' and ccdb.card.id_game = '" + _current_game_id + "' ; ";
                    read = s.MakeConnection(insert);
                    read.Read();
                    s.CloseConnection();

                    displaySelectedCardImage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            saveImage.Enabled = false;
        }

        //gets the card path and sets the card image picture to the selected image
        private string importCardImageFunction()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                saveImage.Enabled = true;
                string picPath = dlg.FileName.ToString();
                cardImage.ImageLocation = picPath;
                cardImage.SizeMode = PictureBoxSizeMode.StretchImage;
                return picPath;
            }

            return "";
        }

        private void displaySelectedCardImage()
        {
            try
            {
                Server s = new Server();
                byte[] image = s.MakeImageConnectionExtract("select * from ccdb.images, ccdb.card where ccdb.card.name = '" + cardListBox.SelectedItem.ToString() + "' and ccdb.card.id_image = ccdb.images.id_image ;");
                if (image == null)
                {
                    cardImage.Image = null;
                    return;
                }
                
                MemoryStream stream = new MemoryStream(image);
                cardImage.Image = System.Drawing.Bitmap.FromStream(stream); 
                //Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //populates the Information text box fields for the Card
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
        /* All Events Aesthetics
         * All the event inserts for the MainForm
         */

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void currentGameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(currentGameRadio.Checked && allGameRadio.Checked)
            {
                allGameRadio.PerformClick();
            }
        }

        private void allGameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (allGameRadio.Checked && currentGameRadio.Checked)
            {
                currentGameRadio.PerformClick();
            }
        }

        private void cardImage_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void cardImage_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        
        private void cardImage_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Server s = new Server();
                byte[] image = s.MakeImageConnectionExtract("select * from ccdb.images, ccdb.card where ccdb.card.name = '" + cardListBox.SelectedItem.ToString() + "' and ccdb.card.id_image = ccdb.images.id_image ;");
                if (image == null)
                {
                    return;
                }

                EnloargeImageForm enlargeImage = new EnloargeImageForm(image);
                enlargeImage.ShowDialog();

                s.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        //adds the player
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            addPlayer addPlayerForm = new addPlayer();
            addPlayerForm.ShowDialog();
            playerListBox.Items.Clear();
            populatePlayersListBox();
        }

        private void playerListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //cardListBox.Items.Clear();
            try
            {
                string selected = playerListBox.SelectedItem.ToString();
                string[] selectedID = selected.Split(':');
                _player_id = selectedID[0];
                _player_name = selectedID[1];
                populatePlayerInformation(selectedID[0].ToString());
                displaySelectedPlayerImage();
            }
            catch (Exception ex)
            {

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
        }

        private void playerImportButton_Click(object sender, EventArgs e)
        {
            _player_path = playerImportFunction();
        }

        private string playerImportFunction()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                playerSaveButton.Enabled = true;
                string picPath = dlg.FileName.ToString();
                playerPictureBox.ImageLocation = picPath;
                playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                return picPath;
            }

            return "";
        }

        private void playerSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_player_path.Equals("") && !(playerPictureBox.Image == null))
                {
                    int imageId;
                    Server s = new Server();
                    string insert;
                    using (var ms = new MemoryStream())
                    {
                        playerPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        insert = "INSERT INTO ccdb.images (image) VALUES (?Image)";
                        s.MakeImageConnectionInsert(insert, ms.ToArray());
                    }

                    insert = " Select Max(ccdb.images.id_image) as id_image From ccdb.images ;";
                    read = s.MakeConnection(insert);
                    read.Read();
                    imageId = read.GetInt32("id_image");
                    s.CloseConnection();

                    insert = "UPDATE ccdb.player SET id_image = " + imageId + " WHERE ccdb.player.id_player = '" + _player_id + "' ; ";
                    read = s.MakeConnection(insert);
                    read.Read();
                    s.CloseConnection();

                    displaySelectedPlayerImage();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            playerSaveButton.Enabled = false;
        }

        private void displaySelectedPlayerImage()
        {
            try
            {
                Server s = new Server();
                byte[] image = s.MakeImageConnectionExtract("select * from ccdb.images, ccdb.player where ccdb.player.id_player = '" + _player_id + "' and ccdb.player.id_image = ccdb.images.id_image ;");
                if (image == null)
                {
                    playerPictureBox.Image = null;
                    return;
                }

                MemoryStream stream = new MemoryStream(image);
                playerPictureBox.Image = System.Drawing.Bitmap.FromStream(stream);
                playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        /***************************************************************************
         * Give the List of playthorughs for the selected Game as an ordered set of 1 to however many games had been 
         *  played followed by the players who played in the game.
         */

        private void populatePlayListForGame()
        {
            if (!gameListBox.SelectedIndex.Equals(-1))
            {
                playthroughHistoryList.Items.Clear();
                Server s = new Server();
                try
                {
                    _querry_string = "SELECT Distinct play.playthrough as p, player.player_name as n FROM ccdb.history as play, ccdb.player as player, (select ccdb.card.id_card as id, ccdb.card.name as cname " +
                        "from ccdb.card, ccdb.game where ccdb.card.id_game = ccdb.game.id_game and ccdb.game.id_game = " + _current_game_id + ") as temp where play.id_card = temp.id and player.id_player = play.id_player " +
                        "ORDER BY playthrough;";
                    read = s.MakeConnection(_querry_string);
                    int playNum = 0;
                    int count = 0;
                    string temp = "";
                    while (read.Read())
                    {
                        int NewplayNum = read.GetInt32("p");
                        if (NewplayNum == playNum)
                        {
                            temp += read.GetString("n") + " ";
                        }
                        else
                        {
                            if (playNum > 0) playthroughHistoryList.Items.Add(temp);
                            temp = ++count + ": " + read.GetString("n") + " ";
                            playNum = NewplayNum;
                        }
                    }
                    playthroughHistoryList.Items.Add(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                s.CloseConnection();
            }
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            if (!(playerListBox.SelectedIndex == -1))
            {
                try
                {
                    int index;
                    if (playerListBox.SelectedIndex > 0) index = playerListBox.SelectedIndex - 1;
                    else index = 0;

                    string deleteValue = "SET SQL_SAFE_UPDATES = 0; Delete from ccdb.player where ccdb.player.id_player = '" + _player_id + "' ;";
                    read = s.MakeConnection(deleteValue);
                    playerListBox.Items.Clear();
                    populatePlayersListBox();
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

        private void AddPlay_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex.Equals(-1) || gameListBox.SelectedIndex.Equals(-1) || playerListBox.SelectedIndex.Equals(-1))
                MessageBox.Show("You do not have all the nessisary fields selected");
            else
            {
                _querry_string = "select max(ccdb.play.playthrough) as max from ccdb.play.playthrough;";
                Server s = new Server();
                read = s.MakeConnection(_querry_string);
                read.Read();
                _querry_string = "insert into ccdb.play(ccdb.play.id_player,ccdb.play.playthrough) VALUES( '" + playerListBox.SelectedItem.ToString() + "'," + (read.GetInt32("max") + 1) + ");";
                s.MakeConnection(_querry_string);
                s.CloseConnection();
            }
        }




 





        /**************************************************************************/
    }
}
