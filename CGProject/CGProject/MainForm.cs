using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CGProject
{
    public partial class MainForm : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private MySqlDataReader read;

        public MainForm()
        {
            InitializeComponent();
            populateGameList("");
        }

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

        private void searchGameTextBox_Click(object sender, EventArgs e)
        {
            searchGameTextBox.Text = "";
        }

        private void searchGameTextBox_Leave(object sender, EventArgs e)
        {
            if(searchGameTextBox.Text.Equals(""))
            {
                searchGameTextBox.Text = "Search Games...";
            }
        }

        private void populateGameList(string search)
        {
            if (!search.Equals("Search Games..."))
            {
                Server s = new Server();
                try
                {
                    read = s.MakeConnection("Select * from sakila.actor where sakila.actor.first_name like '%" + search + "%' ;");
                    while (read.Read())
                    {
                        gameListBox.Items.Add(read.GetString("first_name"));
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
                    read = s.MakeConnection("Select * from sakila.actor ;");
                    while (read.Read())
                    {
                        gameListBox.Items.Add(read.GetString("first_name"));
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

        private void searchGameTextBox_TextChanged(object sender, EventArgs e)
        {
            gameListBox.Items.Clear();
            populateGameList(searchGameTextBox.Text.ToString());
        }

        private void gameListBox_Click(object sender, EventArgs e)
        {
            cardListBox.Items.Clear();
            try
            {
                string selected = gameListBox.SelectedItem.ToString();
                cardListBox.Items.Add(selected);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
