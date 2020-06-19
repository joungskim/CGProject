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
        private MySqlDataReader read;
        private int gameId;
        public AddCardsForm(int gameId)
        {
            InitializeComponent();
            this.gameId = gameId;
        }
        

        /*
         * This isn't actually adding cards to the database
         * 12/06/2014 5:22 PM
         * 
         * */
        private void button1_Click(object sender, EventArgs e)
        {
            importNotificationLabel.Visible = false;
            int count = 0;
            int countIns = 0;
            Server s = new Server();
            string line;
            int countAdded = 0;

            OpenFileDialog x = new OpenFileDialog();
            if (x.ShowDialog() == DialogResult.OK)
            {

                System.IO.StreamReader file = new System.IO.StreamReader(x.FileName);
                try
                {
                    string line1 = file.ReadLine();

                    while ((line = file.ReadLine()) != null)
                    {
                        if (!AddCard(line1, line.Split(',')))
                        {
                            //MessageBox.Show("There was an error reading the file\nWith columns " + line1 + " and the line read in as " + line);
                            count++;
                        }

                        else
                        {
                            
                            importNotificationLabel.Visible = true;
                            string temp = line.Split(',')[line1.Split(',').ToList<string>().IndexOf("name")];
                            importNotificationLabel.Text = "Adding Card: " + temp;
                            countAdded++;
                        }
                    }
                    importNotificationLabel.Text = "Cards inserted: " + countAdded + " - Cards not inserted: " + countIns;
                    file.Close();
                }
                catch(IOException ex)
                {

                }

            }

  
        }

        //This is wrong? No DataBase is getting added anymore. 5:25PM
        public bool AddCard(string colNames, string[] colVals)
        {
            try
            {
                if (colNames.Contains("name"))
                {
                    Server s = new Server();

                    string[] colName = colNames.Split(',');
                        string insert = "INSERT INTO ccdb.card (" + colNames + ",id_game) VALUES  (";
                        for (int i = 0; i < colVals.Count() ;i++ )
                        {
                            if (colName[i] == "cost")
                            {
                                insert += colVals[i] + ",";
                            }
                            else
                            {
                                insert += "'" + colVals[i] + "'" + ",";
                            }
                        }
                        insert += "'" + gameId + "') ;";
                        read = s.MakeConnection(insert);
                        s.CloseConnection();
                    }
                else
                {
                    MessageBox.Show("File does not include required field name!");
                }
                return true;
            }catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createCardButton_Click(object sender, EventArgs e)
        {
            List<string> header = new List<string>();
            List<string> resultString = new List<string>();
            string results = "";
            int testInt;

            if(cardNameTextBox.Text.Equals(""))
            {
                MessageBox.Show("You must enter a name.");
            }

            else if(!(int.TryParse(costTextBox.Text, out testInt)) && !(costTextBox.Text.Equals("")))
            {
                MessageBox.Show("You must enter a number in Cost Field.");
            }

            else
            {
                header.Add("name");
                resultString.Add(cardNameTextBox.Text.ToString());

                if (!costTextBox.Text.Equals(""))
                {
                    header.Add("cost");
                    resultString.Add(costTextBox.Text.ToString());
                }
                if (!rarityTextBox.Text.Equals(""))
                {
                    header.Add("rarity");
                    resultString.Add(rarityTextBox.Text.ToString());
                }
                if(!descriptionRichTextBox.Text.Equals(""))
                {
                    header.Add("description");
                    resultString.Add(descriptionRichTextBox.Text.ToString());
                }
                if(!typeTextBox1.Text.Equals(""))
                {
                    header.Add("type");
                    resultString.Add(typeTextBox1.Text.ToString());
                }

                for(int i = 0; i < header.Count() - 1; i++)
                {
                    results += header[i] + ",";
                }
                results += header[header.Count() - 1];

                AddCard(results,resultString.ToArray());



                cardNameTextBox.Clear();
                costTextBox.Clear();
                rarityTextBox.Clear();
                descriptionRichTextBox.Clear();
                typeTextBox1.Clear();

                createdIndicatorLabel.Visible = true;
            }

        }

        /**************************************************************************
         * All click functions that are aesthetic towards the form.
         */

        private void cardNameTextBox_TextChanged(object sender, EventArgs e)
        {
            createdIndicatorLabel.Visible = false;
            importNotificationLabel.Visible = false;
        }

        private void rarityTextBox_TextChanged(object sender, EventArgs e)
        {
            createdIndicatorLabel.Visible = false;
            importNotificationLabel.Visible = false;
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            createdIndicatorLabel.Visible = false;
            importNotificationLabel.Visible = false;
        }

        private void typeTextBox1_TextChanged(object sender, EventArgs e)
        {
            createdIndicatorLabel.Visible = false;
            importNotificationLabel.Visible = false;
        }

        private void descriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            createdIndicatorLabel.Visible = false;
            importNotificationLabel.Visible = false;
        }

        /**************************************************************************/
    }
}
