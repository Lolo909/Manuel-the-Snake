
namespace Змията_игра_1._0
{
    partial class HardDifficultyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardDifficultyForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.counterOfDoritos = new System.Windows.Forms.Label();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.the_moving_snake = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hat = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cactus2 = new System.Windows.Forms.PictureBox();
            this.cactus3 = new System.Windows.Forms.PictureBox();
            this.cactus5 = new System.Windows.Forms.PictureBox();
            this.cactus4 = new System.Windows.Forms.PictureBox();
            this.cactus1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_moving_snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 198);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.label2.Location = new System.Drawing.Point(23, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 59);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doritos:";
            // 
            // counterOfDoritos
            // 
            this.counterOfDoritos.BackColor = System.Drawing.SystemColors.Window;
            this.counterOfDoritos.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.counterOfDoritos.Location = new System.Drawing.Point(32, 255);
            this.counterOfDoritos.Name = "counterOfDoritos";
            this.counterOfDoritos.Size = new System.Drawing.Size(132, 65);
            this.counterOfDoritos.TabIndex = 30;
            this.counterOfDoritos.Text = "0";
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // the_moving_snake
            // 
            this.the_moving_snake.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.the_moving_snake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("the_moving_snake.BackgroundImage")));
            this.the_moving_snake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.the_moving_snake.Location = new System.Drawing.Point(628, 221);
            this.the_moving_snake.Name = "the_moving_snake";
            this.the_moving_snake.Size = new System.Drawing.Size(43, 44);
            this.the_moving_snake.TabIndex = 1;
            this.the_moving_snake.TabStop = false;
            this.the_moving_snake.Paint += new System.Windows.Forms.PaintEventHandler(this.the_moving_snake_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(199, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(492, 23);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(199, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(492, 24);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox5.Location = new System.Drawing.Point(199, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 463);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox6.Location = new System.Drawing.Point(670, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 468);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.Location = new System.Drawing.Point(221, 456);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(443, 19);
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(661, 35);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 423);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(222, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 423);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // hat
            // 
            this.hat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hat.BackgroundImage")));
            this.hat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hat.Location = new System.Drawing.Point(230, 221);
            this.hat.Name = "hat";
            this.hat.Size = new System.Drawing.Size(43, 44);
            this.hat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hat.TabIndex = 38;
            this.hat.TabStop = false;
            this.hat.Tag = "Enemy";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox9.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(13, 522);
            this.pictureBox9.TabIndex = 39;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox10.Location = new System.Drawing.Point(1136, -1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(14, 522);
            this.pictureBox10.TabIndex = 40;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox11.Location = new System.Drawing.Point(-5, 514);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(1149, 16);
            this.pictureBox11.TabIndex = 41;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox12.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(1149, 10);
            this.pictureBox12.TabIndex = 42;
            this.pictureBox12.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            // 
            // cactus2
            // 
            this.cactus2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cactus2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cactus2.BackgroundImage")));
            this.cactus2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cactus2.Location = new System.Drawing.Point(535, 90);
            this.cactus2.Name = "cactus2";
            this.cactus2.Size = new System.Drawing.Size(43, 44);
            this.cactus2.TabIndex = 49;
            this.cactus2.TabStop = false;
            this.cactus2.Paint += new System.Windows.Forms.PaintEventHandler(this.cactus2_Paint);
            // 
            // cactus3
            // 
            this.cactus3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cactus3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cactus3.BackgroundImage")));
            this.cactus3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cactus3.Location = new System.Drawing.Point(430, 221);
            this.cactus3.Name = "cactus3";
            this.cactus3.Size = new System.Drawing.Size(43, 44);
            this.cactus3.TabIndex = 50;
            this.cactus3.TabStop = false;
            this.cactus3.Paint += new System.Windows.Forms.PaintEventHandler(this.cactus3_Paint);
            // 
            // cactus5
            // 
            this.cactus5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cactus5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cactus5.BackgroundImage")));
            this.cactus5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cactus5.Location = new System.Drawing.Point(535, 351);
            this.cactus5.Name = "cactus5";
            this.cactus5.Size = new System.Drawing.Size(43, 44);
            this.cactus5.TabIndex = 51;
            this.cactus5.TabStop = false;
            this.cactus5.Paint += new System.Windows.Forms.PaintEventHandler(this.cactus5_Paint);
            // 
            // cactus4
            // 
            this.cactus4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cactus4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cactus4.BackgroundImage")));
            this.cactus4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cactus4.Location = new System.Drawing.Point(320, 351);
            this.cactus4.Name = "cactus4";
            this.cactus4.Size = new System.Drawing.Size(43, 44);
            this.cactus4.TabIndex = 52;
            this.cactus4.TabStop = false;
            this.cactus4.Paint += new System.Windows.Forms.PaintEventHandler(this.cactus4_Paint);
            // 
            // cactus1
            // 
            this.cactus1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cactus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cactus1.BackgroundImage")));
            this.cactus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cactus1.Location = new System.Drawing.Point(320, 90);
            this.cactus1.Name = "cactus1";
            this.cactus1.Size = new System.Drawing.Size(43, 44);
            this.cactus1.TabIndex = 53;
            this.cactus1.TabStop = false;
            this.cactus1.Paint += new System.Windows.Forms.PaintEventHandler(this.cactus1_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(764, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 37);
            this.label3.TabIndex = 54;
            this.label3.Text = "0 sec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 50F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(731, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 91);
            this.label4.TabIndex = 55;
            this.label4.Text = "Snake game";
            // 
            // HardDifficultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1143, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cactus1);
            this.Controls.Add(this.cactus4);
            this.Controls.Add(this.cactus5);
            this.Controls.Add(this.cactus3);
            this.Controls.Add(this.cactus2);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.the_moving_snake);
            this.Controls.Add(this.counterOfDoritos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HardDifficultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manuel the Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_moving_snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counterOfDoritos;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox the_moving_snake;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox hat;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox cactus2;
        private System.Windows.Forms.PictureBox cactus3;
        private System.Windows.Forms.PictureBox cactus5;
        private System.Windows.Forms.PictureBox cactus4;
        private System.Windows.Forms.PictureBox cactus1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
    }
}

