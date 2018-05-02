using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Boolean count = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if ( b.Text == "")
            {
                if (count)
                {
                    b.Text = "X";
                    count = false;
                }
                else
                {
                    b.Text = "O";
                    count = true;
                }
                String result = checkWinner();
                if (result != " " && result!="")
                {
                    MessageBox.Show(result + " Won the game!!");
                }
            }
        }
        private String checkWinner()
        {
            //row wise check
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text!=" ")
                return b1.Text;
            else if (b4.Text == b5.Text && b5.Text == b6.Text && b4.Text != " ")
                return b4.Text;
            else if (b7.Text == b8.Text && b8.Text == b9.Text && b7.Text != " ")
                return b7.Text;
            //diagonal check
            else if (b1.Text == b5.Text && b5.Text == b9.Text && b1.Text != " ")
                return b1.Text;
            else if (b3.Text == b5.Text && b5.Text == b7.Text && b3.Text != " ")
                return b3.Text;
            //column wise check
            else if (b2.Text == b5.Text && b8.Text == b5.Text && b2.Text != " ")
                return b2.Text;
            else if (b3.Text == b6.Text && b9.Text == b6.Text && b3.Text != " ")
                return b3.Text;
            else if (b1.Text == b4.Text && b4.Text == b7.Text && b1.Text != " ")
                return b1.Text;
            //if nothing
            else
                return " ";
        }

        private void restart_Click(object sender, EventArgs e)
        {
            b1.Text = "";b2.Text = "";
            b3.Text = "";b4.Text = "";
            b5.Text = "";b6.Text = "";
            b8.Text = "";b9.Text = "";
            b7.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
