using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_racing_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            Coins(gamespeed);
            Coinscollection();

            
        }

        int Collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);
               
                enemy1.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }


            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }


        }

        void Coins(int speed)
        {
            if (Coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin1.Location = new Point(x, 0);
            }

            else { Coin2.Top += speed; }

            if (Coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin2.Location = new Point(x, 0);
            }

            else { Coin2.Top += speed; }



            if (Coin3.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin3.Location = new Point(x, 0);
            }

            else { Coin3.Top += speed; }




            if (Coin4.Top >= 500)
            {
                x = r.Next(0, 200);

                Coin4.Location = new Point(x, 0);
            }

            else { Coin4.Top += speed; }
           


        }








        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled=false;
                over.Visible=true;

            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }
        }




        void moveline(int speed)
        {
            if(pictureBox1.Top>=500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }
           

        }
        void Coinscollection()
        {
            if (car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                Collectedcoin++;
                label1.Text = "Coins" + Collectedcoin.ToString();
                x = r.Next(0, 200);

                Coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                Collectedcoin++;
                label1.Text = "Coins" + Collectedcoin.ToString();
                x = r.Next(0, 200);

                Coin2.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                Collectedcoin++;
                label1.Text = "Coins" + Collectedcoin.ToString();
                x = r.Next(0, 200);

                Coin3.Location = new Point(x, 0);

            }


            if (car.Bounds.IntersectsWith(Coin4.Bounds))
            {
                Collectedcoin++;
                label1.Text = "Coins" + Collectedcoin.ToString();
                x = r.Next(0, 200);

                Coin4.Location = new Point(x, 0);

            }
        }









        int gamespeed = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left>0)

                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<600)

                car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
                


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Coin1_Click(object sender, EventArgs e)
        {

        }

    }
}
