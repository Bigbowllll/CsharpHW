using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_H08_MyClac : Form
    {
        public Frm_H08_MyClac()
        {
            InitializeComponent();
        }

                
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int plustotal = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);

                labAnsShow.Text = plustotal.ToString();
            }
          
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int plustotal = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
                labAnsShow.Text = plustotal.ToString();
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                int plustotal = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
                labAnsShow.Text = plustotal.ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                double plustotal = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                labAnsShow.Text = plustotal.ToString();
            }
        }
    }
}
