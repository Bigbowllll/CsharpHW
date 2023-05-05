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
    public partial class Frm_H15_GuessNum : Form
    {
        public Frm_H15_GuessNum()
        {
            InitializeComponent();
        }

        int guess, count, min, max;
        private void Guess()
        {
            Random r = new Random();
            guess = r.Next(1, 100);            
            max = 0; 
            min=0;
            count = 0;

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Please input a number.","Guess",MessageBoxButtons.OK);
            count += 1;
            int myguess = 0;
            if(myguess>=1&&myguess<100)
            {
             if(myguess==guess)
                {
                    MessageBox.Show("Bingo");
                }
             else if(myguess>guess)
                {
                    max = myguess;
                }
             else if(myguess<guess)
                {
                    min = myguess;
                }
                else
                {
                    //輸入提示範圍內的數字
                }
             
             //提示數字:$"{min}<?<{max}";
            }
        }

    
    }
}
