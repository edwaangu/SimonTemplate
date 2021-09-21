using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // Remove the current screen
            Form f = FindForm();
            f.Controls.Remove(this);

            // Replace it with the game screen
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            buttonPath.AddEllipse(0, 0, 380, 380);
            Region buttonRegion = new Region(buttonPath);
            GraphicsPath excludePath = new GraphicsPath();
            excludePath.AddEllipse(190 - 72, 190 - 72, 145, 145);
            buttonRegion.Exclude(excludePath);
            newButton.Region = buttonRegion;

            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt(90, new PointF(95, 95));

            buttonRegion.Transform(transformMatrix);
            exitButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(95, 95));

            buttonRegion.Transform(transformMatrix);
            difficultyButton.Region = buttonRegion;
            difficultyButton.Text = $"Difficulty:\n{Form1.difficulty}";
        }

        private void difficultyButton_Click(object sender, EventArgs e)
        {
            Form1.difficulty = Form1.difficulty == "Easy" ? "Hard" : "Easy";
            difficultyButton.Text = $"Difficulty:\n{Form1.difficulty}";
        }
    }
}
