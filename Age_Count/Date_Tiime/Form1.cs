using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Tiime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(textBox2.Text);
            int age = DateTime.Now.Subtract(dob).Days / 365;
            textBox3.Text =
            " You  are  " + age + "  years  old!!! ";
        }
    }
}
