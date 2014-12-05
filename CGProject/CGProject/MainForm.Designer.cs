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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rarityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importImageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gameListBox.Size = new System.Drawing.Size(120, 186);
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
            this.addGamesButton.Location = new System.Drawing.Point(13, 233);
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
            this.editGamesButton.Location = new System.Drawing.Point(12, 262);
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
            this.cardListBox.Size = new System.Drawing.Size(120, 355);
            this.cardListBox.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(13, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Search Cards...";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(148, 327);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(130, 186);
            this.imagePictureBox.TabIndex = 10;
            this.imagePictureBox.TabStop = false;
            // 
            // rarityLabel
            // 
            this.rarityLabel.AutoSize = true;
            this.rarityLabel.ForeColor = System.Drawing.Color.Ivory;
            this.rarityLabel.Location = new System.Drawing.Point(145, 71);
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
            this.textBox2.Location = new System.Drawing.Point(148, 41);
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
            this.costLabel.Location = new System.Drawing.Point(145, 98);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 16;
            this.costLabel.Text = "Cost";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.ForeColor = System.Drawing.Color.Ivory;
            this.typeLabel.Location = new System.Drawing.Point(145, 125);
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
            this.rarityTextBox.Location = new System.Drawing.Point(185, 71);
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
            this.costTextBox.Location = new System.Drawing.Point(185, 98);
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
            this.label1.Location = new System.Drawing.Point(145, 159);
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
            this.typeTextBox.Location = new System.Drawing.Point(185, 125);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(91, 13);
            this.typeTextBox.TabIndex = 21;
            this.typeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(148, 176);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(128, 96);
            this.descriptionRichTextBox.TabIndex = 22;
            this.descriptionRichTextBox.Text = "Hello you are a drinker love it strong";
            // 
            // importImageButton
            // 
            this.importImageButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importImageButton.Location = new System.Drawing.Point(148, 298);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(130, 23);
            this.importImageButton.TabIndex = 23;
            this.importImageButton.Text = "Import Image";
            this.importImageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.importImageButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 159);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.importImageButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.rarityTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox rarityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button importImageButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}