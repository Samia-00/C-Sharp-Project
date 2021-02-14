using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text_TextChanged(object sender, EventArgs e)
        {

            any();
        }
        void any()
        {
            string grade = Console.ReadLine();
            //char grade;
           // grade=Convert.ToChar(Console.ReadLine());

            switch (ToString(grade))
            {
                case "A":
                    text2.Text = "Excelent!!!!!!!!!!!!";
                    break;
                case "B":
                case "C":
                    text2.Text = "Well Done !!!!!!!!!!!!";
                    break;
                case "D":
                    text2.Text = "You Passed!!!!!!!!!!!!";
                    break;
                case "F":
                    text2.Text = "Better Luck Next Time!!!!!!!!!!!!!!!!!!!!!!!";
                    break;
                default:
                    text2.Text = "INVALID";
                    break;
            }
        }
    }
}
