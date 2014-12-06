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
            this.editGamesButton = new System.Windows.Forms.Button();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.searchCardTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cardImage = new System.Windows.Forms.PictureBox();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rarityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importCardImageButton = new System.Windows.Forms.Button();
            this.manufacturerImage = new System.Windows.Forms.PictureBox();
            this.editCardButton = new System.Windows.Forms.Button();
            this.importGameImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.player2ListBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Location = new System.Drawing.Point(1044, 12);
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
            this.minimizeButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.minimizeButton.Location = new System.Drawing.Point(1014, 12);
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
            this.gameListBox.Click += new System.EventHandler(this.gameListBox_Click);
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
            this.addGamesButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.addCardButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // editGamesButton
            // 
            this.editGamesButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGamesButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editGamesButton.Location = new System.Drawing.Point(137, 269);
            this.editGamesButton.Name = "editGamesButton";
            this.editGamesButton.Size = new System.Drawing.Size(119, 23);
            this.editGamesButton.TabIndex = 7;
            this.editGamesButton.Text = "Edit Games";
            this.editGamesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editGamesButton.UseVisualStyleBackColor = false;
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
            this.cardImage.Location = new System.Drawing.Point(280, 328);
            this.cardImage.Name = "cardImage";
            this.cardImage.Size = new System.Drawing.Size(130, 186);
            this.cardImage.TabIndex = 10;
            this.cardImage.TabStop = false;
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
            // textBox2
            // 
            this.textBox2.AccessibleName = "";
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(280, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 13);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.rarityTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.costTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.typeTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.Gray;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.importCardImageButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importCardImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importCardImageButton.Location = new System.Drawing.Point(280, 298);
            this.importCardImageButton.Name = "importCardImageButton";
            this.importCardImageButton.Size = new System.Drawing.Size(130, 23);
            this.importCardImageButton.TabIndex = 23;
            this.importCardImageButton.Text = "Import Card Image";
            this.importCardImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.importCardImageButton.UseVisualStyleBackColor = false;
            // 
            // manufacturerImage
            // 
            this.manufacturerImage.Location = new System.Drawing.Point(280, 549);
            this.manufacturerImage.Name = "manufacturerImage";
            this.manufacturerImage.Size = new System.Drawing.Size(130, 159);
            this.manufacturerImage.TabIndex = 24;
            this.manufacturerImage.TabStop = false;
            // 
            // editCardButton
            // 
            this.editCardButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCardButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editCardButton.Location = new System.Drawing.Point(137, 685);
            this.editCardButton.Name = "editCardButton";
            this.editCardButton.Size = new System.Drawing.Size(119, 23);
            this.editCardButton.TabIndex = 25;
            this.editCardButton.Text = "Add Cards";
            this.editCardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.editCardButton.UseVisualStyleBackColor = false;
            // 
            // importGameImageButton
            // 
            this.importGameImageButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importGameImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importGameImageButton.Location = new System.Drawing.Point(280, 520);
            this.importGameImageButton.Name = "importGameImageButton";
            this.importGameImageButton.Size = new System.Drawing.Size(130, 23);
            this.importGameImageButton.TabIndex = 26;
            this.importGameImageButton.Text = "Import Company Image";
            this.importGameImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.importGameImageButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(443, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 171);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // player1ListBox
            // 
            this.player1ListBox.BackColor = System.Drawing.Color.Black;
            this.player1ListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.player1ListBox.FormattingEnabled = true;
            this.player1ListBox.Location = new System.Drawing.Point(441, 41);
            this.player1ListBox.Name = "player1ListBox";
            this.player1ListBox.Size = new System.Drawing.Size(121, 147);
            this.player1ListBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(441, 194);
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
            this.aboutButton.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aboutButton.Location = new System.Drawing.Point(984, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(24, 24);
            this.aboutButton.TabIndex = 32;
            this.aboutButton.Text = "?";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.aboutButton.UseVisualStyleBackColor = false;
            // 
            // player2ListBox
            // 
            this.player2ListBox.BackColor = System.Drawing.Color.Black;
            this.player2ListBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.player2ListBox.FormattingEnabled = true;
            this.player2ListBox.Location = new System.Drawing.Point(947, 41);
            this.player2ListBox.Name = "player2ListBox";
            this.player2ListBox.Size = new System.Drawing.Size(121, 147);
            this.player2ListBox.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(568, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 147);
            this.listBox1.TabIndex = 34;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Black;
            this.listBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(765, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 147);
            this.listBox2.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(599, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Edit Games";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(792, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Edit Games";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(949, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 40;
            this.button4.Text = "Edit Games";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(947, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 171);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.ForeColor = System.Drawing.Color.Ivory;
            this.player1NameLabel.Location = new System.Drawing.Point(568, 227);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(67, 13);
            this.player1NameLabel.TabIndex = 42;
            this.player1NameLabel.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(568, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Player Name";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(641, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(91, 13);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "";
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(777, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 13);
            this.textBox3.TabIndex = 45;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(874, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Player Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(568, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Player Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(568, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Player Name";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "";
            this.textBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(641, 253);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(91, 13);
            this.textBox4.TabIndex = 49;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "";
            this.textBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(641, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(91, 13);
            this.textBox5.TabIndex = 50;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AccessibleName = "";
            this.textBox6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(641, 305);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(91, 13);
            this.textBox6.TabIndex = 51;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AccessibleName = "";
            this.textBox7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(777, 305);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(91, 13);
            this.textBox7.TabIndex = 59;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AccessibleName = "";
            this.textBox8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(777, 279);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(91, 13);
            this.textBox8.TabIndex = 58;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.AccessibleName = "";
            this.textBox9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(777, 253);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(91, 13);
            this.textBox9.TabIndex = 57;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(874, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Player Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(874, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Player Name";
            // 
            // textBox10
            // 
            this.textBox10.AccessibleName = "";
            this.textBox10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(641, 328);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(91, 13);
            this.textBox10.TabIndex = 54;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(874, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Player Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(568, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Player Name";
            // 
            // textBox11
            // 
            this.textBox11.AccessibleName = "";
            this.textBox11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(777, 328);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(91, 13);
            this.textBox11.TabIndex = 61;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(874, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Player Name";
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.Black;
            this.listBox3.ForeColor = System.Drawing.Color.LimeGreen;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(443, 404);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(289, 303);
            this.listBox3.TabIndex = 62;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.Black;
            this.listBox4.ForeColor = System.Drawing.Color.LimeGreen;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(777, 404);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(289, 303);
            this.listBox4.TabIndex = 63;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.player2ListBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player1ListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.importGameImageButton);
            this.Controls.Add(this.editCardButton);
            this.Controls.Add(this.manufacturerImage);
            this.Controls.Add(this.importCardImageButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.rarityTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.cardImage);
            this.Controls.Add(this.searchCardTextBox);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.editGamesButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button editGamesButton;
        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.TextBox searchCardTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox cardImage;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox rarityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button importCardImageButton;
        private System.Windows.Forms.PictureBox manufacturerImage;
        private System.Windows.Forms.Button editCardButton;
        private System.Windows.Forms.Button importGameImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox player1ListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ListBox player2ListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
    }
}