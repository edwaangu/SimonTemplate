using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();
        public static List<string> highscoreNames = new List<string>();
        public static List<int> highscores = new List<int>();

        public static string difficulty = "Easy";

        // TODO: Add highscores in GameOverScreen

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }
    }
}
