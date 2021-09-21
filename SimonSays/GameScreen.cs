using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int currentGuess;
        Random randGen = new Random();

        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer badSound = new SoundPlayer(Properties.Resources.mistake);

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();

            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, 300, 300);
            Region buttonRegion = new Region(buttonPath);
            GraphicsPath excludePath = new GraphicsPath();
            excludePath.AddEllipse(90, 90, 120, 120);
            buttonRegion.Exclude(excludePath);
            greenButton.Region = buttonRegion;

            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt(90, new PointF(75, 75));

            buttonRegion.Transform(transformMatrix);
            redButton.Region = buttonRegion;


            transformMatrix.RotateAt(90, new PointF(75, 75));

            buttonRegion.Transform(transformMatrix);
            yellowButton.Region = buttonRegion;


            transformMatrix.RotateAt(90, new PointF(75, 75));

            buttonRegion.Transform(transformMatrix);
            blueButton.Region = buttonRegion;

            roundLabel.Text = "1";

            this.Refresh();
            Thread.Sleep(1000);
            ComputerTurn();


            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            Form1.pattern.Add(randGen.Next(0, 4));
            roundLabel.Text = $"{Form1.pattern.Count}";
            this.Refresh();

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            Thread.Sleep(500);
            for (int i = 0;i < Form1.pattern.Count;i++)
            {
                if(Form1.pattern[i] == 0)
                {
                    redButton.BackColor = Color.Coral;
                    redSound.Play();
                }
                else if (Form1.pattern[i] == 1)
                {
                    yellowButton.BackColor = Color.Khaki;
                    yellowSound.Play();
                }
                else if (Form1.pattern[i] == 2)
                {
                    greenButton.BackColor = Color.LightGreen;
                    greenSound.Play();
                }
                else {
                    blueButton.BackColor = Color.CornflowerBlue;
                    blueSound.Play();
                }
                this.Refresh();
                Thread.Sleep(500 - (Form1.difficulty == "Hard" ? 350 : 0));

                if (Form1.pattern[i] == 0)
                {
                    redButton.BackColor = Color.DarkRed;
                }
                else if (Form1.pattern[i] == 1)
                {
                    yellowButton.BackColor = Color.Goldenrod;
                }
                else if (Form1.pattern[i] == 2)
                {
                    greenButton.BackColor = Color.ForestGreen;
                }
                else
                {
                    blueButton.BackColor = Color.DarkBlue;
                }
                this.Refresh();
                Thread.Sleep(400 - (Form1.difficulty == "Hard" ? 275 : 0));
            }

            //TODO: get guess index value back to 0
            currentGuess = 0;
        }

        public void GameOver()
        {
            SoundPlayer badSound = new SoundPlayer(Properties.Resources.mistake);
            badSound.Play();

            // Remove the current screen
            Form f = FindForm();
            f.Controls.Remove(this);

            // Replace it with the game over screen
            GameOverScreen gos = new GameOverScreen();
            f.Controls.Add(gos);

        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[currentGuess] == 2)
            {
                greenButton.BackColor = Color.LightGreen;
                this.Refresh();
                greenSound.Play();
                Thread.Sleep(250);
                greenButton.BackColor = Color.ForestGreen;
                this.Refresh();
                currentGuess++;
                if (currentGuess >= Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if(Form1.pattern[currentGuess] == 0)
            {
                redButton.BackColor = Color.Coral;
                this.Refresh();
                redSound.Play();
                Thread.Sleep(250);
                redButton.BackColor = Color.DarkRed;
                this.Refresh();
                currentGuess++;
                if(currentGuess >= Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[currentGuess] == 1)
            {
                yellowButton.BackColor = Color.Khaki;
                this.Refresh();
                yellowSound.Play();
                Thread.Sleep(250);
                yellowButton.BackColor = Color.Goldenrod;
                this.Refresh();
                currentGuess++;
                if (currentGuess >= Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[currentGuess] == 3)
            {
                blueButton.BackColor = Color.CornflowerBlue;
                this.Refresh();
                blueSound.Play();
                Thread.Sleep(250);
                blueButton.BackColor = Color.DarkBlue;
                this.Refresh();
                currentGuess++;
                if (currentGuess >= Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }
    }
}
