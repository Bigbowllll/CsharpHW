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

        private void Frm_LoanCal_M01_Load(object sender, EventArgs e)
        {

        }

        private void btnMonPaid_Click(object sender, EventArgs e)
        {
                     
            double loanPrice, labRate, monPaid,firstPrice;
            int labYear;

                loanPrice = double.Parse(txtLoanPrice.Text);
                labRate = double.Parse(txtRate.Text);
                firstPrice = double.Parse(txtFirstPrice.Text);
                labYear = int.Parse(txtYear.Text);  

            double monRate = loanPrice * labRate / 12;  //第一期應繳利息=貸款金額*年利率/12
            int paymentYear= labYear * 12;   //(公式中：還款總月數＝貸款年期×12)

            double MonRate1 = labRate / 12;     //( 月利率 ＝ 年利率／12 )
            int Year = labYear * 12;                          //( 月數 = 貸款年期 ｘ 12)
            // 每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
            double monRate1 = ((1 + MonRate1) * Year) * MonRate1 / (((1 + MonRate1) * Year) - 1);

            monPaid = loanPrice * monRate1;

            //monPaid = (loanPrice / labYear)+(loanPrice*monRate);


            MessageBox.Show("月付款: "+monPaid.ToString()+" 元");



//每月應付本息金額之平均攤還率 ＝{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
//(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
//每月應攤還本金與利息試算：
//平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
//每月應付利息金額＝本金餘額×月利率
//每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額





        }
    }
}
