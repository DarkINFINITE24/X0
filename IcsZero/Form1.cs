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
                writeXor0();
            }
            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
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
            if (label1.Text == label4.Text && label4.Text == label7.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
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
            if (label1.Text == label5.Text && label5.Text == label9.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
                if (_playerTurn)
                {
                    label2.Text = "0";
                    _playerTurn = !_playerTurn;
                }
                else
                {
                    label2.Text = "1";
                    _playerTurn = !_playerTurn;
                }

            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
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
            if (label2.Text == label5.Text && label5.Text == label8.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
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

        }

        // TODO faceti restul sa mearga :(
        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
                writeXor0();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
                writeXor0();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
                writeXor0();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
                writeXor0();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                writeXor0();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                writeXor0();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                writeXor0();
            }

        }

        private void writeXor0()
        {
            if (_playerTurn)
            {
                label7.Text = show0;
                _playerTurn = !_playerTurn;
            }
            else
            {
                label7.Text = showX;
                _playerTurn = !_playerTurn;
            }
        }

        private void whoIsTheWinner()
        {

        }
    }
}
