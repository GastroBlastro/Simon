//Simon Game Simulator
//By: Gibson J. MacMillan
//03.10.2014
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Simon
{
    public partial class Form1 : Form
    {
        //create necessary variables and assign classes
        Random rand = new Random();
        List<int> buttonHistory = new List<int>();
        int counter, score;
        bool comp;


        public Form1()
        {
            InitializeComponent();
            //set score to 0 when program starts
            score = 0;
        }

        /// <summary>
        /// The computer takes turn clicking buttons while storing them in a list
        /// </summary>
        void compTurn()
        {
            //makes light red
            lightBox.Image = Properties.Resources.red_on;

            //adds computer choice to buttonHistory list for future reference
            buttonHistory.Add(rand.Next(0, 4));

            //depending on computer choice (from buttonHistory), clicks buttons for player to see
            for (int i = 0; i < buttonHistory.Count(); i++)
            {
                if (buttonHistory[i] == 0)
                {
                    //runs greenButton method
                    greenButton.PerformClick();
                }
                else if (buttonHistory[i] == 1)
                {
                    //runs redButton method
                    redButton.PerformClick();
                }
                else if (buttonHistory[i] == 2)
                {
                    //runs yellowButton method
                    yellowButton.PerformClick();
                }
                else if (buttonHistory[i] == 3)
                {
                    //runs blueButton method
                    blueButton.PerformClick();
                }

                //if gone through all of computers choices, computer turn done
                if (i + 1 == buttonHistory.Count())
                {
                    counter = 0;
                    comp = false;
                }
            }

            //set light green
            lightBox.Image = Properties.Resources.green_on;


        }

        /// <summary>
        /// Contains methods for all buttons visible
        /// </summary>
        #region buttons

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program on exit button click
            Close();
        }

        /// <summary>
        /// prepares game for 1st round
        /// </summary>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            //sets button colours
            greenButton.BackColor = Color.Green;
            redButton.BackColor = Color.Red;
            yellowButton.BackColor = Color.Gold;
            blueButton.BackColor = Color.Blue;

            //clears computer button history
            buttonHistory.Clear();

           //resets score and counter to 0
            score = 0;
            counter = 0;
            screenLabel.Text = score.ToString("00");

            //set computer turn to true
            comp = true;

            //enables buttons
            greenButton.Enabled = true;
            redButton.Enabled = true;
            yellowButton.Enabled = true;
            blueButton.Enabled = true;

            //start computer turn
            compTurn();
        }
        
        void greenButtonMethod(object sender, EventArgs e)
        {
            if (buttonHistory[counter] == 0)
            {
                //runs moo sound, brightens colour, and after 1.5 secs resets colour and increases counter
                SoundPlayer player = new SoundPlayer(Properties.Resources.moo);
                player.Play();
                greenButton.BackColor = Color.LimeGreen;
                Refresh();
                Thread.Sleep(1500);
                greenButton.BackColor = Color.Green;
                player.Stop();
                counter++;
            }

            //if wrong button hit, runs wrongButton method
           else
            {
                wrongButton();
            }            

            //if players turn done, increases score and goes to computer turn
            if (counter == buttonHistory.Count() && comp == false)
            {
                score++;
                screenLabel.Text = score.ToString("00"); 
                counter = 0; 
                comp = true;
                compTurn();
            }
            
        }

        void redButtonMethod(object sender, EventArgs e)
        {
            //runs gaggle sound, brightens colour, and after 1.5 secs resets colour and increases counter
            if (buttonHistory[counter] == 1)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.goose);
                player.Play();
                redButton.BackColor = Color.Tomato;
                Refresh();
                Thread.Sleep(1000);
                redButton.BackColor = Color.Red;
                player.Stop();
                counter++;
                
            }

            //if wrong button hit, runs wrongButton method
            else
            {
                wrongButton();
            }

            //if players turn done, increases score and goes to computer turn
            if (counter == buttonHistory.Count() && comp == false)
            {
                score++;
                screenLabel.Text = score.ToString("00");
                counter = 0;
                comp = true;
                compTurn();
            }
        }

        void yellowButtonMethod(object sender, EventArgs e)
        {
            //runs elephant sound, brightens colour, and after 1.5 secs resets colour and increases counter
            if (buttonHistory[counter] == 2)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.elephant);
                player.Play();
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                Thread.Sleep(1500);
                yellowButton.BackColor = Color.Gold;
                player.Stop();
                counter++;
            }

            //if wrong button hit, runs wrongButton method
            else
            {
                wrongButton();
            }
            //if players turn done, increases score and goes to computer turn
            if (counter == buttonHistory.Count() && comp == false)
            {
                score++;
                screenLabel.Text = score.ToString("00");
                counter = 0;
                comp = true;
                compTurn();
            }
        }

        void blueButtonMethod(object sender, EventArgs e)
        {
            //runs hee-haw sound, brightens colour, and after 1.5 secs resets colour and increases counter
            if (buttonHistory[counter] == 3)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.donkey);
                player.Play();
                blueButton.BackColor = Color.DodgerBlue;
                Refresh();
                Thread.Sleep(1400);
                blueButton.BackColor = Color.Blue;
                player.Stop();
                counter++;

            }
            //if wrong button hit, runs wrongButton method
            else
            {
                wrongButton();
            }
            //if players turn done, increases score and goes to computer turn
            if(counter == buttonHistory.Count() && comp == false)
            {
                score++;
                screenLabel.Text = score.ToString("00");
                counter = 0;
                comp = true;
                compTurn();
            }
        }

        /// <summary>
        /// Occurs when wrong button clicked by user, 
        /// disables further actions by user until new game button clicked.
        /// </summary>
        public void wrongButton()
        {
            //plays fart noise, disabled and sets button to black, turns light off
            SoundPlayer player = new SoundPlayer(Properties.Resources.end);
            player.Play();
            greenButton.BackColor = Color.Black;
            redButton.BackColor = Color.Black;
            yellowButton.BackColor = Color.Black;
            blueButton.BackColor = Color.Black;
            screenLabel.Text = score.ToString("00");
            lightBox.Image = Properties.Resources.light_off;
            greenButton.Enabled = false;
            redButton.Enabled = false;
            yellowButton.Enabled = false;
            blueButton.Enabled = false;

        }
        #endregion
    }
}
