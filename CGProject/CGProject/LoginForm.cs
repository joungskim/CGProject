using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGProject
{
    public partial class LoginForm : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            if (userTextBox.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must provide a username.");
            }

            else if (passwordTextBox.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must provide a password.");
            }

            else
            {
                username = userTextBox.Text.ToString();
                password = passwordTextBox.Text.ToString();
                MessageBox.Show("Login Successful! User: " + username + "Pass: " + password);
            }

        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

    }
}
