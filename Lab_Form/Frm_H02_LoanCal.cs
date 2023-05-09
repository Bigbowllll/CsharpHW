using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class Frm_H02_LoanCal : Form
    {
        
        public Frm_H02_LoanCal()
        {
            InitializeComponent();
        }

        private void btnMonPaid_Click(object sender, EventArgs e)
        {
            LoanCal();
            MessageBox.Show("月付款: " + Loan.monPaid.ToString("0") + " 元");

        }

        void LoanCal()
        {
            Loan.loanPrice = double.Parse(txtLoanPrice.Text);
            Loan.labRate = double.Parse(txtRate.Text) / 100; // 將年利率轉換為月利率
            Loan.firstPrice = double.Parse(txtFirstPrice.Text);
            Loan.labYear = int.Parse(txtYear.Text);

            double monRate1 = Math.Pow(1 + Loan.labRate / 12, Loan.labYear * 12) * (Loan.labRate / 12) / (Math.Pow(1 + Loan.labRate / 12, Loan.labYear * 12) - 1);
            Loan.monPaid = Loan.loanPrice * monRate1;

            double paymentYear = Loan.labYear * 12;
            double totalPaid = Loan.monPaid * paymentYear;
            Loan.totalPaid = Convert.ToInt32(totalPaid);

            // double monRate = Loan.loanPrice * Loan.labRate / 12;  // 第一期應繳利息=貸款金額*月利率
            // int paymentYear = Loan.labYear * 12;   // 還款總月數=貸款年期×12
           // 每月應付本息金額之平均攤還率 = {[(1+月利率)^月數]×月利率}÷{[(1+月利率)^月數]－1}
          
            //Loan.totalPaid = interest * paymentYear;  // 總付款=每月應還本息金額×還款總月數
        }



        private void btnTotalPaid_Click(object sender, EventArgs e)
        {
            LoanCal();
            MessageBox.Show("總付款: " +  Loan.totalPaid.ToString("0") + " 元");

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frm_LoanReport frm = new frm_LoanReport(this);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
