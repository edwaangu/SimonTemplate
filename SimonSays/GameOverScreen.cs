using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            String thereS = Form1.pattern.Count == 2 ? "" : "s";
            patternLabel.Text = $"You passed {(Form1.pattern.Count - 1)} round{thereS}";
            highscoresLabel.Text = updateHighscoreText();
            highscoresSort();
            //TODO: show the length of the pattern
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            // Remove the current screen
            Form f = FindForm();
            f.Controls.Remove(this);

            // Replace it with the main screen
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            //TODO: close this screen and open the MenuScreen
        }

        private void addScoreButton_Click(object sender, EventArgs e)
        {
            if (Form1.highscoreNames.IndexOf(addScoreBox.Text) != -1)
            {
                if (Form1.highscores[Form1.highscoreNames.IndexOf(addScoreBox.Text)] < (Form1.pattern.Count - 1))
                {
                    Form1.highscores[Form1.highscoreNames.IndexOf(addScoreBox.Text)] = (Form1.pattern.Count - 1);
                }
            }
            else if(addScoreBox.Text != "")
            {
                Form1.highscoreNames.Add($"{addScoreBox.Text}");
                Form1.highscores.Add(Form1.pattern.Count - 1);
                highscoresSort();
                highscoresLabel.Text = updateHighscoreText();
            }
        }

        string updateHighscoreText()
        {
            string curText = "";

            for(int i = 0; i < Form1.highscores.Count; i++)
            {
                curText += $"{Form1.highscores[i]} - {Form1.highscoreNames[i]}\n";
            }

            return curText;
        }

        void highscoresSort()
        {
            if(Form1.highscores.Count == 0 || Form1.highscores.Count == 1)
            {
                return;
            }
            else{
                List<string> tempScoreNames = new List<string>();
                List<int> tempScores = new List<int>();
                for(int i = 0;i < Form1.highscores.Count;i++)
                {
                    tempScoreNames.Add(Form1.highscoreNames[i]);
                    tempScores.Add(Form1.highscores[i]);
                }
                Form1.highscoreNames.Clear();
                Form1.highscores.Sort();
                Form1.highscores.Reverse();

                for(int i = 0;i < tempScoreNames.Count;i++)
                {
                    Form1.highscoreNames.Add("");
                }

                for(int i = 0;i < tempScores.Count;i++)
                {
                    for(int j = 0;j < Form1.highscores.Count;j++)
                    {
                        if(tempScores[i] == Form1.highscores[j])
                        {
                            Form1.highscoreNames[j] = tempScoreNames[i];
                        }
                    }
                }

                if(Form1.highscores.Count > 5)
                {
                    Form1.highscores.RemoveAt(5);
                    Form1.highscoreNames.RemoveAt(5);
                }
            }
        }
    }
}
