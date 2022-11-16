namespace T_Rex_Running
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtPressSpace = new System.Windows.Forms.Label();
            this.pbxReplay = new System.Windows.Forms.PictureBox();
            this.t_rex = new System.Windows.Forms.PictureBox();
            this.pbxGround = new System.Windows.Forms.PictureBox();
            this.pbxCactus_1 = new System.Windows.Forms.PictureBox();
            this.pbxCactus_2 = new System.Windows.Forms.PictureBox();
            this.pbxChim = new System.Windows.Forms.PictureBox();
            this.pbxCloud_2 = new System.Windows.Forms.PictureBox();
            this.pbxCloud_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_rex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCactus_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCactus_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCloud_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCloud_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 44);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(79, 23);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(316, 202);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(149, 32);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 50;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimerEvent);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(12, 9);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(125, 23);
            this.txtHighScore.TabIndex = 7;
            this.txtHighScore.Text = "High Score: 0";
            // 
            // txtPressSpace
            // 
            this.txtPressSpace.AutoSize = true;
            this.txtPressSpace.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPressSpace.Location = new System.Drawing.Point(259, 185);
            this.txtPressSpace.Name = "txtPressSpace";
            this.txtPressSpace.Size = new System.Drawing.Size(299, 32);
            this.txtPressSpace.TabIndex = 8;
            this.txtPressSpace.Text = "Press Space To Play";
            // 
            // pbxReplay
            // 
            this.pbxReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxReplay.Image = global::T_Rex_Running.Properties.Resources.replay;
            this.pbxReplay.Location = new System.Drawing.Point(368, 237);
            this.pbxReplay.Name = "pbxReplay";
            this.pbxReplay.Size = new System.Drawing.Size(35, 30);
            this.pbxReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxReplay.TabIndex = 9;
            this.pbxReplay.TabStop = false;
            this.pbxReplay.Visible = false;
            this.pbxReplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxReplay_MouseClick);
            // 
            // t_rex
            // 
            this.t_rex.BackColor = System.Drawing.Color.Transparent;
            this.t_rex.Image = global::T_Rex_Running.Properties.Resources.running;
            this.t_rex.Location = new System.Drawing.Point(133, 378);
            this.t_rex.Name = "t_rex";
            this.t_rex.Size = new System.Drawing.Size(40, 43);
            this.t_rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.t_rex.TabIndex = 3;
            this.t_rex.TabStop = false;
            // 
            // pbxGround
            // 
            this.pbxGround.BackColor = System.Drawing.Color.Black;
            this.pbxGround.Location = new System.Drawing.Point(-9, 421);
            this.pbxGround.Name = "pbxGround";
            this.pbxGround.Size = new System.Drawing.Size(818, 47);
            this.pbxGround.TabIndex = 0;
            this.pbxGround.TabStop = false;
            // 
            // pbxCactus_1
            // 
            this.pbxCactus_1.BackColor = System.Drawing.Color.Transparent;
            this.pbxCactus_1.Image = global::T_Rex_Running.Properties.Resources.obstacle_1;
            this.pbxCactus_1.Location = new System.Drawing.Point(535, 375);
            this.pbxCactus_1.Name = "pbxCactus_1";
            this.pbxCactus_1.Size = new System.Drawing.Size(23, 46);
            this.pbxCactus_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCactus_1.TabIndex = 3;
            this.pbxCactus_1.TabStop = false;
            this.pbxCactus_1.Tag = "obstacle";
            // 
            // pbxCactus_2
            // 
            this.pbxCactus_2.BackColor = System.Drawing.Color.Transparent;
            this.pbxCactus_2.Image = global::T_Rex_Running.Properties.Resources.obstacle_2;
            this.pbxCactus_2.Location = new System.Drawing.Point(663, 388);
            this.pbxCactus_2.Name = "pbxCactus_2";
            this.pbxCactus_2.Size = new System.Drawing.Size(32, 33);
            this.pbxCactus_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCactus_2.TabIndex = 3;
            this.pbxCactus_2.TabStop = false;
            this.pbxCactus_2.Tag = "obstacle";
            // 
            // pbxChim
            // 
            this.pbxChim.Image = global::T_Rex_Running.Properties.Resources.chim;
            this.pbxChim.Location = new System.Drawing.Point(753, 363);
            this.pbxChim.Name = "pbxChim";
            this.pbxChim.Size = new System.Drawing.Size(35, 29);
            this.pbxChim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxChim.TabIndex = 6;
            this.pbxChim.TabStop = false;
            this.pbxChim.Tag = "obstacle";
            // 
            // pbxCloud_2
            // 
            this.pbxCloud_2.Image = global::T_Rex_Running.Properties.Resources.blue_cloud;
            this.pbxCloud_2.Location = new System.Drawing.Point(454, 303);
            this.pbxCloud_2.Name = "pbxCloud_2";
            this.pbxCloud_2.Size = new System.Drawing.Size(68, 26);
            this.pbxCloud_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCloud_2.TabIndex = 5;
            this.pbxCloud_2.TabStop = false;
            this.pbxCloud_2.Tag = "object";
            // 
            // pbxCloud_1
            // 
            this.pbxCloud_1.Image = ((System.Drawing.Image)(resources.GetObject("pbxCloud_1.Image")));
            this.pbxCloud_1.Location = new System.Drawing.Point(322, 345);
            this.pbxCloud_1.Name = "pbxCloud_1";
            this.pbxCloud_1.Size = new System.Drawing.Size(55, 25);
            this.pbxCloud_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxCloud_1.TabIndex = 5;
            this.pbxCloud_1.TabStop = false;
            this.pbxCloud_1.Tag = "object";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxReplay);
            this.Controls.Add(this.txtPressSpace);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.t_rex);
            this.Controls.Add(this.pbxGround);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pbxCactus_1);
            this.Controls.Add(this.pbxCactus_2);
            this.Controls.Add(this.pbxChim);
            this.Controls.Add(this.pbxCloud_2);
            this.Controls.Add(this.pbxCloud_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex Running";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyIsPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_rex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCactus_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCactus_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCloud_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCloud_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGround;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox t_rex;
        private System.Windows.Forms.PictureBox pbxCactus_1;
        private System.Windows.Forms.PictureBox pbxCactus_2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox pbxCloud_1;
        private System.Windows.Forms.PictureBox pbxCloud_2;
        private System.Windows.Forms.PictureBox pbxChim;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtPressSpace;
        private System.Windows.Forms.PictureBox pbxReplay;
    }
}

