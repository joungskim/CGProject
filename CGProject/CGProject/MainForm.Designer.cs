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
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.searchGameTextBox = new System.Windows.Forms.TextBox();
            this.addGameButton = new System.Windows.Forms.Button();
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
            this.gameListBox.Size = new System.Drawing.Size(120, 238);
            this.gameListBox.TabIndex = 3;
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
            this.searchGameTextBox.Leave += new System.EventHandler(this.searchGameTextBox_Leave);
            // 
            // addGameButton
            // 
            this.addGameButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.addGameButton.Location = new System.Drawing.Point(13, 286);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(119, 23);
            this.addGameButton.TabIndex = 5;
            this.addGameButton.Text = "Add/Edit Games";
            this.addGameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addGameButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.addGameButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.TextBox searchGameTextBox;
        private System.Windows.Forms.Button addGameButton;
    }
}