using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        public int ballSpeedX; // horizontal movement direction & speed of the ball (-:left, +: right) 
        public int ballSpeedY;  // vertical movement direction & speed of the ball (-: upward, +: down)
        public int width;   // width of the playfield
        public int height;     // height of the playfield

        public int racketInitialWith;

        public int fasterperNhit;
        public float racketWidthShrinkMultiplier = 1; // default = 1

        public Random r = new Random();

        public int scores = 0;
        public int topScore = 0;
        public int topScoreE = 0;
        public int topScoreM = 0;
        public int topScoreH = 0;

        int round;

    // Constructor
        public Form1()
        {
            InitializeComponent();

            Cursor.Hide();
            //this.TopMost = true;    // Always on top
            this.FormBorderStyle = FormBorderStyle.None;  // No Border & Header bar
            this.Bounds = Screen.PrimaryScreen.Bounds;  // Fullscreen

            width = playground.Width;
            height = playground.Height;
            Console.WriteLine(width + " : " + height);

            racketInitialWith = (width / 4);

            racket.Top = playground.Bottom - (playground.Bottom / 10);  // Racket always on the bottom of the screen

            score_Label.Visible = false;
            topScore_Label.Visible = false;
            racket.Visible = false;
            ball.Visible = false;

            mainMenu_Label.Left = (width / 2) - (mainMenu_Label.Width / 2);
            mainMenu_Label.Top = (height / 2) - (mainMenu_Label.Height / 2);
            mainMenu_Label.Visible = true;

            difficultyMenu_Label.Left = (width / 2) - (difficultyMenu_Label.Width / 2);
            difficultyMenu_Label.Top = (height / 2) - (difficultyMenu_Label.Height / 2);
            difficultyMenu_Label.Visible = false;

            menu_Label.Left = (width / 2) - (menu_Label.Width / 2);
            menu_Label.Top = (height / 2) - (menu_Label.Height / 2);
            menu_Label.Visible = false;

            pause_Label.Left = (width / 2) - (pause_Label.Width / 2);
            pause_Label.Top = (height / 2) - (pause_Label.Height / 2);
            pause_Label.Visible = false;

            difficultyLevel_Label.Left = (width / 2) - (difficultyLevel_Label.Width / 2);
            difficultyLevel_Label.Top = height - (height / 13);
            difficultyLevel_Label.Visible = false;

            score_Label.Left = width / 75;
            score_Label.Top = height - (height / 13);
            topScore_Label.Left = width - (width / 5);
            topScore_Label.Top = height - (height / 13);

            ballSpeedX = r.Next(-4, 4);    // horizontal movement direction of the ball
            ballSpeedY = r.Next(3, 4);    // vertical movement direction of the ball

            ball.Top = r.Next(50, height - (height / 2)); // Initial Y-position of the ball 
            ball.Left = r.Next(50, width - 50); // Initial X-position of the ball
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2); // Set the center of the racket to the position of the cursor
            ball.Left += ballSpeedX; //Move the ball
            ball.Top += ballSpeedY;

        // Racket collision
            if (ball.Bottom >= racket.Top && /*ball.Bottom <= racket.Bottom && */ball.Left <= racket.Right && ball.Right >= racket.Left)
            // orig:
          //if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                // Ball is getting faster after every N hits and the racket smaller if certain level choosen
                if (++round % fasterperNhit == 0)
                {
                    ballSpeedY++;
                    ballSpeedX++;
                    racket.Width = (int)(racket.Width * racketWidthShrinkMultiplier);
                }
                ballSpeedY = -ballSpeedY; // Change direction
                scores += 1;
                score_Label.Text = "Score: " + scores.ToString();

                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255)); // Get a random dark RGB Color
            }

        // Direction changes when ball reaches playgrounds borders
            if (ball.Left <= playground.Left)
            {
                ballSpeedX = -ballSpeedX;
            }

            if (ball.Right >= playground.Right)
            {
                ballSpeedX = -ballSpeedX;
            }

            if (ball.Top <= playground.Top)
            {
                ballSpeedY = -ballSpeedY;
            }
        // in case of Game over
            if (ball.Bottom >= playground.Bottom) 
            {
                timer1.Enabled = false;
                menu_Label.Visible = true;

                switch (difficultyLevel_Label.Text)
                {
                    case "Easy Game":
                        if (scores > topScoreE)
                        {
                            topScoreE = scores;
                            topScore_Label.Text = "Top Score: " + topScoreE.ToString();
                            //topScoreVar_Label.Text = (Convert.ToInt32(topScoreVar_Label.Text) < scores) ? scores.ToString() : topScoreVar_Label.Text;
                            topScore_Label.Visible = true;
                        }
                        break;
                    case "Medium Game":
                        if (scores > topScoreM)
                        {
                            topScoreM = scores;
                            topScore_Label.Text = "Top Score: " + topScoreM.ToString();
                            topScore_Label.Visible = true;
                        }
                        break;
                    case "Hard Game":
                        if (scores > topScoreH)
                        {
                            topScoreH = scores;
                            topScore_Label.Text = "Top Score: " + topScoreH.ToString();
                            topScore_Label.Visible = true;
                        }
                        break;
                }

                //if (Convert.ToInt32(topScoreVar_Label.Text) < scores)
                //{
                //    topScoreVar_Label.Text = topScore.ToString();
                //}
                ////topScoreVar_Label.Text = (Convert.ToInt32(topScoreVar_Label.Text) < scores) ? scores.ToString() : topScoreVar_Label.Text;

                //if (scores > 0)
                //{
                //    topScore_Label.Visible = true;
                //    topScoreVar_Label.Visible = true;
                //}
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
        // ESC button pressed
            if (e.KeyCode == Keys.Escape) 
            {
                Cursor.Show();
                timer1.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "What!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
                if (!menu_Label.Visible && !pause_Label.Visible && !difficultyMenu_Label.Visible && !mainMenu_Label.Visible)
                {
                    timer1.Enabled = true;
                    Cursor.Hide();
                }
                Cursor.Hide();
            }
        // Pause game
            if (e.KeyCode == Keys.Space && !menu_Label.Visible && !difficultyMenu_Label.Visible && !mainMenu_Label.Visible)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    pause_Label.Visible = true;
                }
                else
                {
                    timer1.Enabled = true;
                    pause_Label.Visible = false;

                }
            }
        // Start game
            if (e.KeyCode == Keys.F1 && mainMenu_Label.Visible)
            {
                mainMenu_Label.Visible = false;
                difficultyMenu_Label.Visible = true;

            }
        // Restart game
            if (e.KeyCode == Keys.F1 && !pause_Label.Visible)
            {
                timer1.Enabled = false;
                menu_Label.Visible = false;
                difficultyMenu_Label.Visible = true;

            }
        // Easy game
            if (e.KeyCode == Keys.D1 && !pause_Label.Visible && difficultyMenu_Label.Visible)
            {
                topScore = topScoreE;
                ResetGame(racketInitialWith, 5, "Easy Game");
                racketWidthShrinkMultiplier = 1;
            }
            // Medium game
            if (e.KeyCode == Keys.D2 && !pause_Label.Visible && difficultyMenu_Label.Visible)
            {
                topScore = topScoreM;
                ResetGame((racketInitialWith / 2), 5, "Medium Game");
                racketWidthShrinkMultiplier = 1;
            }
            // Hard game
            if (e.KeyCode == Keys.D3 && !pause_Label.Visible && difficultyMenu_Label.Visible)
            {
                topScore = topScoreH;
                ResetGame(racketInitialWith, 10, "Hard Game");
                racketWidthShrinkMultiplier = 0.9f;
            }
        }

        private void ResetGame(int racketWidhtP, int fasterperNhitP, string difficulty)
        {
            Cursor.Hide();
            ball.Top = r.Next(50, height - (height / 2)); // Y(Vertical)-position of the ball 
            ball.Left = r.Next(50, width - 50); // X(Horizontal)-position of the ball
            ballSpeedX = r.Next(-4, 4);   // horizontal movement direction & speed of the ball (-:left, +: right) 
            ballSpeedY = r.Next(3, 5);  // vertical movement direction & speed of the ball (-: upward, +: down)
            scores = 0;
            round = 0;
            racket.Visible = true;
            ball.Visible = true;
            score_Label.Visible = true;
            racket.Width = racketWidhtP;
            fasterperNhit = fasterperNhitP;
            difficultyLevel_Label.Text = difficulty;
            score_Label.Text = "Score: 0";
            menu_Label.Visible = false;
            difficultyMenu_Label.Visible = false;
            difficultyLevel_Label.Visible = true;

            if (topScore > 0)
            {
                topScore_Label.Text = "Top Score: " + topScore.ToString();
                topScore_Label.Left = width - (width / 5);
                topScore_Label.Visible = true;
            }
            else
            {
                topScore_Label.Visible = false;
            }
            timer1.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //racket.Top = playground.Bottom - (playground.Bottom / 10);  // Racket always on the bottom of the screen
        }

    }
}
