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
    public partial class Frm_H06_StuGradeList : Form
    {
        public Frm_H06_StuGradeList()
        {
            InitializeComponent();
            labShow.Parent = panel1;
        }

        

        void ShowScores()
        {
            labShow.Text = "";
            int totalScore = 0;
            double AvgScore = 0;
            string minSubject="";
            string maxSubject="";
            

            foreach (Score src in scoreList)
            {
                totalScore = src.Chinscore + src.MathScore + src.Engscore;
                AvgScore = totalScore / 3.0;
                int minScore = int.MaxValue;
                int maxScore = int.MinValue;

                if (src.Chinscore < minScore)
                {
                    minSubject = "國文";
                    minScore = src.Chinscore;
                }
                if (src.Chinscore > maxScore)
                {
                    maxSubject = "國文";
                    maxScore = src.Chinscore;
                }

                if (src.Engscore < minScore)
                {
                    minSubject = "英文";
                    minScore = src.Engscore;
                }
                if (src.Engscore > maxScore)
                {
                    maxSubject = "英文";
                    maxScore = src.Engscore;
                }

                if (src.MathScore < minScore)
                {
                    minSubject = "數學";
                    minScore = src.MathScore;
                }
                if (src.MathScore > maxScore)
                {
                    maxSubject = "數學";
                    maxScore = src.MathScore;
                }

                labShow.Text += $"{src.Name,-8} {src.Chinscore,-6} {src.Engscore,-6} {src.MathScore,-7}{totalScore,-7}{AvgScore.ToString("F1"),-7}" +
                                $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";
            }


        }

        List<Score> scoreList = new List<Score>();
        Score src;
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
            int score;

            bool isChi = int.TryParse(txtChinese.Text, out score);
            bool isEng = int.TryParse(txtEnglish.Text, out score);
            bool isMath = int.TryParse(txtMath.Text, out score);

            if (isChi == false)
            {
                txtChinese.Clear();
            }
            else if (isEng == false)
            {
                txtEnglish.Clear();
            }
            else if (isMath == false)
            {
                txtMath.Clear();
            }
            else
            {


                btnCleanData.Enabled = true;
                btnEachSum.Enabled = true;
                src.Name = txtName.Text;
                src.Chinscore = int.Parse(txtChinese.Text);
                src.Engscore = int.Parse(txtEnglish.Text);
                src.MathScore = int.Parse(txtMath.Text);
                scoreList.Add(src);
                ShowScores();
            }
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            { MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtChinese.Text == "")
            { MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtEnglish.Text == "")
            { MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (txtMath.Text == "")
            { MessageBox.Show("請輸入數學成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            int score;
            bool isChi = int.TryParse(txtChinese.Text, out score);
            bool isEng = int.TryParse(txtEnglish.Text, out score);
            bool isMath = int.TryParse(txtMath.Text, out score);

            if (isChi == false)
            {
                txtChinese.Clear();
            }
            else if (isEng == false)
            {
                txtEnglish.Clear();
            }
            else if (isMath == false)
            {
                txtMath.Clear();
            }
            else
            {
                btnCleanData.Enabled = true;
                btnEachSum.Enabled = true;
                src.Name = txtName.Text;
                src.Chinscore = int.Parse(txtChinese.Text);
                src.Engscore = int.Parse(txtEnglish.Text);
                src.MathScore = int.Parse(txtMath.Text);
                scoreList.Insert(0, src);
                ShowScores();
            }
        }

        private void btnCleanData_Click(object sender, EventArgs e)
        {
            scoreList.RemoveAt(0);
            ShowScores();
        }

        private void btnClearAllData_Click(object sender, EventArgs e)
        {
            btnAddData.Enabled = true;
            btnInsertData.Enabled = true;
            btnCleanData.Enabled = true;
            btnEachSum.Enabled = false;
            scoreList.Clear();
            ShowScores();
            labSum.Text = "";
        }


        private void btnEachSum_Click(object sender, EventArgs e)
        {
            btnEachSum.Enabled=false;
            btnAddData.Enabled = false;
            btnInsertData.Enabled = false;
            btnCleanData.Enabled = false;
            int totalChinese = 0, totalEnglish = 0, totalMath = 0;
            int minChinese = int.MaxValue, maxChinese = int.MinValue;
            int minEnglish = int.MaxValue, maxEnglish = int.MinValue;
            int minMath = int.MaxValue, maxMath = int.MinValue;
            int countChinese = 0, countEnglish = 0, countMath = 0;

            foreach (Score src in scoreList)
            {
                totalChinese += src.Chinscore;
                totalEnglish += src.Engscore;
                totalMath += src.MathScore;

                if (src.Chinscore < minChinese)
                {
                    minChinese = src.Chinscore;
                }

                if (src.Chinscore > maxChinese)
                {
                    maxChinese = src.Chinscore;
                }

                if (src.Engscore < minEnglish)
                {
                    minEnglish = src.Engscore;
                }

                if (src.Engscore > maxEnglish)
                {
                    maxEnglish = src.Engscore;
                }

                if (src.MathScore < minMath)
                {
                    minMath = src.MathScore;
                }

                if (src.MathScore > maxMath)
                {
                    maxMath = src.MathScore;
                }

                countChinese++;
                countEnglish++;
                countMath++;
            }

            double avgChinese = (double)totalChinese / countChinese;
            double avgEnglish = (double)totalEnglish / countEnglish;
            double avgMath = (double)totalMath / countMath;

                labSum.Text = $"{"總分",-10} {totalChinese,-5} {totalEnglish,-5}{totalMath,-5}\n" +
               $"{"平均",-10} {avgChinese.ToString("F1"),-5} {avgEnglish.ToString("F1"),-5}{avgMath.ToString("F1"),-5}\n" +
               $"{"最高分",-9} {maxChinese,-5} {maxEnglish,-5}{maxMath,-5}\n" +
               $"{"最低分",-9} {minChinese,-5} {minEnglish,-5}{minMath,-5}";
        }

        void ShowSearchSrc()
        {
            labShow.Text = "";
            int totalScore = 0;
            double AvgScore = 0;
            string minSubject = "";
            string maxSubject = "";
            int end;
            int start;
            end = int.Parse(txtSearchEnd.Text);
            start = int.Parse(txtSearchStart.Text);

            foreach (Score src in scoreList)
            {
                if (src.Chinscore >= start && src.Chinscore <= end) // 判斷國文成績是否在50-80分之間
                {
                    totalScore = src.Chinscore + src.MathScore + src.Engscore;
                    AvgScore = totalScore / 3.0;
                    int minScore = int.MaxValue;
                    int maxScore = int.MinValue;

                    if (src.Chinscore < minScore)
                    {
                        minSubject = "國文";
                        minScore = src.Chinscore;
                    }
                    if (src.Chinscore > maxScore)
                    {
                        maxSubject = "國文";
                        maxScore = src.Chinscore;
                    }

                    if (src.Engscore < minScore)
                    {
                        minSubject = "英文";
                        minScore = src.Engscore;
                    }
                    if (src.Engscore > maxScore)
                    {
                        maxSubject = "英文";
                        maxScore = src.Engscore;
                    }

                    if (src.MathScore < minScore)
                    {
                        minSubject = "數學";
                        minScore = src.MathScore;
                    }
                    if (src.MathScore > maxScore)
                    {
                        maxSubject = "數學";
                        maxScore = src.MathScore;
                    }

                    labShow.Text += $"{src.Name,-8} {src.Chinscore,-6} {src.Engscore,-6} {src.MathScore,-7}{totalScore,-7}{AvgScore.ToString("F1"),-7}" +
                                    $"{minSubject}{minScore,-5}{maxSubject}{maxScore}\n";
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearchSrc();
        }
    }
}
