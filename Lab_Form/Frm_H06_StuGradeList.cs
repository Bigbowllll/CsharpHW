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

            foreach (Score src in scoreList)
            {
               
                labShow.Text += $"{src.Name,-10} {src.Chinscore,-5} {src.Engscore,-5} {src.MathScore,-5}{totalScore}\n";
                totalScore = src.Chinscore + src.MathScore + src.Engscore;
            }
           
        }

        List<Score> scoreList = new List<Score>();
        Score src;
        private void btnAddData_Click(object sender, EventArgs e)
        {
            
            src.Name = txtName.Text;
            src.Chinscore = int.Parse(txtChinese.Text);
            src.Engscore = int.Parse(txtEnglish.Text);
            src.MathScore = int.Parse(txtMath.Text);
            scoreList.Add(src);
            ShowScores();

        }
    }
}
