using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Змията_игра_1._0
{
    public partial class EasyDifficultyForm : Form


    {
        private int maracaSpeed = 2;



        private int hatWigth = 30;
        private int hatHight = 30;
        private int hatPosX = 230;
        private int hatPosY = 221;
        private int moveStepX = 2;
        private int moveStepY = 2;

        private bool GAMEOVER = false;
        
        int doritoCounter = 0;
        bool isThereDorito = false;
        bool moveRight, moveLeft, moveUp, moveDown;
        int speed = 6;
        int spawnTime = 20;
        List<PictureBox> items = new List<PictureBox>();
        ImageList listForD = new ImageList();

        List<PictureBox> itemsM = new List<PictureBox>();
        ImageList listForM = new ImageList();
        
        Random rand = new Random();
        int x, y;

      

        public static EasyDifficultyForm easyDifficultyFormInstance;
        public Label lbl;
        public Label lblTime;

        PictureBox MakenMaraca = new PictureBox();       


        //https://www.youtube.com/watch?v=o5udkxIN7kM
        public EasyDifficultyForm()
        {
            InitializeComponent();
            easyDifficultyFormInstance = this;
            lbl = counterOfDoritos;
            lblTime = label3;
            timer2.Start();
        }
        
        
        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft==true && the_moving_snake.Left > 221)
            {
                the_moving_snake.Left -= speed;
            }
            if (moveRight == true && the_moving_snake.Left < 627)
            {
                the_moving_snake.Left += speed;
            }

            if (moveUp == true && the_moving_snake.Top > 36)
            {
                the_moving_snake.Top -= speed;
            }
            if (moveDown == true && the_moving_snake.Top < 408)
            {
                the_moving_snake.Top += speed;
            }


            



            counterOfDoritos.Text = doritoCounter.ToString();
            
            if (doritoCounter == 22 && GAMEOVER==false)
            {
                GAMEOVER = true;
                timer2.Stop();
                this.Hide();
                GoodEndingForm f5 = new GoodEndingForm();
                f5.ShowDialog();
                
            }
            
            
            spawnTime -= 1;

            if (spawnTime<1 && !isThereDorito)
            {
                MakePicterBox();
                spawnTime = 20;
            }

            foreach (PictureBox item in items.ToList())
            {
                if (the_moving_snake.Bounds.IntersectsWith(item.Bounds))
                {
                    this.Controls.Remove(MakenMaraca);
                    itemsM.Remove(MakenMaraca);

                   
                    doritoCounter++;                   
                    items.Remove(item);
                    this.Controls.Remove(item);
                    isThereDorito = false;

                    MakenMaraca = MakeMaraca();
                }
            }
            //bonus for hard mod
            foreach (PictureBox item in itemsM.ToList())
            {
                if (the_moving_snake.Bounds.IntersectsWith(item.Bounds) && GAMEOVER == false)
                {
                    GAMEOVER = true;
                    timer2.Stop();
                    this.Hide();
                    BadEndingForm f4 = new BadEndingForm();
                    f4.ShowDialog();
                }
            }
            //bonus for hard mod

            hatPosX += moveStepX;
            if (
                hatPosX < 228 ||
                hatPosX + hatWigth > this.ClientSize.Width-486)
            {
                moveStepX = -moveStepX;
            }

            hatPosY += moveStepY;
            if (
                hatPosY < 38 ||
                hatPosY + hatHight > this.ClientSize.Height-81)
            {
                moveStepY = -moveStepY;
            }

            this.SuspendLayout();
            hat.Location = new Point(hat.Location.X + moveStepX, hat.Location.Y + moveStepY);
            this.ResumeLayout();          

            

            if (the_moving_snake.Bounds.IntersectsWith(hat.Bounds) && GAMEOVER==false)
            {
                GAMEOVER = true;
                timer2.Stop();
                this.Hide();
                BadEndingForm f4 = new BadEndingForm();
                f4.ShowDialog();
                
                //form for bad ending screen
            }

            

            //movement of maraca
            if (MakenMaraca.Left > the_moving_snake.Left)
            {
                MakenMaraca.Left -= maracaSpeed;

                if (MakenMaraca.Left <= 228)
                {
                    MakenMaraca.Left = 228;
                }
            }

            if (MakenMaraca.Top > the_moving_snake.Top)
            {
                MakenMaraca.Top -= maracaSpeed;

                if (MakenMaraca.Top <= 35)
                {
                    MakenMaraca.Top = 35;
                }

            }

            if (MakenMaraca.Left < the_moving_snake.Left)
            {
                MakenMaraca.Left += maracaSpeed;
               
            }

            if (MakenMaraca.Top < the_moving_snake.Top)
            {
                MakenMaraca.Top += maracaSpeed;
                
            }

        }
      
        public string stdName { get; set; }
       
        private void MakePicterBox()
        {
            PictureBox new_pic = new PictureBox();
            new_pic.Height = 30;
            new_pic.Width = 30;
            listForD.Images.Add(Image.FromFile(Application.StartupPath + "\\ImagesFiles\\Easy Difficulty Form\\dorito.jpg"));            
            new_pic.BackgroundImage = listForD.Images[0];
            listForD.Images.Clear();

           
            x = rand.Next(228, this.ClientSize.Width - new_pic.Width - 472); 
            y = rand.Next(38, this.ClientSize.Height - new_pic.Height - 66);

            new_pic.Location = new Point(x, y);
            new_pic.BackgroundImageLayout = ImageLayout.Zoom;

            while (new_pic.Bounds.IntersectsWith(the_moving_snake.Bounds))
            {
                x = rand.Next(228, this.ClientSize.Width - new_pic.Width - 472);
                y = rand.Next(38, this.ClientSize.Height - new_pic.Height - 66);


                new_pic.Location = new Point(x, y);
                new_pic.BackgroundImageLayout = ImageLayout.Zoom;
            }

                                 
            items.Add(new_pic);
            this.Controls.Add(new_pic);
            new_pic.BringToFront();
            hat.BringToFront();           
            isThereDorito = true;
        }

        private PictureBox MakeMaraca()
        {
            PictureBox new_pic2 = new PictureBox();
            new_pic2.Height = 30;
            new_pic2.Width = 30;
            listForM.Images.Add(Image.FromFile(Application.StartupPath + "\\ImagesFiles\\Easy Difficulty Form\\SigleMaracas.jpg"));
            new_pic2.BackgroundImage = listForM.Images[0];
            listForM.Images.Clear();

            x = hat.Location.X;
            y = hat.Location.Y;
            new_pic2.Location = new Point(x, y);
            new_pic2.BackgroundImageLayout = ImageLayout.Zoom;
            itemsM.Add(new_pic2);
            this.Controls.Add(new_pic2);
            new_pic2.BringToFront();
            hat.BringToFront();

            return new_pic2;
        }

        //------------------------------------------------------------------------------------------
        private void the_moving_snake_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

       
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        int timerS = 0;
        int timerM = 0;
        int timerH = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timerS++;


            label3.Text = timerS + "sec";
            if (timerS == 60)
            {
                timerS = 0;
                timerM++;
                if (timerM == 60)
                {
                    timerM = 0;
                    timerH++;
                }
            }

            if (timerM > 0)
            {
                label3.Text = timerM + " min " + timerS + " sec";
            }

            if (timerH > 0)
            {
                label3.Text = timerH + " hr " + timerM + " min " + timerS + " sec";
            }


        }

        private void EasyDifficultyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FUTURE TODO: if Esc key is pushed to show pause form
        }

        private void the_moving_snake_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, the_moving_snake.ClientRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

        //------------------------------------------------------------------------------------------


        private void MoveHat()
        {
            hatPosX += moveStepX;
            if (
                hatPosX < 223 ||
                hatPosX + hatWigth > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }

            hatPosY += moveStepY;
            if (
                hatPosY < 35 ||
                hatPosY + hatHight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
          
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                moveUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDown = false;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
