using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace True_or_False
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Trying different Tests such as:
            * a == b
            * a < b
            * a <= b
            * a > b
            * a >= b
            * a != b
            * a != a
            * */
            int a = 10;
            int b = 10;
            if (a > b)
            {
                textBox1.Text = "Test is true";
            }
            else
            {
                textBox1.Text = "Test is false";
            }
        }
    }
}