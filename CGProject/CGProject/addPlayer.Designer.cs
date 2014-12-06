namespace CGProject
{
    partial class addPlayer
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
            this.playerName = new System.Windows.Forms.Label();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPlayerButton.Location = new System.Drawing.Point(53, 38);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(119, 23);
            this.createPlayerButton.TabIndex = 71;
            this.createPlayerButton.Text = "Create";
            this.createPlayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createPlayerButton.UseVisualStyleBackColor = false;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(12, 19);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(35, 13);
            this.playerName.TabIndex = 72;
            this.playerName.Text = "Name";
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Location = new System.Drawing.Point(53, 12);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.PlayerNameTextBox.TabIndex = 73;
            // 
            // addPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(185, 75);
            this.Controls.Add(this.PlayerNameTextBox);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.createPlayerButton);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.TextBox PlayerNameTextBox;

    }
}