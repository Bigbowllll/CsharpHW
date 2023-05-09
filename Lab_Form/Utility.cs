using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()  //只能在上行MyClass底下使用
        {
            MessageBox.Show("Method01");
        }

        // 存取修飾詞 private public internal:同個專案才可以使用 
        private void Method02()
        {
            MessageBox.Show("Method02");
        }
        internal void Method03() 
        {
            MessageBox.Show("Method03 internal");
        }

        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }
        public void Method05()
        {
            Method01();
            Method02();
        }
    }
    
    public class Member
    {
        public decimal Price;
        public decimal Paid;
        public decimal FirstPrice;
        public decimal TotalPrice;       
        public int Year;
        public int Rate;
           // loanPrice, labRate, monPaid,firstPrcice,totalPrice
    }

    public class Item
    {
        public int Price;
        public int beer;
        public int whisky;
        public int tequila;
        public int wine;
        public string Name;
        public string ID;
    }

    public struct SaveScore
    {
        public string Name { get; set; }
        public int ChinScore { get; set; }
        public int EngScore { get; set;}
        public int MathScore { get; set;}

        public SaveScore(String name,int chinscore,int engscore, int mathscore)
        {
            Name = name;
            ChinScore = chinscore;
            EngScore = engscore;
            MathScore = mathscore;
        }
    }



    public struct Score
    {
        public string Name;
        public int Chinscore;
        public int Engscore;
        public int MathScore;
        public int TotalScore;
        public int Average;
        public string maxSubject;
        public string minSubject;
        public int maxScore;
        public int minScore;
    }

    public class GuessNum
    {
        public int Answer;
        public static int guess;
    }


    public class Loan
    {
        public static double loanPrice, labRate, monPaid, firstPrice,totalPaid;
        public static int labYear;
    }

}
