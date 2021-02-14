using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primitive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    text.Text = "14";
                    break;
                case 1:
                    text.Text = " ";
                    break;
                case 2:
                    text.Text = "14L";
                    break;
                case 3:
                    text.Text = " ";
                    break;
                case 4:
                    text.Text = "14.5F";
                    break;
                case 5:
                    text.Text = " ";
                    break;
                case 6:
                    text.Text = "14.256882838";
                    break;
                case 7:
                    text.Text = " ";
                    break;
                case 8:
                    text.Text = "3.003764834333M";
                    break;
                case 9:
                    text.Text = " ";
                    break;
                case 10:
                    text.Text = "Farjana Sultana Samia";
                    break;
                case 11:
                    text.Text = " ";
                    break;
                case 12:
                    text.Text = "F";
                    break;
                case 13:
                    text.Text = " ";
                    break;
                default:
                    text.Text = "False";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
