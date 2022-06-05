using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_vb
{
    public partial class Form1 : Form
    {
        char turn = 'X';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            }
        }
    }
}
