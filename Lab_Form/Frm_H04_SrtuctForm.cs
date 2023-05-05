using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class Frm_H04_SrtuctForm : Form
    {
        public Frm_H04_SrtuctForm()
        {
            InitializeComponent();
        }
        static bool SaveButton = false;

        int ChineseScore = 0, EngScore = 0, MathScore = 0;
        string ScoreShow,NameShow;

        private void btnSave_Click(object sender, EventArgs e)
        {
                       
            SaveButton = true;
           
            NameShow = txtName.Text;            
            ChineseScore = int.Parse(txtChinese.Text);
            EngScore = int.Parse(txtEnglish.Text);
            MathScore = int.Parse(txtMath.Text);

            ScoreShow = "姓名：" + NameShow + "\n國文：" + ChineseScore + "分" +
                "\n英文：" + EngScore + "分" + "\n數學：" + MathScore + "分";

        }

                

        private void btnShow_Click(object sender, EventArgs e)
        {
            labScore.Text = "姓名：" + "\n國文：0分" + "\n英文：0分" + "\n數學：0分";
            if (SaveButton == true)
            {
                labScore.Text = ScoreShow;
            }
        }
        
        private void btnHighLow_Click(object sender, EventArgs e)
        {
            labHighLowScore.Text = "最高科目成績為：數學0分" + "\n最低科目成績為：數學0分";
            if (SaveButton == true)
            {                
                int[] Score = new int[] { ChineseScore, EngScore, MathScore };
                int maxScore = Score[0];
                int minScore = Score[0];
                string maxSubject = GetSubject(ChineseScore);
                string minSubject = GetSubject(ChineseScore);

                for (int i = 1; i < Score.Length; i++)
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
                }

                labHighLowScore.Text = "最高科目成績為：" + maxSubject + maxScore + "分" + "\r\n" +
                                       "最低科目成績為：" + minSubject + minScore + "分";


                string GetSubject(int score)
                {
                    if (score ==MathScore)
                    {
                        return "數學";
                    }
                    else if (score ==ChineseScore)
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
    }

