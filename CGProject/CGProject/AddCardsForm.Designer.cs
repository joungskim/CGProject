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
            this.SuspendLayout();
            // 
            // importCSVButton
            // 
            this.importCSVButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importCSVButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.importCSVButton.Location = new System.Drawing.Point(15, 105);
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
            this.cardNameTextBox.ReadOnly = true;
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
            this.rarityTextBox.ReadOnly = true;
            this.rarityTextBox.Size = new System.Drawing.Size(91, 13);
            this.rarityTextBox.TabIndex = 49;
            this.rarityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rarityTextBox);
            this.Controls.Add(this.rarityLabel);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addGamesButton);
            this.Controls.Add(this.importCSVButton);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "AddCardsForm";
            this.Text = "AddCardsForm";
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
    }
}