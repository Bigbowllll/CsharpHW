using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    partial class MyClass //使用partial class 時，要設定一樣的類別 ，讓Utility.cs可以共同編輯同一個類別
    {
        public void Method06()
        {
            MessageBox.Show("Method06 Partial Class");
        }
    }
}
