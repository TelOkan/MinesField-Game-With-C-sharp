using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINEFIELDS_GITHUB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] btn = new Button[101];
        int counter = 0;
        string[] score_array = new string[100];
        int level = 0;
        int score = 0;
        int score_counter = 0;
        int gamestarted = 0;
        List<int> mines_adress = new List<int>();
        System.Media.SoundPlayer playergame = new System.Media.SoundPlayer("../../images/gamesound.wav");
        System.Media.SoundPlayer explosion = new System.Media.SoundPlayer("../../images/explosion.wav");
        System.Media.SoundPlayer warning = new System.Media.SoundPlayer("../../images/warning.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_play.Image = Image.FromFile("../../images/start.gif");
            btn_play.BackgroundImageLayout = ImageLayout.Center;
            pb_level1.Image = Image.FromFile("../../images/rank.png");
            pb_level2.Image = Image.FromFile("../../images/rank.png");
            pb_level3.Image = Image.FromFile("../../images/rank.png");
        }

        private void btn_play_Click(object sender, EventArgs e)
        {

            if (level == 0)
            {
                warning.Play();
                MessageBox.Show("Please Select Your Level,You can Select as click on medallions!");

            }
            else
            {
                gamestarted = 1;
                counter = 0;
                Random rnd = new Random();
                playergame.Play();
                btn_play.Image = Image.FromFile("../../images/skull.jpeg");
                btn_play.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox1.Image = Image.FromFile("../../images/torch.gif");
                pictureBox2.Image = Image.FromFile("../../images/torch.gif");
                for (int i = 1; i <101; i++)
                {
                    btn[i] = new Button();
                    btn[i].Height = 40;
                    btn[i].Width = 40;
                    btn[i].Text = i.ToString();                
                    btn[i].BackColor = Color.BlueViolet;
                    flowLayoutPanel1.Controls.Add(btn[i]);
                    btn[i].Click += Btn_Click;

                }
                #region Level
                if (level == 1)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        mines_adress.Add(rnd.Next(1, 100));

                        counter++;
                    }
                }
                else if (level == 2)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        mines_adress.Add(rnd.Next(1, 100));

                        counter++;
                    }

                }

                else if (level == 3)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        mines_adress.Add(rnd.Next(1, 100));

                        counter++;
                    }
                }

                else
                {
                    MessageBox.Show("Please Select Level!");
                }
                #endregion
                lbl_number_of_mines.Text = counter.ToString();
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int buton_no;
            if (mines_adress.IndexOf(Convert.ToInt32(((Button)sender).Text)) == -1)
            {


                if (Array.IndexOf(score_array, ((Button)sender).Text) == -1)
                {

                    score += 10;

                }
                else
                {

                }
                score_array[score_counter] = (((Button)sender).Text);
                score_counter = score_counter + 1;
                lbl_score.Text = score.ToString();
                buton_no = Convert.ToInt32(((Button)sender).Text);
                btn[buton_no].BackColor = Color.Green;
            }
            else
            {
                gamestarted = 0;
                explosion.Play();
                buton_no = Convert.ToInt32(((Button)sender).Text);
                btn[buton_no].BackColor = Color.Red;

                foreach (int sayi in mines_adress)
                {

                    btn[sayi].BackgroundImage = Image.FromFile("../../images/mines.png");
                    btn[sayi].BackgroundImageLayout = ImageLayout.Stretch;




                }

                DialogResult sonuc = MessageBox.Show("Do You Want To Play Again! ?", "GAME OVER!", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }

        }

        private void pb_level1_Click(object sender, EventArgs e)
        {

            if (gamestarted == 0 && level == 0)
            {
                level = 1;
                lbl_level1.ForeColor = Color.Red;
                lbl_level2.ForeColor = Color.Yellow;
                lbl_level3.ForeColor = Color.Yellow;
            }
            else if (gamestarted == 1 && level != 0)
            {
                MessageBox.Show("Hahah You can not change the level after the game started! Dont Afraid!");
            }


        }

        private void pb_level2_Click(object sender, EventArgs e)
        {
            if (gamestarted == 0 && level == 0)
            {
                level = 2;
                lbl_level1.ForeColor = Color.Yellow;
                lbl_level2.ForeColor = Color.Red;
                lbl_level3.ForeColor = Color.Yellow;
            }
            else if (gamestarted == 1 && level != 0)
            {
                MessageBox.Show("Hahah! You can not change level after the game started! Dont Afraid!");
            }
        }

        private void pb_level3_Click(object sender, EventArgs e)
        {

            if (gamestarted == 0 && level == 0)
            {
                level = 3;
                lbl_level1.ForeColor = Color.Yellow;
                lbl_level2.ForeColor = Color.Yellow;
                lbl_level3.ForeColor = Color.Red;
            }
            else if (gamestarted == 1 && level != 0)
            {
                MessageBox.Show("Hahaha! You can not change level after the game started! Dont Afraid!");
            }
        }
    }
}
