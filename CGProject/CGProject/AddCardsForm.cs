using System;
using System.IO;
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
    public partial class AddCardsForm : Form
    {
        public AddCardsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string line;
            OpenFileDialog x = new OpenFileDialog();
            DialogResult result = x.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.IO.StreamReader file = new System.IO.StreamReader(result.ToString());
                try
                {
                    while(file.ReadLine()!= null)
                    {

                        int card_ID = 1;
                        line = file.ReadLine();
                        string[] values = line.Split(',');
                        
                    }
                }
                catch(IOException)
                {

                }
            }
        }
    }
}
