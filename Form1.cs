using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            String Alpha = "abcdefghijklmnopqrstuvwxyz";
            String Message = textBox3.Text;
            Char[] Encryption = new char[Message.Length];
            int K = int.Parse(textBox4.Text);
            for (int i = 0; i < Message.Length; i++)
            {
                if (Alpha.Contains(Message[i]))
                {
                    int M, X;
                    M = Alpha.IndexOf(Message[i]);
                    X = (M + K) % 26;
                    Encryption[i] = Alpha.ElementAt(X);

                }
            }
            for (int i = 0; i < Message.Length; i++)
            {
                label4.Text += Encryption[i];
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter_here")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter_here";
                textBox3.ForeColor = Color.Silver;
            }
        }
    }
}
