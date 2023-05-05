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
    public partial class Frm_H12_Notepad : Form
    {
        public Frm_H12_Notepad()
        {
            InitializeComponent();           
        }

       

        private void tsmOpenO_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtWrite.ForeColor = colorDialog1.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.ForeColor = Color.Black;
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.Paste();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            txtWrite.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            txtWrite.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            txtWrite.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtWrite.SelectAll();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtWrite.Font = fontDialog1.Font;
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = txtWrite.Text;
            string output = input.ToUpper();                      
            txtWrite.Text = output;
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = txtWrite.Text;
            string output = input.ToLower();
            txtWrite.Text = output;
        }

        bool tool = true;
        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tool)
            {
                txtWrite.WordWrap = false;
                txtWrite.ScrollBars = ScrollBars.Both;
            }
            else
            {
                txtWrite.WordWrap = true;
            }
            tool = !tool;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.Show();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.Show();
        }
    }
}
