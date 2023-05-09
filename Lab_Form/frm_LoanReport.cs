using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class frm_LoanReport : Form
    {
        private Frm_H02_LoanCal Newfrm;
        public frm_LoanReport(Frm_H02_LoanCal frm)
        {
            InitializeComponent();
            Newfrm = frm;            
        }

        private void frm_LoanReport_Load(object sender, EventArgs e)
        {
            labPriceS.Text = Loan.loanPrice.ToString();
            labRateS.Text = Loan.labRate.ToString();            
            labYearS.Text=Loan.labYear.ToString();
            labMonPaidS.Text =Loan.monPaid.ToString();
            labTotalPaidS.Text=Loan.totalPaid.ToString();

        }
    }
}
