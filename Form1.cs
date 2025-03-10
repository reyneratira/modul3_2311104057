using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_2311104057_jurnal
{
    public partial class Form1: Form
    {
        private double currentResult = 0;
        private bool isNewNumber = true;
        private string operation = "";

        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewNumber)
            {
                lblResult.Text = button.Text;
                isNewNumber = false;
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double currentNumber = Convert.ToDouble(lblResult.Text);

            if (operation == "+")
            {
                currentResult += currentNumber;
            }
            else
            {
                currentResult = currentNumber;
            }

            operation = button.Text;
            lblResult.Text = currentResult.ToString();
            isNewNumber = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(lblResult.Text);

            if (operation == "+")
            {
                currentResult += currentNumber;
            }

            lblResult.Text = currentResult.ToString();
            operation = "";
            isNewNumber = true;
        }
    }
}
