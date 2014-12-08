namespace CGProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.searchGameTextBox = new System.Windows.Forms.TextBox();
            this.addGamesButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.editGameButton = new System.Windows.Forms.Button();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.searchCardTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rarityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importCardImageButton = new System.Windows.Forms.Button();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.editCardButton = new System.Windows.Forms.Button();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.playthroughHistoryList = new System.Windows.Forms.ListBox();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.win1Label = new System.Windows.Forms.Label();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.loss1Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player1WinTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.player1HistoryListBox = new System.Windows.Forms.ListBox();
            this.AddPlay = new System.Windows.Forms.Button();
            this.GameEnd = new System.Windows.Forms.Button();
            this.deleteCardButton = new System.Windows.Forms.Button();
            this.gameCardCountLabel = new System.Windows.Forms.Label();
            this.allGameRadio = new System.Windows.Forms.RadioButton();
            this.currentGameRadio = new System.Windows.Forms.RadioButton();
            this.saveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.importManImageButton = new System.Windows.Forms.Button();
            this.saveManImageButton = new System.Windows.Forms.Button();
            this.playerImportButton = new System.Windows.Forms.Button();
            this.playerSaveButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(824, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 24);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Black;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimizeButton.Location = new System.Drawing.Point(794, 11);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 24);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "_";
            this.minimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // gameListBox
            // 
            this.gameListBox.BackColor = System.Drawing.Color.Black;
            this.gameListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.Location = new System.Drawing.Point(12, 41);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(244, 225);
            this.gameListBox.TabIndex = 3;
            this.gameListBox.SelectedIndexChanged += new System.EventHandler(this.gameListBox_SelectedIndexChanged);
            // 
            // searchGameTextBox
            // 
            this.searchGameTextBox.AccessibleName = "";
            this.searchGameTextBox.BackColor = System.Drawing.Color.Black;
            this.searchGameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchGameTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.searchGameTextBox.Location = new System.Drawing.Point(12, 15);
            this.searchGameTextBox.Name = "searchGameTextBox";
            this.searchGameTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchGameTextBox.TabIndex = 4;
            this.searchGameTextBox.Text = "Search Games...";
            this.searchGameTextBox.Click += new System.EventHandler(this.searchGameTextBox_Click);
            this.searchGameTextBox.TextChanged += new System.EventHandler(this.searchGameTextBox_TextChanged);
            this.searchGameTextBox.Leave += new System.EventHandler(this.searchGameTextBox_Leave);
            // 
            // addGamesButton
            // 
            this.addGamesButton.BackColor = System.Drawing.Color.Gray;
            this.addGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGamesButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addGamesButton.Location = new System.Drawing.Point(14, 269);
            this.addGamesButton.Name = "addGamesButton";
            this.addGamesButton.Size = new System.Drawing.Size(119, 23);
            this.addGamesButton.TabIndex = 5;
            this.addGamesButton.Text = "Add Games";
            this.addGamesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addGamesButton.UseVisualStyleBackColor = false;
            this.addGamesButton.Click += new System.EventHandler(this.addGamesButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.BackColor = System.Drawing.Color.Gray;
            this.addCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCardButton.Location = new System.Drawing.Point(12, 685);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(119, 23);
            this.addCardButton.TabIndex = 6;
            this.addCardButton.Text = "Add Cards";
            this.addCardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addCardButton.UseVisualStyleBackColor = false;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // editGameButton
            // 
            this.editGameButton.BackColor = System.Drawing.Color.Gray;
            this.editGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editGameButton.Location = new System.Drawing.Point(137, 269);
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Size = new System.Drawing.Size(119, 23);
            this.editGameButton.TabIndex = 7;
            this.editGameButton.Text = "Edit Game";
            this.editGameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editGameButton.UseVisualStyleBackColor = false;
            // 
            // cardListBox
            // 
            this.cardListBox.BackColor = System.Drawing.Color.Black;
            this.cardListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.Location = new System.Drawing.Point(13, 324);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(243, 355);
            this.cardListBox.TabIndex = 8;
            this.cardListBox.SelectedIndexChanged += new System.EventHandler(this.cardListBox_SelectedIndexChanged);
            // 
            // searchCardTextBox
            // 
            this.searchCardTextBox.AccessibleName = "";
            this.searchCardTextBox.BackColor = System.Drawing.Color.Black;
            this.searchCardTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchCardTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.searchCardTextBox.Location = new System.Drawing.Point(13, 298);
            this.searchCardTextBox.Name = "searchCardTextBox";
            this.searchCardTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchCardTextBox.TabIndex = 9;
            this.searchCardTextBox.Text = "Search Cards...";
            this.searchCardTextBox.Click += new System.EventHandler(this.searchCardTextBox_Click);
            this.searchCardTextBox.TextChanged += new System.EventHandler(this.searchCardTextBox_TextChanged);
            this.searchCardTextBox.Leave += new System.EventHandler(this.searchCardTextBox_Leave);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cardImage
            // 
            this.cardImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cardImage.Location = new System.Drawing.Point(280, 340);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(130, 174);
            this.cardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImage.TabIndex = 10;
            this.cardImage.TabStop = false;
            this.cardImage.DoubleClick += new System.EventHandler(this.cardImage_DoubleClick);
            this.cardImage.MouseLeave += new System.EventHandler(this.cardImage_MouseLeave);
            this.cardImage.MouseHover += new System.EventHandler(this.cardImage_MouseHover);
            // 
            // rarityLabel
            // 
            this.rarityLabel.AutoSize = true;
            this.rarityLabel.ForeColor = System.Drawing.Color.Ivory;
            this.rarityLabel.Location = new System.Drawing.Point(277, 67);
            this.rarityLabel.Name = "rarityLabel";
            this.rarityLabel.Size = new System.Drawing.Size(34, 13);
            this.rarityLabel.TabIndex = 14;
            this.rarityLabel.Text = "Rarity";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.AccessibleName = "";
            this.cardNameTextBox.BackColor = System.Drawing.Color.White;
            this.cardNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.cardNameTextBox.Location = new System.Drawing.Point(280, 41);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.ReadOnly = true;
            this.cardNameTextBox.Size = new System.Drawing.Size(128, 13);
            this.cardNameTextBox.TabIndex = 15;
            this.cardNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.ForeColor = System.Drawing.Color.Ivory;
            this.costLabel.Location = new System.Drawing.Point(277, 94);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 16;
            this.costLabel.Text = "Cost";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.ForeColor = System.Drawing.Color.Ivory;
            this.typeLabel.Location = new System.Drawing.Point(277, 121);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 17;
            this.typeLabel.Text = "Type";
            // 
            // rarityTextBox
            // 
            this.rarityTextBox.AccessibleName = "";
            this.rarityTextBox.BackColor = System.Drawing.Color.White;
            this.rarityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rarityTextBox.ForeColor = System.Drawing.Color.Black;
            this.rarityTextBox.Location = new System.Drawing.Point(317, 71);
            this.rarityTextBox.Name = "rarityTextBox";
            this.rarityTextBox.ReadOnly = true;
            this.rarityTextBox.Size = new System.Drawing.Size(91, 13);
            this.rarityTextBox.TabIndex = 18;
            this.rarityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costTextBox
            // 
            this.costTextBox.AccessibleName = "";
            this.costTextBox.BackColor = System.Drawing.Color.White;
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.ForeColor = System.Drawing.Color.Black;
            this.costTextBox.Location = new System.Drawing.Point(317, 98);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(91, 13);
            this.costTextBox.TabIndex = 19;
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(277, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Description:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.AccessibleName = "";
            this.typeTextBox.BackColor = System.Drawing.Color.White;
            this.typeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeTextBox.ForeColor = System.Drawing.Color.Black;
            this.typeTextBox.Location = new System.Drawing.Point(317, 125);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(91, 13);
            this.typeTextBox.TabIndex = 21;
            this.typeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(280, 176);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(128, 96);
            this.descriptionRichTextBox.TabIndex = 22;
            this.descriptionRichTextBox.Text = "";
            // 
            // importCardImageButton
            // 
            this.importCardImageButton.BackColor = System.Drawing.Color.Gray;
            this.importCardImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCardImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importCardImageButton.Location = new System.Drawing.Point(280, 295);
            this.importCardImageButton.Name = "importCardImageButton";
            this.importCardImageButton.Size = new System.Drawing.Size(60, 23);
            this.importCardImageButton.TabIndex = 23;
            this.importCardImageButton.Text = " Import";
            this.importCardImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.importCardImageButton.UseVisualStyleBackColor = false;
            this.importCardImageButton.Click += new System.EventHandler(this.importCardImageButton_Click);
            // 
            // gameImage
            // 
            this.gameImage.Location = new System.Drawing.Point(280, 520);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(130, 143);
            this.gameImage.TabIndex = 24;
            this.gameImage.TabStop = false;
            // 
            // editCardButton
            // 
            this.editCardButton.BackColor = System.Drawing.Color.Gray;
            this.editCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCardButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editCardButton.Location = new System.Drawing.Point(137, 685);
            this.editCardButton.Name = "editCardButton";
            this.editCardButton.Size = new System.Drawing.Size(119, 23);
            this.editCardButton.TabIndex = 25;
            this.editCardButton.Text = "Edit Card";
            this.editCardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editCardButton.UseVisualStyleBackColor = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(416, 227);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(133, 142);
            this.playerPictureBox.TabIndex = 28;
            this.playerPictureBox.TabStop = false;
            // 
            // playerListBox
            // 
            this.playerListBox.BackColor = System.Drawing.Color.Black;
            this.playerListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(728, 194);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(119, 147);
            this.playerListBox.TabIndex = 30;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(414, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Edit Games";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.Black;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutButton.Location = new System.Drawing.Point(764, 11);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(24, 24);
            this.aboutButton.TabIndex = 32;
            this.aboutButton.Text = "?";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // playthroughHistoryList
            // 
            this.playthroughHistoryList.BackColor = System.Drawing.Color.Black;
            this.playthroughHistoryList.ForeColor = System.Drawing.Color.LimeGreen;
            this.playthroughHistoryList.FormattingEnabled = true;
            this.playthroughHistoryList.Location = new System.Drawing.Point(416, 41);
            this.playthroughHistoryList.Name = "playthroughHistoryList";
            this.playthroughHistoryList.Size = new System.Drawing.Size(431, 147);
            this.playthroughHistoryList.TabIndex = 34;
            this.playthroughHistoryList.SelectedIndexChanged += new System.EventHandler(this.playthroughHistoryList_SelectedIndexChanged);
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.ForeColor = System.Drawing.Color.Ivory;
            this.player1NameLabel.Location = new System.Drawing.Point(558, 227);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(67, 13);
            this.player1NameLabel.TabIndex = 42;
            this.player1NameLabel.Text = "Player Name";
            // 
            // win1Label
            // 
            this.win1Label.AutoSize = true;
            this.win1Label.ForeColor = System.Drawing.Color.Ivory;
            this.win1Label.Location = new System.Drawing.Point(558, 253);
            this.win1Label.Name = "win1Label";
            this.win1Label.Size = new System.Drawing.Size(37, 13);
            this.win1Label.TabIndex = 43;
            this.win1Label.Text = "Win %";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.AccessibleName = "";
            this.player1NameTextBox.BackColor = System.Drawing.Color.White;
            this.player1NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1NameTextBox.ForeColor = System.Drawing.Color.Black;
            this.player1NameTextBox.Location = new System.Drawing.Point(631, 227);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.ReadOnly = true;
            this.player1NameTextBox.Size = new System.Drawing.Size(91, 13);
            this.player1NameTextBox.TabIndex = 44;
            this.player1NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loss1Label
            // 
            this.loss1Label.AutoSize = true;
            this.loss1Label.ForeColor = System.Drawing.Color.Ivory;
            this.loss1Label.Location = new System.Drawing.Point(558, 279);
            this.loss1Label.Name = "loss1Label";
            this.loss1Label.Size = new System.Drawing.Size(40, 13);
            this.loss1Label.TabIndex = 47;
            this.loss1Label.Text = "Loss %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(558, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Win Total";
            // 
            // player1WinTextBox
            // 
            this.player1WinTextBox.AccessibleName = "";
            this.player1WinTextBox.BackColor = System.Drawing.Color.White;
            this.player1WinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1WinTextBox.ForeColor = System.Drawing.Color.Black;
            this.player1WinTextBox.Location = new System.Drawing.Point(631, 253);
            this.player1WinTextBox.Name = "player1WinTextBox";
            this.player1WinTextBox.ReadOnly = true;
            this.player1WinTextBox.Size = new System.Drawing.Size(91, 13);
            this.player1WinTextBox.TabIndex = 49;
            this.player1WinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "";
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(631, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(91, 13);
            this.textBox5.TabIndex = 50;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "";
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(631, 305);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(91, 13);
            this.textBox6.TabIndex = 51;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.AccessibleName = "";
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(631, 328);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(91, 13);
            this.textBox10.TabIndex = 54;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(558, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Loss Total";
            // 
            // player1HistoryListBox
            // 
            this.player1HistoryListBox.BackColor = System.Drawing.Color.Black;
            this.player1HistoryListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.player1HistoryListBox.FormattingEnabled = true;
            this.player1HistoryListBox.Location = new System.Drawing.Point(416, 404);
            this.player1HistoryListBox.Name = "player1HistoryListBox";
            this.player1HistoryListBox.Size = new System.Drawing.Size(431, 303);
            this.player1HistoryListBox.TabIndex = 62;
            this.player1HistoryListBox.SelectedIndexChanged += new System.EventHandler(this.player1HistoryListBox_SelectedIndexChanged);
            // 
            // AddPlay
            // 
            this.AddPlay.BackColor = System.Drawing.Color.Gray;
            this.AddPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPlay.Location = new System.Drawing.Point(419, 11);
            this.AddPlay.Name = "AddPlay";
            this.AddPlay.Size = new System.Drawing.Size(130, 23);
            this.AddPlay.TabIndex = 63;
            this.AddPlay.Text = "Add Play";
            this.AddPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddPlay.UseVisualStyleBackColor = false;
            this.AddPlay.Click += new System.EventHandler(this.AddPlay_Click);
            // 
            // GameEnd
            // 
            this.GameEnd.BackColor = System.Drawing.Color.Gray;
            this.GameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameEnd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GameEnd.Location = new System.Drawing.Point(725, 376);
            this.GameEnd.Name = "GameEnd";
            this.GameEnd.Size = new System.Drawing.Size(122, 23);
            this.GameEnd.TabIndex = 67;
            this.GameEnd.Text = "Selected Player Wins";
            this.GameEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GameEnd.UseVisualStyleBackColor = false;
            // 
            // deleteCardButton
            // 
            this.deleteCardButton.BackColor = System.Drawing.Color.Gray;
            this.deleteCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCardButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteCardButton.Location = new System.Drawing.Point(139, 295);
            this.deleteCardButton.Name = "deleteCardButton";
            this.deleteCardButton.Size = new System.Drawing.Size(119, 23);
            this.deleteCardButton.TabIndex = 68;
            this.deleteCardButton.Text = "Delete Card";
            this.deleteCardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deleteCardButton.UseVisualStyleBackColor = false;
            this.deleteCardButton.Click += new System.EventHandler(this.deleteCardButton_Click);
            // 
            // gameCardCountLabel
            // 
            this.gameCardCountLabel.AutoSize = true;
            this.gameCardCountLabel.ForeColor = System.Drawing.Color.Ivory;
            this.gameCardCountLabel.Location = new System.Drawing.Point(280, 279);
            this.gameCardCountLabel.Name = "gameCardCountLabel";
            this.gameCardCountLabel.Size = new System.Drawing.Size(91, 13);
            this.gameCardCountLabel.TabIndex = 69;
            this.gameCardCountLabel.Text = "Game Card Count";
            // 
            // allGameRadio
            // 
            this.allGameRadio.AutoSize = true;
            this.allGameRadio.ForeColor = System.Drawing.Color.LimeGreen;
            this.allGameRadio.Location = new System.Drawing.Point(539, 200);
            this.allGameRadio.Name = "allGameRadio";
            this.allGameRadio.Size = new System.Drawing.Size(72, 17);
            this.allGameRadio.TabIndex = 70;
            this.allGameRadio.TabStop = true;
            this.allGameRadio.Text = "All Games";
            this.allGameRadio.UseVisualStyleBackColor = true;
            this.allGameRadio.CheckedChanged += new System.EventHandler(this.allGameRadio_CheckedChanged);
            // 
            // currentGameRadio
            // 
            this.currentGameRadio.AutoSize = true;
            this.currentGameRadio.ForeColor = System.Drawing.Color.Lime;
            this.currentGameRadio.Location = new System.Drawing.Point(637, 200);
            this.currentGameRadio.Name = "currentGameRadio";
            this.currentGameRadio.Size = new System.Drawing.Size(90, 17);
            this.currentGameRadio.TabIndex = 71;
            this.currentGameRadio.TabStop = true;
            this.currentGameRadio.Text = "Current Game";
            this.currentGameRadio.UseVisualStyleBackColor = true;
            this.currentGameRadio.CheckedChanged += new System.EventHandler(this.currentGameRadio_CheckedChanged);
            // 
            // saveImage
            // 
            this.saveImage.BackColor = System.Drawing.Color.Gray;
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImage.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveImage.Location = new System.Drawing.Point(346, 295);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(67, 23);
            this.saveImage.TabIndex = 72;
            this.saveImage.Text = "Save";
            this.saveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveImage.UseVisualStyleBackColor = false;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(310, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Card Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(293, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Manufacturer Image";
            // 
            // importManImageButton
            // 
            this.importManImageButton.BackColor = System.Drawing.Color.Gray;
            this.importManImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importManImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importManImageButton.Location = new System.Drawing.Point(278, 685);
            this.importManImageButton.Name = "importManImageButton";
            this.importManImageButton.Size = new System.Drawing.Size(60, 23);
            this.importManImageButton.TabIndex = 75;
            this.importManImageButton.Text = " Import";
            this.importManImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.importManImageButton.UseVisualStyleBackColor = false;
            this.importManImageButton.Click += new System.EventHandler(this.importManImageButton_Click);
            // 
            // saveManImageButton
            // 
            this.saveManImageButton.BackColor = System.Drawing.Color.Gray;
            this.saveManImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveManImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.saveManImageButton.Location = new System.Drawing.Point(341, 685);
            this.saveManImageButton.Name = "saveManImageButton";
            this.saveManImageButton.Size = new System.Drawing.Size(67, 23);
            this.saveManImageButton.TabIndex = 76;
            this.saveManImageButton.Text = "Save";
            this.saveManImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.saveManImageButton.UseVisualStyleBackColor = false;
            this.saveManImageButton.Click += new System.EventHandler(this.saveManImageButton_Click);
            // 
            // playerImportButton
            // 
            this.playerImportButton.BackColor = System.Drawing.Color.Gray;
            this.playerImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerImportButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerImportButton.Location = new System.Drawing.Point(416, 375);
            this.playerImportButton.Name = "playerImportButton";
            this.playerImportButton.Size = new System.Drawing.Size(60, 23);
            this.playerImportButton.TabIndex = 77;
            this.playerImportButton.Text = " Import";
            this.playerImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.playerImportButton.UseVisualStyleBackColor = false;
            this.playerImportButton.Click += new System.EventHandler(this.playerImportButton_Click);
            // 
            // playerSaveButton
            // 
            this.playerSaveButton.BackColor = System.Drawing.Color.Gray;
            this.playerSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerSaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerSaveButton.Location = new System.Drawing.Point(482, 375);
            this.playerSaveButton.Name = "playerSaveButton";
            this.playerSaveButton.Size = new System.Drawing.Size(67, 23);
            this.playerSaveButton.TabIndex = 78;
            this.playerSaveButton.Text = "Save";
            this.playerSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.playerSaveButton.UseVisualStyleBackColor = false;
            this.playerSaveButton.Click += new System.EventHandler(this.playerSaveButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.Gray;
            this.addPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPlayerButton.Location = new System.Drawing.Point(631, 347);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(91, 23);
            this.addPlayerButton.TabIndex = 79;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.BackColor = System.Drawing.Color.Gray;
            this.deletePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletePlayerButton.Location = new System.Drawing.Point(727, 347);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(120, 23);
            this.deletePlayerButton.TabIndex = 80;
            this.deletePlayerButton.Text = "Delete Player";
            this.deletePlayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.deletePlayerButton.UseVisualStyleBackColor = false;
            this.deletePlayerButton.Click += new System.EventHandler(this.deletePlayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 720);
            this.Controls.Add(this.deletePlayerButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.playerSaveButton);
            this.Controls.Add(this.playerImportButton);
            this.Controls.Add(this.saveManImageButton);
            this.Controls.Add(this.importManImageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveImage);
            this.Controls.Add(this.currentGameRadio);
            this.Controls.Add(this.allGameRadio);
            this.Controls.Add(this.gameCardCountLabel);
            this.Controls.Add(this.deleteCardButton);
            this.Controls.Add(this.GameEnd);
            this.Controls.Add(this.AddPlay);
            this.Controls.Add(this.player1HistoryListBox);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.player1WinTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loss1Label);
            this.Controls.Add(this.player1NameTextBox);
            this.Controls.Add(this.win1Label);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.playthroughHistoryList);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.editCardButton);
            this.Controls.Add(this.gameImage);
            this.Controls.Add(this.importCardImageButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.rarityTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.searchCardTextBox);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.editGameButton);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.addGamesButton);
            this.Controls.Add(this.searchGameTextBox);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.TextBox searchGameTextBox;
        private System.Windows.Forms.Button addGamesButton;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Button editGameButton;
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.TextBox searchCardTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox rarityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button importCardImageButton;
        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.Button editCardButton;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ListBox playthroughHistoryList;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label win1Label;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.Label loss1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox player1WinTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox player1HistoryListBox;
        private System.Windows.Forms.Button AddPlay;
        private System.Windows.Forms.Button GameEnd;
        private System.Windows.Forms.Button deleteCardButton;
        private System.Windows.Forms.Label gameCardCountLabel;
        private System.Windows.Forms.RadioButton allGameRadio;
        private System.Windows.Forms.RadioButton currentGameRadio;
        private System.Windows.Forms.Button saveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button importManImageButton;
        private System.Windows.Forms.Button saveManImageButton;
        private System.Windows.Forms.Button playerImportButton;
        private System.Windows.Forms.Button playerSaveButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button deletePlayerButton;
    }
}