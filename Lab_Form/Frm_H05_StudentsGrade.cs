using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lab_Form
{
    public partial class Frm_H05_StudentsGrade : Form
    {
        public Frm_H05_StudentsGrade()
        {
            InitializeComponent();
            labShow.Parent = panel1;            
        }
        private int stunum = 0;
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = true;
            btnRandomAdd.Enabled = true;
            btnRandomSave.Enabled = true;
            labShow.Text = string.Empty;
            labSum.Text = string.Empty;
            num = 0;
            stunum = 0;
            ChineseScore = 0;
            EngScore = 0;
            MathScore = 0;
            ChineseTotal = 0;
            EngTotal = 0; 
            MathTotal = 0;
            ChineseAvg = 0;
            EngAvg = 0; 
            MathAvg = 0;
        }

        string NameShow;
        int num; 

        private void btnRandomSave_Click(object sender, EventArgs e) //隨機儲存資料
        {            
            btnEachSum.Enabled = true;
            RdmScore();           
        }

        

        int ChineseScore = 0, EngScore = 0, MathScore = 0;
        int ChineseTotal, EngTotal, MathTotal = 0;
        double ChineseAvg, EngAvg, MathAvg = 0;

        private void btnRandomAdd_Click(object sender, EventArgs e)
        {
         TwRdmScore();
        }

        int chineseScore = 0;
        int engScore = 0;
        int mathScore = 0;
        int totalScore = 0;
        double average = 0;

        int MaxChineseScore = 0;
        int MaxEngScore = 0;
        int MaxMathScore = 0;
        int MinChineseScore = 0;
        int MinEngScore = 0;
        int MinMathScore = 0;

        void TwRdmScore()
        {
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                stunum++;
                int chineseScore = rand.Next(0, 100);
                int engScore = rand.Next(0, 100);
                int mathScore = rand.Next(0, 100);
                int totalScore = chineseScore + engScore + mathScore;
                double average = totalScore / 3.0;
                string minSubject = "";
                int minScore = int.MaxValue;
                string maxSubject = "";
                int maxScore = int.MinValue;

                if (chineseScore < minScore)
                {
                    minSubject = "國文";
                    minScore = chineseScore;
                }
                if (chineseScore > maxScore)
                {
                    maxSubject = "國文";
                    maxScore = chineseScore;
                }
                if (engScore < minScore)
                {
                    minSubject = "英文";
                    minScore = engScore;
                }
                if (engScore > maxScore)
                {
                    maxSubject = "英文";
                    maxScore = engScore;
                }
                if (mathScore < minScore)
                {
                    minSubject = "數學";
                    minScore = mathScore;
                }
                if (mathScore > maxScore)
                {
                    maxSubject = "數學";
                    maxScore = mathScore;
                }

                labShow.Text += $"{stunum,-10} {chineseScore,-5} {engScore,-5} {mathScore,-5} {totalScore,-7}{average.ToString("F1"),-7}" +
                            $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";              
            }
        }
        void RdmScore()
        {
            Random rand = new Random();
            stunum++;
            int chineseScore = rand.Next(0, 100);
            int engScore = rand.Next(0, 100);
            int mathScore = rand.Next(0, 100);
            int totalScore = chineseScore + engScore + mathScore;
            double average = totalScore / 3.0;
            string minSubject = "";
            int minScore = int.MaxValue;
            string maxSubject = "";
            int maxScore = int.MinValue;
           
           
            if (chineseScore < minScore)
            {
                minSubject = "國文";
                minScore = chineseScore;
            }
            if (chineseScore > maxScore)
            {
                maxSubject = "國文";
                maxScore = chineseScore;
            }
            if (engScore < minScore)
            {
                minSubject = "英文";
                minScore = engScore;
            }
            if (engScore > maxScore)
            {
                maxSubject = "英文";
                maxScore = engScore;
            }
            if (mathScore < minScore)
            {
                minSubject = "數學";
                minScore = mathScore;
            }
            if (mathScore > maxScore)
            {
                maxSubject = "數學";
                maxScore = mathScore;
            }
            

            labShow.Text += $"{stunum,-10} {chineseScore,-5} {engScore,-5} {mathScore,-5} {totalScore,-7}{average.ToString("F1"),-7}" +
                            $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";
          
        }

        private void btnEachSum_Click(object sender, EventArgs e)   //各科統計
        {
            btnAddData.Enabled = false;
            btnRandomAdd.Enabled = false;
            btnRandomSave.Enabled = false;
            btnEachSum.Enabled = false;
            
                        
            ChineseAvg = ChineseTotal / stunum;
            EngAvg = EngTotal / stunum;
            MathAvg = MathTotal / stunum;


            labSum.Text = $"{"總分",-10} {ChineseTotal,-5} {EngTotal,-5}{MathTotal,-5}\n" +
                $"{"平均",-10} {ChineseAvg,-5} {EngAvg,-5}{MathAvg,-5}\n" +
                $"{"最高分",-9} {MaxChineseScore,-5} {MaxEngScore,-5}{MaxMathScore,-5}\n" +
                $"{"最高分",-9} {MinChineseScore,-5} {MinEngScore,-5}{MinMathScore,-5}";

        }
       int score = 0;

        private void btnAddData_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            { MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtChinese.Text == "")
            { MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtEnglish.Text == "")
            { MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtMath.Text == "")
            { MessageBox.Show("請輸入數學成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            
            bool isChi = int.TryParse(txtChinese.Text, out score);
            bool isEng = int.TryParse(txtEnglish.Text, out score);
            bool isMath = int.TryParse(txtMath.Text, out score);

            if (isChi == false)
            {
                txtChinese.Clear();
            } 
            else if(isEng==false)
                {
                txtEnglish.Clear();
            }
            else if (isMath == false)
            {
                txtMath.Clear();
            }
            else
            {
                ScoreAll(score);
            }
            btnEachSum.Enabled = true; 
        }

        string ScoreLine;
        void ScoreAll(int score)
        {   
            NameShow = txtName.Text;
            ChineseScore = int.Parse(txtChinese.Text);
            EngScore = int.Parse(txtEnglish.Text);
            MathScore = int.Parse(txtMath.Text);
            int TotalScore = ChineseScore + EngScore + MathScore;
            double Average = TotalScore / 3.0;

            int MaxChineseScore = ChineseScore;
            int MaxEngScore = EngScore;
            int MaxMathScore = MathScore;
            int MinChineseScore = ChineseScore;
            int MinEngScore = EngScore;
            int MinMathScore = MathScore;


            int[] Score = new int[] { ChineseScore, EngScore, MathScore };
            int maxScore = Score[0];
            int minScore = Score[0];
            string maxSubject = GetSubject(ChineseScore);
            string minSubject = GetSubject(ChineseScore);
            stunum++;
            for (int i = 0; i < Score.Length; i++)
            {
                if (Score[i] > maxScore)
                {
                    maxScore = Score[i];
                    maxSubject = GetSubject(Score[i]);
                }
                else if (Score[i] < minScore)
                {
                    minScore = Score[i];
                    minSubject = GetSubject(Score[i]);
                }
                if (i == 0)
                {
                    ChineseTotal += Score[i];
                    if (Score[i] > MaxChineseScore) MaxChineseScore = Score[i];
                    if (Score[i] < MinChineseScore) MinChineseScore = Score[i];
                }
                else if (i == 1)
                {
                    EngTotal += Score[i];
                    if (Score[i] > MaxEngScore) MaxEngScore = Score[i];
                    if (Score[i] < MinEngScore) MinEngScore = Score[i];
                }
                else if (i == 2)
                {
                    MathTotal += Score[i];
                    if (Score[i] > MaxMathScore) MaxMathScore = Score[i];
                    if (Score[i] < MinMathScore) MinMathScore = Score[i];
                }

            }

            labShow.Text += $"{NameShow,-10} {ChineseScore,-5} {EngScore,-5} {MathScore,-5} {TotalScore,-7}{Average.ToString("F1"),-7}" +
                $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";

            string GetSubject(int scoree)
            {
                if (scoree == MathScore)
                {
                    return "數學";
                }
                else if (scoree == ChineseScore)
                {
                    return "國文";
                }
                else
                {
                    return "英文";
                }
            }


        }

    }
}
