using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Lab_Form;

namespace Lab_Form
{
    public partial class frm_inputbox : Form
    {
        private Frm_H15_GuessNum frmNum;
        public frm_inputbox(Frm_H15_GuessNum frm)
        {
            InitializeComponent();
            frmNum = frm;
        }

       
       
        private void frm_inputbox_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            GuessNum.guess = r.Next(1, 100);           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

       int max = 100;
        int min = 0;
        int count = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            int myguess;
            bool isGuess = int.TryParse(txtGuess.Text, out myguess);

            if (txtGuess.Text == "")
            {
                MessageBox.Show($"請輸入{min}~{max}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isGuess == false || myguess < min || myguess >max)
            {
                MessageBox.Show($"請輸入{min}~{max}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuess.Clear();
            }
            else
            {
                if (myguess == GuessNum.guess)
                {
                    MessageBox.Show("Congratulations!!! you got " + myguess);
                }
                else if (myguess > GuessNum.guess)
                {
                    max = myguess;
                    frmNum.labName.Text = $"Too Big!!!\nBetween {min} and {max}";
                }
                else if (myguess < GuessNum.guess)
                {
                    min = myguess;
                    frmNum.labName.Text = $"Too small!!!\nBetween {min} and {max}";
                }
            

        }

            }

        }


    }






    
