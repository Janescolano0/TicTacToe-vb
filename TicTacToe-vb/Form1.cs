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

        private void btn2_Click(object sender, EventArgs e)
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

        private void btn3_Click(object sender, EventArgs e)
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

        private void btn4_Click(object sender, EventArgs e)
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

        private void btn5_Click(object sender, EventArgs e)
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

        private void btn6_Click(object sender, EventArgs e)
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

        private void btn7_Click(object sender, EventArgs e)
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

        private void btn8_Click(object sender, EventArgs e)
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

        private void btn9_Click(object sender, EventArgs e)
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
