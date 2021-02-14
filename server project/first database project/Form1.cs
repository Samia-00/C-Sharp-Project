using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_database_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "The Form is ready to use!!!.......";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentid.Text = "";
            txtbangla.Text = "";
            txtenglish.Text = "";
            txtmath.Clear();
            lblmsg.Text = "The Form is ready to use!!!.......";
            txtstudentid.Focus();
        }

        private void btnavg_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.studentId = txtstudentid.Text;
            s.MarksofBangla = Convert.ToDouble(txtbangla.Text);
            s.MarksofEnglish = Convert.ToDouble(txtenglish.Text);
            s.MarksofMath = Convert.ToDouble(txtmath.Text);
            lblmsg.Text="The Average value is : "+s.AvgMarks().ToString();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = new Student();
                stu.studentId = txtstudentid.Text;
                stu.MarksofBangla = Convert.ToDouble(txtbangla.Text);
                stu.MarksofEnglish = Convert.ToDouble(txtenglish.Text);
                stu.MarksofMath = Convert.ToDouble(txtmath.Text);
                stu.Save();
                lblmsg.Text = "Information Saved Successfully!!!!";
            }
            catch (Exception ex)
            {
                lblmsg.Text=ex.Message;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                Student sg = new Student();
                sg.studentId = txtstudentid.Text;
                sg.Find();
                txtbangla.Text = sg.MarksofBangla.ToString();
                txtenglish.Text = sg.MarksofEnglish.ToString();
                txtmath.Text = sg.MarksofMath.ToString();
            }
            catch (Exception ex)
            {
                lblmsg.Text = ex.Message;
            }
        }
    }
}
