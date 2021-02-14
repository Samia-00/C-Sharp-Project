using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marks = textBox2.Text;
            switch (marks)
            {
                case "A+":
                    textBox3.Text = "Excellent!!";
                    break;
                case "A":
                    textBox3.Text = "GREAT!!";
                    break;
                case "B":
                    textBox3.Text = "GOOD!!";
                    break;
                case "C":
                    textBox3.Text = "IT'S OKAY!!";
                    break;
                case "D":
                    textBox3.Text = "TRY AGAIN!!!";
                    break;
                case "F":
                    textBox3.Text = "BETTER LUCK NEXT TIME!!";
                    break;

                default:
                //case "":
                    textBox3.Text = "INVALID GRADE!";
                    break;
          
            }
            
        }
      
    }
}
