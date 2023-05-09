
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
    public partial class Frm_OpenEvent : Form
    {
        public Frm_OpenEvent()
        {
            InitializeComponent();
        }
        private Form currentForm = null;

        private void OpenFormInPanel(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;           
            splitContainer2.Panel2.Controls.Add(form);
            form.Show();
        }
        static bool helloform=true;
        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {           
          Frm_H01_HelloForm frm = new Frm_H01_HelloForm();            
          frm.StartPosition = FormStartPosition.CenterParent; 
          frm.TopLevel = false;
          splitContainer2.Panel2.Controls.Add(frm);
          OpenFormInPanel(frm); 
         
        }

        private void btnOpenLoanCalc_Click(object sender, EventArgs e)
        {
            Frm_H02_LoanCal frm = new Frm_H02_LoanCal();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnOpenPos_Click(object sender, EventArgs e)
        {
            Frm_H03_Pos frm = new Frm_H03_Pos();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnOpenStructForm_Click(object sender, EventArgs e)
        {
            Frm_H04_SrtuctForm frm = new Frm_H04_SrtuctForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_H08_MyClac frm = new Frm_H08_MyClac();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnStuGrade_Click(object sender, EventArgs e)
        {
            Frm_H05_StudentsGrade frm= new Frm_H05_StudentsGrade();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Frm_H07_Method frm= new Frm_H07_Method();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Frm_H12_Notepad frm= new Frm_H12_Notepad();
            frm.Show();
        }

        private void Frm_OpenEvent_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnStuGradeList_Click(object sender, EventArgs e)
        {
            Frm_H06_StuGradeList frm = new Frm_H06_StuGradeList();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }

        private void btnGuessNum_Click(object sender, EventArgs e)
        {
            Frm_H15_GuessNum frm = new Frm_H15_GuessNum();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            OpenFormInPanel(frm);
        }
               
       
        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Frm_H11_ScreenSaver frm = new Frm_H11_ScreenSaver();
            frm.Show();
        }
    }
}
