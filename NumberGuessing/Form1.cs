using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class Form1 : Form
    {
        int randomNumber;
        int number;
        int tries;
        public Form1()
        {
            InitializeComponent();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 11);
            tries = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                if (number == randomNumber)
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    tries = tries + 1;
                    label4.Text = tries.ToString();
                    label4.Text = "0";
                }
                else
                {
                    if (number > randomNumber)
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                        tries = tries + 1;
                        label4.Text = tries.ToString();
                    }
                    else
                    {
                        Form5 form5 = new Form5();
                        form5.Show();
                        tries = tries + 1;
                        label4.Text = tries.ToString();
                    }

                }
                textBox1.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
