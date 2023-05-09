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
        private List<int> ChineseScores = new List<int>();
        private List<int> EngScores = new List<int>();
        private List<int> MathScores = new List<int>();

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
            chineseTotal = chineseScoreTotal = 0;
            engTotal = engScoreTotal = 0;
            mathTotal =mathScoreTotal= 0;
            chineseScore = 0;
            engScore = 0;
            mathScore = 0;
            chineseAvg = 0;
            engAvg = 0;
            mathAvg = 0;
            ChineseScores.Clear();
            EngScores.Clear();
            MathScores.Clear();


        }

        string NameShow;
        int num; 

        private void btnRandomSave_Click(object sender, EventArgs e) //隨機儲存資料
        {            
            btnEachSum.Enabled = true;
            RdmScore();
            ChineseScores.Add(chineseScore);
            EngScores.Add(engScore);
            MathScores.Add(mathScore);
            labShow.Text += $"{stunum,-10} {chineseScore,-5} {engScore,-5} {mathScore,-5} {totalScore,-7}{average.ToString("F1"),-7}" +
                         $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";
        }



        int ChineseScore;
        int EngScore;
        int MathScore;
        int ChineseTotal;
        int EngTotal;
        int MathTotal;
        double ChineseAvg;
        double EngAvg;
        double MathAvg;

        private void btnRandomAdd_Click(object sender, EventArgs e)
        {
            btnEachSum.Enabled = true;
            TwRdmScore();
            ChineseScores.Add(chineseScore);
            EngScores.Add(engScore);
            MathScores.Add(mathScore);
        }

        int chineseScore;
        int engScore;
        int mathScore;
        int totalScore;
        double average;

        int maxChineseScore=0;
        int maxEngScore=0;
        int maxMathScore = 0;
        int minChineseScore = 100;
        int minEngScore = 100;
        int minMathScore = 100;

        private int chineseScoreTotal = 0;
        private int engScoreTotal = 0;
        private int mathScoreTotal = 0;
        int chinsrc;
        int engsrc;
        int mathsrc;

        

        void TwRdmScore()
        {
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                stunum++;
                chineseScore = rand.Next(0, 100);
                engScore = rand.Next(0, 100);
                mathScore = rand.Next(0, 100);
                totalScore = chineseScore + engScore + mathScore;
                average = totalScore / 3.0;
                 minSubject = "";
                 minScore = int.MaxValue;
                 maxSubject = "";
                 maxScore = int.MinValue;
                chineseScoreTotal += chineseScore;
                engScoreTotal += engScore;
                mathScoreTotal += mathScore;
                chinsrc = chineseScore;
                engsrc =engScore;
                mathsrc = mathScore;

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
             chineseScore = rand.Next(0, 100);
             engScore = rand.Next(0, 100);
             mathScore = rand.Next(0, 100);
             totalScore = chineseScore + engScore + mathScore;
             average = totalScore / 3.0;
             minSubject = "";
            minScore = int.MaxValue;
             maxSubject = "";
             maxScore = int.MinValue;
            chineseScoreTotal += chineseScore;
            engScoreTotal += engScore;
            mathScoreTotal += mathScore;
            chinsrc = chineseScore;
            engsrc = engScore;
            mathsrc = mathScore;


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
           
        }
     
        int chineseTotal;
        int engTotal;
        int mathTotal;
        double chineseAvg;
        double engAvg;
        double mathAvg;

        private void btnEachSum_Click(object sender, EventArgs e)   //各科統計
        {
            btnAddData.Enabled = false;
            btnRandomAdd.Enabled = false;
            btnRandomSave.Enabled = false;
            btnEachSum.Enabled = false;
            chineseTotal = chineseScoreTotal;
            engTotal =  engScoreTotal;
            mathTotal = mathScoreTotal;
            chineseAvg = (double)chineseTotal / (stunum);
            engAvg = (double)engTotal / (stunum);
            mathAvg = (double)mathTotal / (stunum);

            maxChineseScore = ChineseScores.Max();
            maxEngScore = EngScores.Max();
           maxMathScore = MathScores.Max();
           minChineseScore = ChineseScores.Min();
            minEngScore = EngScores.Min();
            minMathScore = MathScores.Min();


            labSum.Text = $"{"總分",-10} {chineseTotal,-5} {engTotal,-5}{mathTotal,-5}\n" +
                $"{"平均",-10} {chineseAvg.ToString("F1"),-5} {engAvg.ToString("F1"),-5}{mathAvg.ToString("F1"),-5}\n" +
                $"{"最高分",-9} {maxChineseScore,-5} {maxEngScore,-5}{maxMathScore,-5}\n" +
                $"{"最低分",-9} {minChineseScore,-5} {minEngScore,-5}{minMathScore,-5}";

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
                labShow.Text += $"{NameShow,-10} {ChineseScore,-5} {EngScore,-5} {MathScore,-5} {TotalScore,-7}{Average.ToString("F1"),-7}" +
                  $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";
            }
            btnEachSum.Enabled = true; 
        }

        string ScoreLine;
        int TotalScore;
        double Average;
        int MaxChineseScore;
        int MaxEngScore;
        int MaxMathScore;
        int MinChineseScore;
        int MinEngScore;
        int MinMathScore;
        int maxScore;
        int minScore;
        string maxSubject;
        string minSubject;

        void ScoreAll(int score)
        {   
            NameShow = txtName.Text;
            ChineseScore = int.Parse(txtChinese.Text);
            EngScore = int.Parse(txtEnglish.Text);
            MathScore = int.Parse(txtMath.Text);
            TotalScore = ChineseScore + EngScore + MathScore;
            Average = TotalScore / 3.0;

            chineseScoreTotal += ChineseScore;
            engScoreTotal += EngScore;
            mathScoreTotal += MathScore;

             MaxChineseScore = ChineseScore;
             MaxEngScore = EngScore;
             MaxMathScore = MathScore;
             MinChineseScore = ChineseScore;
             MinEngScore = EngScore;
             MinMathScore = MathScore;

            ChineseScores.Add(ChineseScore);
            EngScores.Add(EngScore);
            MathScores.Add(MathScore);



            int[] Score = new int[] { ChineseScore, EngScore, MathScore };
             maxScore = Score[0];
             minScore = Score[0];
             maxSubject = GetSubject(ChineseScore);
             minSubject = GetSubject(ChineseScore);
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
