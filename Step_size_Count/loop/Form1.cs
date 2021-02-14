using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Show();
        }

        void Show()
        {
            txtShow.Text = "";
            int i = txtNumber.Text.Length - 1;
            int j = 1;
            do
            {
                txtShow.Text = txtShow.Text + txtNumber.Text.Substring(i, j) + "\r\n";
                i--;
                j++;
            }
            while (i >= 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        private void txt(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                Show();
            }
        }
    }
}
