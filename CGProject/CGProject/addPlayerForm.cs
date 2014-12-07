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
using System.IO;

namespace CGProject
{
    public partial class addPlayerForm : Form
    {
        private int pID;
        private MySqlDataReader read;

        public addPlayerForm()
        {
            InitializeComponent();
        }




        private void addPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
