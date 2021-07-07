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
    public partial class gameWindowForm : Form
    {
        private bool playerTurn = true;
        private string showX = "X";
        private string show0 = "0";
        private string toniWinner = "A castigat Toni!";
        private string dorelWinner = "A castigat Dorel!";
        private string drawMessage = "Nu a castigat nimeni!";

        public gameWindowForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            GameLogic(sender);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            GameLogic(sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {

            GameLogic(sender);

        }

        private void WriteXor0(object x)
        {
            Label y = (Label)x;
            if (playerTurn)
            {
                y.Text = show0;
                playerTurn = !playerTurn;
            }
            else
            {
                y.Text = showX;
                playerTurn = !playerTurn;
            }
        }

        private void whoIsTheWinner()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != "")
            {
                ShowWinner(label1);
            }
            if (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != "")
            {
                ShowWinner(label1);
            }
            if (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != "")
            {
                ShowWinner(label1);
            }

            if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != "")
            {
                ShowWinner(label2);
            }

            if (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != "")
            {
                ShowWinner(label4);
            }

            if (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != "")
            {
                ShowWinner(label3);
            }

            if (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != "")
            {
                ShowWinner(label7);
            }

            if (label7.Text == label5.Text && label5.Text == label3.Text && label7.Text != "")
            {
                ShowWinner(label7);
            }

            ShowDraw();
        }

        private void ShowDraw()
        {
            if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
            {
                MessageBox.Show(drawMessage);
                ResetGame();
            }

        }

        private void ResetGame()
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

        private void ShowWinner(Label cell)
        {
            if (cell.Text == show0)
            {
                MessageBox.Show(toniWinner);
            }
            else
            {
                MessageBox.Show(dorelWinner);
            }
            ResetGame();
        }

        private void GameLogic(Object x)
        {
            if (((Label)x).Text == "")
            {
                WriteXor0(x);
            }

            whoIsTheWinner();
        }

        private void resetGameButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
