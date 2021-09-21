namespace SimonSays
{
    partial class GameOverScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.highscoresLabel = new System.Windows.Forms.Label();
            this.addScoreBox = new System.Windows.Forms.TextBox();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.White;
            this.gameOverLabel.Location = new System.Drawing.Point(50, 13);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(300, 54);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "Game Over";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patternLabel
            // 
            this.patternLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternLabel.ForeColor = System.Drawing.Color.White;
            this.patternLabel.Location = new System.Drawing.Point(50, 67);
            this.patternLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(300, 50);
            this.patternLabel.TabIndex = 1;
            this.patternLabel.Text = "You passed ## rounds";
            this.patternLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(152, 128);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 40);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Menu";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // highscoresLabel
            // 
            this.highscoresLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoresLabel.ForeColor = System.Drawing.Color.White;
            this.highscoresLabel.Location = new System.Drawing.Point(50, 242);
            this.highscoresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highscoresLabel.Name = "highscoresLabel";
            this.highscoresLabel.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.highscoresLabel.Size = new System.Drawing.Size(300, 129);
            this.highscoresLabel.TabIndex = 4;
            this.highscoresLabel.Text = "Highscores:\r\n\r\n1500 - A\r\n50 - Yeah\r\n1 - Ack\r\n";
            // 
            // addScoreBox
            // 
            this.addScoreBox.Location = new System.Drawing.Point(103, 192);
            this.addScoreBox.Name = "addScoreBox";
            this.addScoreBox.Size = new System.Drawing.Size(100, 20);
            this.addScoreBox.TabIndex = 5;
            // 
            // addScoreButton
            // 
            this.addScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addScoreButton.ForeColor = System.Drawing.Color.White;
            this.addScoreButton.Location = new System.Drawing.Point(208, 189);
            this.addScoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(100, 28);
            this.addScoreButton.TabIndex = 6;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            this.addScoreButton.Click += new System.EventHandler(this.addScoreButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.addScoreBox);
            this.Controls.Add(this.highscoresLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label highscoresLabel;
        private System.Windows.Forms.TextBox addScoreBox;
        private System.Windows.Forms.Button addScoreButton;
    }
}
