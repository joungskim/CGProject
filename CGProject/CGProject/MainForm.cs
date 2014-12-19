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
using System.Timers;

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
        private int _card_id;
        private string _card_name;
        private string _game_path;
        private string _player_path;
        private string _player_id;
        private int _selected_history;
        private System.Timers.Timer timer = new System.Timers.Timer();
        private int chatBoxIndex;

        private MySqlDataReader read;

        public MainForm()
        {
            InitializeComponent();
            sortCardsBy.Text = "SelectSort";
            sortCardsBy.Items.Add("name");
            sortCardsBy.Items.Add("cost");
            sortCardsBy.Items.Add("type");
            sortCardsBy.Items.Add("rarity");
            LoadMainForm();

        }

        public void LoadMainForm()
        {
            populateGameList("");
            populatePlayListForGame();
            if (!(gameListBox.Items.Count == 0)) gameListBox.SetSelected(0, true);
            if (!(playerListBox.Items.Count == 0)) playerListBox.SetSelected(0, true);
            if (!allGameRadio.Checked) allGameRadio.PerformClick();
            importCardImageButton.Enabled = false;
            if (!(cardListBox.Items.Count == 0)) cardListBox.SetSelected(0, true);
            saveImage.Enabled = false;
            saveManImageButton.Enabled = false;
            playerSaveButton.Enabled = false;
            chatBoxIndex = 0;
            populateChatBox();
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
            if (!(gameListBox.SelectedIndex < 0))
            {
                addCardButton.Enabled = true;
                GameEnd.Enabled = false;
                playthroughHistoryList.Items.Clear();
                player1HistoryListBox.Items.Clear();
                playerListBox.Items.Clear();
                cardListBox.Items.Clear();
                try
                {
                    _current_game_name = gameListBox.SelectedItem.ToString();
                    _current_game_id = _current_game_name.Substring(0, _current_game_name.IndexOf(":"));
                    populateCardList(searchCardTextBox.Text.ToString(), _current_game_id);
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
                    image = s.MakeImageConnectionExtract("Select * from ccdb.images where ccdb.images.id_image = '44'");
                    MemoryStream stream = new MemoryStream(image);
                    gameImage.Image = System.Drawing.Bitmap.FromStream(stream);
                    gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
                }
                else
                {
                    MemoryStream stream = new MemoryStream(image);
                    gameImage.Image = System.Drawing.Bitmap.FromStream(stream);
                    gameImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
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
        private void populateCardList(string search, string gameID, string sortBy = "")
        {
            string sort = "";
            if (sortBy != "" && sortBy != "SelectSort")
            {
                sort = "ORDER BY card." + sortBy;
                if (sortBy != "name") sort += ", name";
            }
            Server s = new Server();
            try
            {
                if (!search.Equals("Search Cards...") && !search.Equals(""))
                {

                    _querry_string = "Select * from ccdb.card as card, ccdb.game as game where card.id_game = game.id_game and"
                    + " game.id_game = '" + gameID + "' and card.name like '%" + search + "%' " + sort + ";";
                    read = s.MakeConnection(_querry_string);
                    while (read.Read())
                    {
                        cardListBox.Items.Add(read.GetString("name"));
                    }
                }
                else
                {
                    _querry_string = "Select * from ccdb.card where ccdb.card.id_game = " + gameID + " " + sort + ";";
                    read = s.MakeConnection(_querry_string);
                    while (read.Read())
                    {
                        cardListBox.Items.Add(read.GetString("name"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            s.CloseConnection();
        }

        //opens the addcard dialogue and refreshes the list of cards.
        private void addCardButton_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            try
            {
                AddCardsForm addForm = new AddCardsForm(Convert.ToInt32(_current_game_id));
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
            //TODO trigger to delete cards with same id_game and name
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
                    populateCardList(searchCardTextBox.Text.ToString(), _current_game_id);
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
            if (cardImage.Image != null)
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

                    insert = "UPDATE ccdb.card SET ccdb.card.id_image = " + imageId + " WHERE ccdb.card.name = '" + cardListBox.SelectedItem.ToString() + "' and ccdb.card.id_game = '" + _current_game_id + "' ; ";
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
                    image = s.MakeImageConnectionExtract("Select * from ccdb.images where ccdb.images.id_image = '44'");
                    MemoryStream stream = new MemoryStream(image);
                    cardImage.Image = System.Drawing.Bitmap.FromStream(stream);
                    return;
                }

                else
                {
                    MemoryStream stream = new MemoryStream(image);
                    cardImage.Image = System.Drawing.Bitmap.FromStream(stream);
                }
                //Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //populates the Information text box fields for the Card
        private void populateInformationFields(string cardName)
        {

            Server s = new Server();
            try
            {
                _querry_string = "Select * from ccdb.card as card, ccdb.game where ccdb.game.id_game = " + _current_game_id + " and card.name = '" + cardName + "' ;";
                read = s.MakeConnection(_querry_string);
                read.Read();

                cardNameTextBox.Text = read.GetString("name");
                _card_id = read.GetInt32("id_card");

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
            populateCardList(searchCardTextBox.Text.ToString(), _current_game_id, sortCardsBy.Text);
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
            if (currentGameRadio.Checked && allGameRadio.Checked)
            {
                allGameRadio.PerformClick();
            }
            if (!playerListBox.SelectedIndex.Equals(-1))
            {
                populatePlayerInformation(_player_id);
            }
        }

        private void allGameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (allGameRadio.Checked && currentGameRadio.Checked)
            {
                currentGameRadio.PerformClick();
            }
            if (!playerListBox.SelectedIndex.Equals(-1))
            {
                populatePlayerInformation(_player_id);
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
            if (!playthroughHistoryList.SelectedIndex.Equals(-1))
            {
                playerListBox.Items.Clear();
                Server s = new Server();
                try
                {
                    _querry_string = "SELECT Distinct play.gameplay_num as p, player.player_name as n, play.id_playthrough as selected " +
                    "FROM ccdb.record as record, (SELECT count(x.id_game) as gameplay_num, y.id_playthrough, y.id_game from ccdb.playgame1 as x, ccdb.playgame1 as y where y.id_game = x.id_game and y.id_game = " +
                    _current_game_id + " and x.id_playthrough <= y.id_playthrough group by y.id_playthrough) as play, ccdb.player as player, ccdb.history as hist " +
                    "WHERE play.id_game = " + _current_game_id + " and play.gameplay_num = " + (playthroughHistoryList.SelectedIndex + 1) + " and play.id_playthrough = hist.playthrough and hist.id_player = player.id_player " +
                    "Order By n;";
                    read = s.MakeConnection(_querry_string);

                    while (read.Read())
                    {
                        playerListBox.Items.Add(read.GetString("n"));
                        _selected_history = read.GetInt32("selected");
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
                GameEnd.Enabled = false;
            }
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
            try
            {
                Server s = new Server();
                if (!(playerListBox.Items[0].ToString() == "Select a player.."))
                {
                    int count = 0;
                    bool insure;
                    _querry_string = "SELECT Distinct player.id_player as id, play.gameplay_num as p, player.player_name as n, play.id_playthrough as selected FROM " +
                        "(SELECT count(x.id_game) as gameplay_num, y.id_playthrough, y.id_game from ccdb.playgame1  as x, ccdb.playgame1 as y where y.id_game = x.id_game and y.id_game = " +
                        _current_game_id + " and x.id_playthrough <= y.id_playthrough group by y.id_playthrough) as play" +
                        ", ccdb.player as player, ccdb.history as hist " +
                        "WHERE  play.gameplay_num = " + (playthroughHistoryList.SelectedIndex + 1) + " and play.id_playthrough = hist.playthrough and hist.id_player = player.id_player " +
                        "Order By n;";
                    read = s.MakeConnection(_querry_string);
                    while ((insure = read.Read()) && count != playerListBox.SelectedIndex)
                    {
                        count++;
                    }
                    if (insure)
                    {
                        _player_id = read.GetInt32("id").ToString();
                        populatePlayerInformation(_player_id);
                        displaySelectedPlayerImage();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured could not load player data!");
                    }
                    _querry_string = "Select * from ccdb.record where ccdb.record.id_playthrough = " + _selected_history;
                    read = s.MakeConnection(_querry_string);
                    if (read.Read())
                    {
                        if (read.IsDBNull(2))
                        {
                            GameEnd.Enabled = true;
                        }
                    }
                }
                else
                {
                    if(playerListBox.SelectedIndex > 0)
                    { 
                    //add select player to the current playthrough and redisplay players
                    _player_id = playerListBox.SelectedItem.ToString().Substring(11,playerListBox.SelectedItem.ToString().IndexOf('-') - 11);
                    _querry_string = "INSERT INTO ccdb.record (id_player,id_playthrough) VALUES (" + _player_id +"," + _selected_history + ")";
                    s.MakeConnection(_querry_string);
                    s.CloseConnection();
                    }
                    int temp = playthroughHistoryList.SelectedIndex;
                    if (playthroughHistoryList.SelectedItem.ToString().Contains('-')) { generateGames.PerformClick(); }
                    else populatePlayListForGame();
                    playthroughHistoryList.SelectedIndex = temp;
                    playerListBox.Items.Clear();
                    populatePlayersByPlayNum();
                }
            }
            catch (Exception ex)
            {
                if(ex.ToString().Contains("duplicate")) MessageBox.Show("Player already in game");
            }

        }

        private void populatePlayerInformation(string id_player)
        {
            Server s = new Server();
            try
            {
                _querry_string = "Select * from ccdb.player as player where player.id_player = '" + id_player + "' ;";
                read = s.MakeConnection(_querry_string);
                read.Read();
                player1NameTextBox.Text = read.GetString("player_name");

                if (allGameRadio.Checked) _querry_string = "SELECT id_player, SUM(win)/count(*) as win_p, (count(*)-SUM(win))/count(*) as loss_p, SUM(win) as win, count(*)-SUM(win) as loss FROM ccdb.record where win IS NOT NULL and id_player = " + _player_id + " group by id_player;";
                else _querry_string = "SELECT id_player, SUM(win)/count(*) as win_p, (count(*)-SUM(win))/count(*) as loss_p, SUM(win) as win, count(*)-SUM(win) as loss FROM ccdb.record, ccdb.playgame1 where win IS NOT NULL and record.id_playthrough = playgame1.id_playthrough and id_player = " + _player_id + " and playgame1.id_game = " + _current_game_id + " group by id_player;";
                read = s.MakeConnection(_querry_string);
                if (read.Read())
                {
                    player1WinPercent.Text = Convert.ToString(read.GetDouble("win_p") * 100);
                    player1LossPercent.Text = Convert.ToString(read.GetDouble("loss_p") * 100);
                    player1LossCount.Text = read.GetInt32("loss").ToString();
                    player1WinCount.Text = read.GetInt32("win").ToString();
                }
                else
                {
                    player1WinPercent.Text = "N/A";
                    player1LossPercent.Text = "N/A";
                    player1LossCount.Text = "0";
                    player1WinCount.Text = "0";
                }

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
                int count = 0;
                playthroughHistoryList.Items.Clear();
                Server s = new Server();
                try
                {
                    _querry_string = "SELECT Distinct play.id_playthrough as p, player.player_name as n FROM ccdb.record as play, ccdb.player as player, ccdb.playgame1 as game " +
                    "where game.id_game = " + _current_game_id + " and game.id_playthrough = play.id_playthrough and play.id_player = player.id_player " +
                    "ORDER BY play.id_playthrough;";
                    read = s.MakeConnection(_querry_string);
                    int playNum = 0;
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
                    if(temp != "") playthroughHistoryList.Items.Add(temp);
                    _querry_string = "SELECT ccdb.playgame1.id_playthrough, ccdb.game.name FROM ccdb.playgame1, ccdb.game where ccdb.playgame1.id_game = " + _current_game_id + " and ccdb.playgame1.id_game = ccdb.game.id_game and ccdb.playgame1.id_playthrough NOT IN (Select ccdb.record.id_playthrough from ccdb.record);";
                    read = s.MakeConnection(_querry_string);
                    while (read.Read())
                    {
                        playthroughHistoryList.Items.Add("Game # " + read.GetInt32("id_playthrough") + ": " + read.GetString("name") + "= No players in game");
                    }
                    s.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
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

                    string deleteValue = "SET SQL_SAFE_UPDATES = 0; Delete from ccdb.record where ccdb.record.id_player = " + _player_id + " and ccdb.record.id_playthrough = " + _selected_history + ";";
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

        private void playthroughHistoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playthroughHistoryList.SelectedIndex == -1) return;
            if (!playthroughHistoryList.SelectedItem.ToString().Contains('-') && !playthroughHistoryList.SelectedItem.ToString().Contains('='))
            {
                populatePlayersListBox();
                populateGameHistory();

            }
            else
            {
                playerListBox.Items.Clear();
                string temp = playthroughHistoryList.SelectedItem.ToString().Substring(7, playthroughHistoryList.SelectedItem.ToString().IndexOf(':') - 7);
                _selected_history = Convert.ToInt32(temp);
                //set current game to the the game selected, deselect the current game, set cards list to the current game card list
                populatePlayersByPlayNum();
                populateGameHistory();
                _querry_string = "Select * from ccdb.playgame1 where ccdb.playgame1.id_playthrough = " + _selected_history + ";";
                try
                {
                    Server s = new Server();
                    read = s.MakeConnection(_querry_string);
                    read.Read();
                    _current_game_id = read.GetString("id_game");
                    s.CloseConnection();
                    if (playthroughHistoryList.SelectedItem.ToString().Contains('-'))
                    {
                        gameListBox.SelectedIndex = -1;
                        cardListBox.Items.Clear();
                        populateCardList(searchCardTextBox.Text.ToString(), _current_game_id);
                        cardListBox.SelectedIndex = 0;
                    }
                }
                catch (Exception Ex) { }
            }
            endGame();
        }

        private void endGame()
        {
            if (playthroughHistoryList.SelectedItem.ToString().Contains("= No players in game"))
            {
                AddPlayerGame.Enabled = true;
                GameEnd.Enabled = false;
                return;
            }
            _querry_string = "Select * from ccdb.record where ccdb.record.id_playthrough = " + _selected_history + ";";
            Server s = new Server();
            read = s.MakeConnection(_querry_string);
            read.Read();
            var checkNull = read.GetOrdinal("win");

            if (!read.IsDBNull(checkNull))
            {
                GameEnd.Enabled = false;
                AddPlayerGame.Enabled = false;
            }
            else
            {
                GameEnd.Enabled = true;
                AddPlayerGame.Enabled = true;
            }
        }

        private void populatePlayersByPlayNum()
        {

            _querry_string = "SELECT player.player_name as pname, rec.id_playthrough as play FROM ccdb.record as rec, ccdb.player as player, ccdb.playgame1 as pg WHERE rec.id_playthrough = " + _selected_history + " and rec.id_playthrough = pg.id_playthrough and rec.id_player = player.id_player Order By play;";
            try
            {
                Server s = new Server();
                read = s.MakeConnection(_querry_string);
                while (read.Read())
                {
                    playerListBox.Items.Add(read.GetString("pname"));
                }
                s.CloseConnection();
            }
            catch (Exception ex)
            { }
        }

        private void populateGameHistory()
        {
            if (!playthroughHistoryList.SelectedIndex.Equals(-1))
            {
                player1HistoryListBox.Items.Clear();
                _querry_string = "Select player.player_name as name, card.name as card, hist.play_num as num from ccdb.card as card, ccdb.player as player, ccdb.history as hist where " +
                    "hist.playthrough = '" + _selected_history + "' and hist.id_card = card.id_card and player.id_player = hist.id_player ORDER BY num;";
                Server s = new Server();
                read = s.MakeConnection(_querry_string);
                while (read.Read())
                {
                    string temp = "Play " + read.GetInt32(/*the play number*/"num") + ": " + "Player: " + read.GetString(/*The Player name*/"name") + " plays the card " + read.GetString(/*then name of the card*/"card");
                    player1HistoryListBox.Items.Add(temp);
                }
                s.CloseConnection();
            }
        }

        private void player1HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            bool insure;
            _querry_string = "select card.name as card from ccdb.card as card, ccdb.player as player, ccdb.history as hist where " +
                    "hist.playthrough = " + _selected_history + " and hist.id_card = card.id_card and player.id_player = hist.id_player ORDER BY play_num;";
            Server s = new Server();
            read = s.MakeConnection(_querry_string);
            while ((insure = read.Read()) && count != player1HistoryListBox.SelectedIndex)
            {
                count++;
            }
            if (insure)
            {
                _card_name = read.GetString("card");
                cardListBox.SelectedIndex = (cardListBox.FindString(_card_name));
            }
        }

        private void GameEnd_Click(object sender, EventArgs e)
        {
            //set the current record of the selected playthrough for the winning player to true(1) and the other players to false(trigger)
            _querry_string = "UPDATE ccdb.record SET win=1 where id_player = " + _player_id + " and id_playthrough = " + _selected_history;
            //TODO trigger set all false for playthrough
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add new playthrough of games
            Server s = new Server();
            _querry_string = "INSERT INTO ccdb.playgame1 (id_game) VALUES (" + _current_game_id + ")";
            s.MakeConnection(_querry_string);
            s.CloseConnection();
        }



        /***************************************************************************
         * Chat Box Updates 
         * Anything that deals with the chat box.
        */

        private void populateChatBox()
        {
            Server s = new Server();
            try
            {
                _querry_string = "Select * from ccdb.chat where id_chat > " + chatBoxIndex + " ;";
                read = s.MakeConnection(_querry_string);
                while (read.Read())
                {
                    this.Invoke((MethodInvoker)(() => chatListBox.Items.Add(read.GetString("chat"))));
                }
                _querry_string = "Select Max(ccdb.chat.id_chat) as chat From ccdb.chat ;";
                read = s.MakeConnection(_querry_string);
                read.Read();
                this.Invoke((MethodInvoker)(() => chatBoxIndex = read.GetInt32("chat")));
                if (chatListBox.Items.Count > 0) this.Invoke((MethodInvoker)(() => chatListBox.SetSelected(chatListBox.Items.Count - 1, true)));
            }
            catch (Exception ex)
            {
            }
            s.CloseConnection();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (!chatRichTextBox.Text.Equals(""))
            {
                Server s = new Server();
                List<string> names = new List<string>();
                names.Add("chat");
                List<string> values = new List<string>();
                values.Add(Server.user + " (" + DateTime.Now.ToShortTimeString() + ")" + " : " + chatRichTextBox.Text);
                s.MakeConnectionInsertParse("chat", names, values);
                populateChatBox();
                chatRichTextBox.Clear();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            populateChatBox();
        }

        /***************************************************************************/
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            playthroughHistoryList.Items.Clear();
            player1HistoryListBox.Items.Clear();
            playerListBox.Items.Clear();
            _querry_string = "SELECT DISTINCT game.name as gname, player.player_name as pname, rec.id_playthrough as play " +
            "FROM ccdb.record as rec, ccdb.player as player, ccdb.game as game, ccdb.playgame1 as pg " +
            "WHERE rec.win IS NULL and rec.id_playthrough = pg.id_playthrough and pg.id_game = game.id_game and rec.id_player = player.id_player ORDER BY play;";
            try
            {
                read = s.MakeConnection(_querry_string);
                int playNum = 0;
                string temp = "";
                while (read.Read())
                {
                    int NewplayNum = read.GetInt32("play");
                    if (NewplayNum == playNum)
                    {
                        temp += read.GetString("pname") + " ";
                    }
                    else
                    {
                        if (playNum > 0) playthroughHistoryList.Items.Add(temp);
                        temp = "Game # " + NewplayNum + ": " + read.GetString("gname") + "- " + read.GetString("pname") + " ";
                        playNum = NewplayNum;
                    }
                }
                playthroughHistoryList.Items.Add(temp);

            }
            catch (Exception ex)
            { }
            s.CloseConnection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher2_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void sortCardsBy_TextChanged(object sender, EventArgs e)
        {
            if (sortCardsBy.Text != "SelectSort")
            {
                cardListBox.Items.Clear();
                populateCardList(searchCardTextBox.Text.ToString(), _current_game_id, sortCardsBy.Text);
            }

        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            //Displays the add game form with the current selected game information and will perfom update rather than insert upon save click.
            //Untested
            AddGame addForm = new AddGame();
            addForm.ShowDialog();
            addForm.Update = true;
            addForm.Id_game = _current_game_id;
            try
            {
                _querry_string = "Select * From ccdb.game Where ccdb.game.id_game = '" + _current_game_id + "';";
                Server s = new Server();
                read = s.MakeConnection(_querry_string);
                read.Read();
                addForm.SetField(read.GetString("name"), read.GetString("made_by"));
                s.CloseConnection();
            }
            catch (Exception ex)
            {

            }
            populateGameList(searchGameTextBox.Text.ToString());
        }

        private void editCardButton_Click(object sender, EventArgs e)
        {
            //edit current current card = import info to form then save = update
            AddCardsForm addForm = new AddCardsForm(Convert.ToInt32(_current_game_id));
            addForm.ShowDialog();
            populateInformationFields(cardListBox.SelectedItem.ToString());
        }

        private void DeletePlaythrough_Click(object sender, EventArgs e)
        {
            //TODO delete a playthrough, if foreign keys are set up correctly will cascade detete all the rest as expected
        }

        private void AddPlayerGame_Click(object sender, EventArgs e)
        {
            _querry_string = "Select * from ccdb.player;";
            Server s = new Server();
            read = s.MakeConnection(_querry_string);
            playerListBox.Items.Clear();
            playerListBox.Items.Add("Select a player..");
            while (read.Read())
            {
                playerListBox.Items.Add("Player ID: " + read.GetInt32("id_player").ToString() + "- " + read.GetString("player_name"));
            }
        }

    }
}
