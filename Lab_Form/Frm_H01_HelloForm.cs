using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab_Form
{
    public partial class Frm_H01_HelloForm : Form
    {
        public Frm_H01_HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string engname = txtEngName.Text;
            string gender = txtGender.Text;
            string sign = txtSign.Text;
            MessageBox.Show("Hello, 我是 " + name + "\r\n"+ "英文名字是  " + engname + "\r\n" +  "性別是 " + gender + "\r\n" + "星座是 " + sign + "\r\n" + "Nice to meet you!!"); 
            
        }

        //todo 待完成...

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string engname = txtEngName.Text;
            string gender = txtGender.Text;
            string sign = txtSign.Text;
            MessageBox.Show("Hi, 我是 " + name + Environment.NewLine +
                 "英文名字是  " + engname + Environment.NewLine +
                "性別是 " + gender + Environment.NewLine +
                "星座是 " + sign + Environment.NewLine +
                "Nice to meet you!!");
        }
    }
}
