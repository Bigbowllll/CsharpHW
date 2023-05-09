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

        public string LabelText
        {
            get { return labName.Text; }
            set { labName.Text = value; }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            frm_inputbox frm = new frm_inputbox(this);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer:"+ GuessNum.guess);
        }
    }
}
