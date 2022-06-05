using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TicTacToe_vb
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        char turn = 'X';
        public Form1()
        {
            InitializeComponent();
            player.URL = "(No Copyright) 5 Minute Gaming Tracks _ UCan2 Non-Copyright Music.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn1.Text == btn2.Text)
                {
                    if (btn1.Text == btn3.Text)
                    {
                        MessageBox.Show("You Win " + btn1.Text);
                    }
                }

                if (btn1.Text == btn4.Text)
                {
                    if (btn1.Text == btn7.Text)
                    {
                        MessageBox.Show("You Win " + btn1.Text);
                    }
                }
                if (btn1.Text == btn5.Text)
                {
                    if (btn1.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn1.Text);
                    }
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn2.Text == btn5.Text)
                {
                    if (btn2.Text == btn8.Text)
                    {
                        MessageBox.Show("You Win " + btn2.Text);
                    }
                }
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn3.Text == btn6.Text)
                {
                    if (btn3.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn3.Text);
                    }
                }

                if (btn3.Text == btn5.Text)
                {
                    if (btn3.Text == btn7.Text)
                    {
                        MessageBox.Show("You Win " + btn3.Text);
                    }
                }
                if (btn3.Text == btn2.Text)
                {
                    if (btn3.Text == btn1.Text)
                    {
                        MessageBox.Show("You Win " + btn3.Text);
                    }
                }
            }
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn4.Text == btn5.Text)
                {
                    if (btn4.Text == btn6.Text)
                    {
                        MessageBox.Show("You Win " + btn4.Text);
                    }
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn5.Text == btn2.Text)
                {
                    if (btn5.Text == btn8.Text)
                    {
                        MessageBox.Show("You Win " + btn5.Text);
                    }
                }

                if (btn5.Text == btn4.Text)
                {
                    if (btn5.Text == btn6.Text)
                    {
                        MessageBox.Show("You Win " + btn5.Text);
                    }
                }

                if (btn5.Text == btn1.Text)
                {
                    if (btn5.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn5.Text);
                    }
                }

                if (btn5.Text == btn3.Text)
                {
                    if (btn5.Text == btn7.Text)
                    {
                        MessageBox.Show("You Win " + btn5.Text);
                    }
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn6.Text == btn5.Text)
                {
                    if (btn6.Text == btn4.Text)
                    {
                        MessageBox.Show("You Win " + btn6.Text);
                    }
                }

                if (btn6.Text == btn3.Text)
                {
                    if (btn6.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn6.Text);
                    }
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn7.Text == btn8.Text)
                {
                    if (btn7.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn7.Text);
                    }
                }

                if (btn7.Text == btn4.Text)
                {
                    if (btn7.Text == btn1.Text)
                    {
                        MessageBox.Show("You Win " + btn7.Text);
                    }
                }

                if (btn7.Text == btn5.Text)
                {
                    if (btn7.Text == btn3.Text)
                    {
                        MessageBox.Show("You Win " + btn7.Text);
                    }
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn8.Text == btn5.Text)
                {
                    if (btn8.Text == btn2.Text)
                    {
                        MessageBox.Show("You Win " + btn8.Text);
                    }
                }

                if (btn8.Text == btn7.Text)
                {
                    if (btn8.Text == btn9.Text)
                    {
                        MessageBox.Show("You Win " + btn8.Text);
                    }
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = '0';
                }
                else
                {
                    turn = 'X';
                }
                if (btn9.Text == btn8.Text)
                {
                    if (btn9.Text == btn7.Text)
                    {
                        MessageBox.Show("You Win " + btn9.Text);
                    }
                }

                if (btn9.Text == btn5.Text)
                {
                    if (btn9.Text == btn1.Text)
                    {
                        MessageBox.Show("You Win " + btn9.Text);
                    }
                }

                if (btn9.Text == btn6.Text)
                {
                    if (btn9.Text == btn3.Text)
                    {
                        MessageBox.Show("You Win " + btn9.Text);
                    }
                }
            }
        }
    }
}
