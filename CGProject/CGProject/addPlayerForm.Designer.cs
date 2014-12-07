namespace CGProject
{
    partial class addPlayerForm
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
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPlayerButton.Location = new System.Drawing.Point(14, 38);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.createPlayerButton.TabIndex = 10;
            this.createPlayerButton.Text = "Add Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(90, 5);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerNameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(73, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Player Name: ";
            // 
            // addPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(207, 74);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "addPlayerForm";
            this.Text = "addPlayerForm";
            this.Load += new System.EventHandler(this.addPlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}