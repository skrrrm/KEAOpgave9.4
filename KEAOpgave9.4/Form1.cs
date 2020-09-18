using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave9._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "a = 2\nb = 3\ny = a * x + b"; // Adding some explanation text
        }

        /// <summary>
        /// Method for  a straight line
        /// </summary>
        /// <param name="x"></param>
        /// <returns>a * x + b</returns>
        int Line (int x)
        {
            int a = 2;
            int b = 3;
            return a * x + b; // Y
        }
        /// <summary>
        /// Just a simple loop that writes out 'n' in the box for 'X'.
        /// And calls the method 'Line' to write out the result for 'Y'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int n = 0; n <= 10; n++)
            {
                listBoxX.Items.Add(n);
                listBoxY.Items.Add(Line(n));
            }
        }
    }
}
