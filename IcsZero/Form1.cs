using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcsZero
{
    public partial class Form1 : Form
    {
        bool _playerTurn = true;
        private string showX = "X";
        private string show0 = "0";
        private string toniWinner = "A castigat Toni!";
        private string dorelWinner = "A castigat Dorel!";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                writeXor0(label1);
            }
            whoIsTheWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                writeXor0(label2);
            }
            whoIsTheWinner();

        }

        // TODO faceti restul sa mearga :(
        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                writeXor0(label3);
            }
            whoIsTheWinner();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
            {
                writeXor0(label6);
            }
            whoIsTheWinner();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                writeXor0(label5);
            }
            whoIsTheWinner();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                writeXor0(label4);
            }
            whoIsTheWinner();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                writeXor0(label9);
            }
            whoIsTheWinner();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                writeXor0(label8);
            }
            whoIsTheWinner();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            if (label7.Text == "")
            {
                writeXor0(label7);
            }
            whoIsTheWinner();

        }

        private void writeXor0(Label x)
        {
            if (_playerTurn)
            {
                x.Text = show0;
                _playerTurn = !_playerTurn;
            }
            else
            {
                x.Text = showX;
                _playerTurn = !_playerTurn;
            }
        }

        private void whoIsTheWinner()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text!="")
            {
                showWinner(label1);
            }
            if (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text!="")
            {
                showWinner(label1);
            }
            if (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text!="")
            {
                showWinner(label1);
            }

            if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text!="")
            {
                showWinner(label2);
            }

            if (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text!="")
            {
                showWinner(label4);
            }

            if (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text!="")
            {
                showWinner(label3);
            }

            if (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text!="")
            {
                showWinner(label7);
            }

            if (label7.Text == label5.Text && label5.Text == label3.Text && label7.Text!="")
            {
                showWinner(label7);
            }
        }

        private void resetGame()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void showWinner(Label cell)
        {
            if (cell.Text == show0)
            {
                MessageBox.Show(toniWinner);
            }
            else
            {
                MessageBox.Show(dorelWinner);
            }
            resetGame();
        }
    }
}
