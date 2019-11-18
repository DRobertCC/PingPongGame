namespace PingPongGame
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.difficultyMenu_Label = new System.Windows.Forms.Label();
            this.topScore_Label = new System.Windows.Forms.Label();
            this.pause_Label = new System.Windows.Forms.Label();
            this.mainMenu_Label = new System.Windows.Forms.Label();
            this.menu_Label = new System.Windows.Forms.Label();
            this.difficultyLevel_Label = new System.Windows.Forms.Label();
            this.score_Label = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new OvalPictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.difficultyMenu_Label);
            this.playground.Controls.Add(this.topScore_Label);
            this.playground.Controls.Add(this.pause_Label);
            this.playground.Controls.Add(this.mainMenu_Label);
            this.playground.Controls.Add(this.menu_Label);
            this.playground.Controls.Add(this.difficultyLevel_Label);
            this.playground.Controls.Add(this.score_Label);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1262, 673);
            this.playground.TabIndex = 0;
            // 
            // difficultyMenu_Label
            // 
            this.difficultyMenu_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyMenu_Label.AutoSize = true;
            this.difficultyMenu_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyMenu_Label.Location = new System.Drawing.Point(415, 82);
            this.difficultyMenu_Label.Name = "difficultyMenu_Label";
            this.difficultyMenu_Label.Size = new System.Drawing.Size(419, 402);
            this.difficultyMenu_Label.TabIndex = 7;
            this.difficultyMenu_Label.Text = "Choose Difficulty\r\n\r\n1 - Easy\r\n2 - Medium\r\n3 - Hard\r\nESC - Quit Game";
            this.difficultyMenu_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topScore_Label
            // 
            this.topScore_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topScore_Label.AutoSize = true;
            this.topScore_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topScore_Label.Location = new System.Drawing.Point(1192, 597);
            this.topScore_Label.Name = "topScore_Label";
            this.topScore_Label.Size = new System.Drawing.Size(58, 67);
            this.topScore_Label.TabIndex = 4;
            this.topScore_Label.Text = "0";
            this.topScore_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pause_Label
            // 
            this.pause_Label.AutoSize = true;
            this.pause_Label.BackColor = System.Drawing.Color.Transparent;
            this.pause_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_Label.Location = new System.Drawing.Point(113, 44);
            this.pause_Label.Name = "pause_Label";
            this.pause_Label.Size = new System.Drawing.Size(316, 67);
            this.pause_Label.TabIndex = 6;
            this.pause_Label.Text = "Game Paused";
            this.pause_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu_Label
            // 
            this.mainMenu_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainMenu_Label.AutoSize = true;
            this.mainMenu_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu_Label.Location = new System.Drawing.Point(-12, 178);
            this.mainMenu_Label.Name = "mainMenu_Label";
            this.mainMenu_Label.Size = new System.Drawing.Size(501, 268);
            this.mainMenu_Label.TabIndex = 5;
            this.mainMenu_Label.Text = "Welcome to Pong\r\n\r\nF1 - Start New Game\r\nESC - Quit Game\r\n";
            this.mainMenu_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_Label
            // 
            this.menu_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu_Label.AutoSize = true;
            this.menu_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Label.Location = new System.Drawing.Point(777, 149);
            this.menu_Label.Name = "menu_Label";
            this.menu_Label.Size = new System.Drawing.Size(501, 268);
            this.menu_Label.TabIndex = 5;
            this.menu_Label.Text = "Game Over\r\n\r\nF1 - Start New Game\r\nESC - Quit Game\r\n";
            this.menu_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyLevel_Label
            // 
            this.difficultyLevel_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyLevel_Label.AutoSize = true;
            this.difficultyLevel_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevel_Label.Location = new System.Drawing.Point(489, 597);
            this.difficultyLevel_Label.Name = "difficultyLevel_Label";
            this.difficultyLevel_Label.Size = new System.Drawing.Size(321, 67);
            this.difficultyLevel_Label.TabIndex = 3;
            this.difficultyLevel_Label.Text = "MediumGame";
            this.difficultyLevel_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_Label
            // 
            this.score_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.score_Label.AutoSize = true;
            this.score_Label.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_Label.Location = new System.Drawing.Point(12, 597);
            this.score_Label.Name = "score_Label";
            this.score_Label.Size = new System.Drawing.Size(189, 67);
            this.score_Label.TabIndex = 3;
            this.score_Label.Text = "Score: ";
            this.score_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Red;
            this.racket.Location = new System.Drawing.Point(540, 536);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 25);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(445, 531);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox racket;
        private OvalPictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_Label;
        private System.Windows.Forms.Label menu_Label;
        private System.Windows.Forms.Label pause_Label;
        private System.Windows.Forms.Label topScore_Label;
        private System.Windows.Forms.Label difficultyMenu_Label;
        private System.Windows.Forms.Label mainMenu_Label;
        private System.Windows.Forms.Label difficultyLevel_Label;
    }
}

