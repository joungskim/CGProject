namespace CGProject
{
    partial class AddCardsForm
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
            this.importCSVButton = new System.Windows.Forms.Button();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addGamesButton = new System.Windows.Forms.Button();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.rarityTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.typeTextBox1 = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.createCardButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importCSVButton
            // 
            this.importCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importCSVButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importCSVButton.Location = new System.Drawing.Point(197, 143);
            this.importCSVButton.Name = "importCSVButton";
            this.importCSVButton.Size = new System.Drawing.Size(75, 23);
            this.importCSVButton.TabIndex = 0;
            this.importCSVButton.Text = "Import CSV";
            this.importCSVButton.UseVisualStyleBackColor = true;
            this.importCSVButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.AccessibleName = "";
            this.cardNameTextBox.BackColor = System.Drawing.Color.White;
            this.cardNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.cardNameTextBox.Location = new System.Drawing.Point(85, 12);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(91, 13);
            this.cardNameTextBox.TabIndex = 47;
            this.cardNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Ivory;
            this.nameLabel.Location = new System.Drawing.Point(12, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 46;
            this.nameLabel.Text = "Card Name";
            // 
            // addGamesButton
            // 
            this.addGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGamesButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addGamesButton.Location = new System.Drawing.Point(-478, 102);
            this.addGamesButton.Name = "addGamesButton";
            this.addGamesButton.Size = new System.Drawing.Size(119, 23);
            this.addGamesButton.TabIndex = 45;
            this.addGamesButton.Text = "Add Games";
            this.addGamesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addGamesButton.UseVisualStyleBackColor = false;
            // 
            // rarityLabel
            // 
            this.rarityLabel.AutoSize = true;
            this.rarityLabel.ForeColor = System.Drawing.Color.Ivory;
            this.rarityLabel.Location = new System.Drawing.Point(12, 31);
            this.rarityLabel.Name = "rarityLabel";
            this.rarityLabel.Size = new System.Drawing.Size(34, 13);
            this.rarityLabel.TabIndex = 48;
            this.rarityLabel.Text = "Rarity";
            // 
            // rarityTextBox
            // 
            this.rarityTextBox.AccessibleName = "";
            this.rarityTextBox.BackColor = System.Drawing.Color.White;
            this.rarityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rarityTextBox.ForeColor = System.Drawing.Color.Black;
            this.rarityTextBox.Location = new System.Drawing.Point(85, 31);
            this.rarityTextBox.Name = "rarityTextBox";
            this.rarityTextBox.Size = new System.Drawing.Size(91, 13);
            this.rarityTextBox.TabIndex = 49;
            this.rarityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costTextBox
            // 
            this.costTextBox.AccessibleName = "";
            this.costTextBox.BackColor = System.Drawing.Color.White;
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costTextBox.ForeColor = System.Drawing.Color.Black;
            this.costTextBox.Location = new System.Drawing.Point(85, 50);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(91, 13);
            this.costTextBox.TabIndex = 51;
            this.costTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.ForeColor = System.Drawing.Color.Ivory;
            this.costLabel.Location = new System.Drawing.Point(12, 50);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 50;
            this.costLabel.Text = "Cost";
            // 
            // typeTextBox1
            // 
            this.typeTextBox1.AccessibleName = "";
            this.typeTextBox1.BackColor = System.Drawing.Color.White;
            this.typeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeTextBox1.ForeColor = System.Drawing.Color.Black;
            this.typeTextBox1.Location = new System.Drawing.Point(85, 69);
            this.typeTextBox1.Name = "typeTextBox1";
            this.typeTextBox1.Size = new System.Drawing.Size(91, 13);
            this.typeTextBox1.TabIndex = 53;
            this.typeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeTextBox
            // 
            this.typeTextBox.AutoSize = true;
            this.typeTextBox.ForeColor = System.Drawing.Color.Ivory;
            this.typeTextBox.Location = new System.Drawing.Point(12, 69);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(31, 13);
            this.typeTextBox.TabIndex = 52;
            this.typeTextBox.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(85, 88);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(91, 78);
            this.descriptionRichTextBox.TabIndex = 55;
            this.descriptionRichTextBox.Text = "";
            // 
            // createCardButton
            // 
            this.createCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createCardButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createCardButton.Location = new System.Drawing.Point(197, 12);
            this.createCardButton.Name = "createCardButton";
            this.createCardButton.Size = new System.Drawing.Size(75, 23);
            this.createCardButton.TabIndex = 56;
            this.createCardButton.Text = "Create Card";
            this.createCardButton.UseVisualStyleBackColor = true;
            this.createCardButton.Click += new System.EventHandler(this.createCardButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(197, 41);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 57;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createCardButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeTextBox1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.rarityTextBox);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addGamesButton);
            this.Controls.Add(this.importCSVButton);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCardsForm";
            this.Text = "Add Cards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importCSVButton;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addGamesButton;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.TextBox rarityTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox typeTextBox1;
        private System.Windows.Forms.Label typeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button createCardButton;
        private System.Windows.Forms.Button cancelButton;
    }
}