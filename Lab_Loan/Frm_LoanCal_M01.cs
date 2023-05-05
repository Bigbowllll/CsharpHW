using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Loan
{
    public partial class Frm_LoanCal_M01 : Form
    {
        public Frm_LoanCal_M01()
        {
            InitializeComponent();
        }

        private void Frm_LoanCal_M01_Load(object sender, EventArgs e)
        {

        }

        private void btnMonPaid_Click(object sender, EventArgs e)
        {
            //每月平均攤還率 = { [ (1 + 月利率 ) ^ 期數 ] x 月利率 } / { [ ( 1 + 月利率 ) ^ 期數 ] – 1 }
            decimal loanPrice, labRate, monPaid,firstPrcice;
            int labYear;

                loanPrice = decimal.Parse(txtLoanPrice.Text);
                labRate = decimal.Parse(txtRate.Text);
                firstPrcice = decimal.Parse(txtFirstPrice.Text);
                labYear = int.Parse(txtYear.Text);  

            decimal monRate = labRate / 1200;
            int payment= labYear * 12;

            monPaid = (loanPrice * labRate);

            MessageBox.Show(monPaid.ToString());



           

        }
    }
}
