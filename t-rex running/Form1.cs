using System;
using System.Media;
using System.Windows.Forms;

namespace T_Rex_Running
{
    public partial class Form1 : Form
    {
        private bool jumping = false;
        private int jumpSpeed = 12;
        private int force = 12;
        private int score = 0;
        private int highScore = 0;
        private int obstacleSpeed = 10;
        private Random random = new Random();
        private bool gameStart = false;
        private bool gameOver = false;
        private bool rolling = false;
        private SoundPlayer jumpSound = new SoundPlayer(@"jump_sound.wav");

        public Form1()
        {
            InitializeComponent();

            gameReset();
        }

        //sự kiện thời gian chính của game
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            t_rex.Top += jumpSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            //điều chỉnh vị trí của t-rex
            if (t_rex.Top >= 378 && !jumping)
            {
                force = 12;
                if (rolling) t_rex.Top = 396;
                else t_rex.Top = 378;
                jumpSpeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    //thay đổi vị trí của chướng ngại vật
                    x.Left -= obstacleSpeed;

                    //nếu obstacle đã ra khỏi màn hình thì khởi tạo lại vị trí
                    if (x.Left < 0)
                    {
                        if (x is PictureBox && (string)x.Name == "pbxCactus_1")
                            x.Left = this.ClientSize.Width + random.Next(1600, 1800);

                        if (x is PictureBox && (string)x.Name == "pbxCactus_2")
                            x.Left = this.ClientSize.Width + random.Next(1000, 1200);

                        if (x is PictureBox && (string)x.Name == "pbxChim")
                            x.Left = this.ClientSize.Width + random.Next(100, 300);
                    }

                    //dừng game khi người chơi chạm chướng ngại vật
                    if (t_rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        scoreTimer.Stop();
                        if (rolling) t_rex.Top = 378;
                        t_rex.Image = Properties.Resources.dead;
                        txtScore.Text += "\nPress R to play again !";
                        lblGameOver.Visible = true;
                        pbxReplay.Visible = true;
                        gameOver = true;
                    }
                }

                //khởi tạo vị trí cho object(mây)
                if (x is PictureBox && (string)x.Tag == "object")
                {
                    x.Left -= 3;
                    if (x.Left < 0)
                        x.Left = this.ClientSize.Width + random.Next(0, 50);
                }
            }
        }

        //hàm bắt đầu game lại từ đầu
        private void gameReset()
        {
            //lưu điểm cao nhất
            if (highScore < score)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + highScore;
            }

            //gán các biến lại giá trị ban đầu
            txtScore.Text = "Score: " + score;
            jumping = false;
            rolling = false;
            jumpSpeed = 12;
            force = 12;
            score = 0;
            obstacleSpeed = 10;
            t_rex.Image = Properties.Resources.running;
            gameOver = false;
            t_rex.Top = 378;
            lblGameOver.Visible = false;
            pbxReplay.Visible = false;

            //khởi tạo vị trí cho obstacle(chướng ngại vật)
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    if (x is PictureBox && (string)x.Name == "pbxCactus_1")
                        x.Left = this.ClientSize.Width + random.Next(100, 300);

                    if (x is PictureBox && (string)x.Name == "pbxCactus_2")
                        x.Left = this.ClientSize.Width + random.Next(500, 700);

                    if (x is PictureBox && (string)x.Name == "pbxChim")
                        x.Left = this.ClientSize.Width + random.Next(900, 1100);
                }
            }

            //khi bắt đầu game, Timer của game sẽ khởi động
            if (gameStart)
            {
                gameTimer.Start();
                scoreTimer.Start();
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //đè phím Space hoặc phím ↑ để nhảy
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up && !jumping)
            {
                jumping = true;
            }
            //đè phím ↓ để cúi xuống
            if (e.KeyCode == Keys.Down && !rolling && !gameOver && gameStart)
            {
                rolling = true;
                t_rex.Image = Properties.Resources.rolling;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //nhả phím Space hoặc phím ↑ để hủy nhảy
            if (jumping)
            {
                jumping = false;
            }
            //nhả phím ↓ để hủy cúi xuống
            if (e.KeyCode == Keys.Down && rolling && !gameOver)
            {
                rolling = false;
                t_rex.Image = Properties.Resources.running;
            }
            //nhấn phím R để reset game khi game over
            if (e.KeyCode == Keys.R && gameOver)
            {
                gameReset();
            }
            //nhấn Space để bắt đầu game
            if (e.KeyCode == Keys.Space && !gameStart)
            {
                gameStart = true;
                txtPressSpace.Visible = false;
                gameReset();
            }
        }

        private void keyIsPress(object sender, KeyPressEventArgs e)
        {
            //Khi t-rex nhảy lên sẽ có âm thanh
            if (e.KeyChar == 32 || e.KeyChar == 38)
            {
                if (!gameOver && t_rex.Top == 378)
                    jumpSound.Play();
            }
        }

        //sự kiện điểm của game
        private void scoreTimerEvent(object sender, EventArgs e)
        {
            score++;
            //khi điểm là bội số của 500 thì tăng tốc độ của chướng ngại vật
            if (score % 500 == 0)
            {
                obstacleSpeed += 5;
            }
        }

        //sự kiên click chuột để reset game
        private void pbxReplay_MouseClick(object sender, MouseEventArgs e)
        {
            gameReset();
        }
    }
}