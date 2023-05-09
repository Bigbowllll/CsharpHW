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
    public partial class Frm_H09_ForDoWhile : Form
    {
        public Frm_H09_ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = string.Empty;
            labShow.Text = "結果";
        }
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            //換位前 n1=100 , n2=200

            int a = 100, b = 200, n1 = 100, n2 = 200;
            Swap(ref a, ref b);
            labShow.Text = ($"換位前n1={n1} , n2={n2}\n換位後n1={a} , n2={b}");


            //labShow.Text = ($"a:{a},b:{b}");
        }

        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show($"請輸入數值");
                txtNumber.Clear();
            }
            else
            {

                if (int.Parse(txtNumber.Text) % 2 == 0)
                {
                    labShow.Text = ($"輸入的數 {txtNumber.Text}為 偶數。");
                }
                else
                {
                    labShow.Text = ($"輸入的數 {txtNumber.Text}為 奇數。");
                }

            }
        }

        private void btnCountOddEven_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in arr0711)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            labShow.Text = $"int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
                $"奇數共 {evenCount}\n偶數共 {oddCount}";
        }

        private void btnLongName_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "Emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string longestName = arr0711_Str[0];
            foreach (string name in arr0711_Str)
            {
                if (name.Length > longestName.Length)
                {
                    longestName = name;
                }
            }
            labShow.Text = $"陣列 arr0711_str [ mother張, Emma, 迪克蕭, J40]\n" +
                $"最長的名字為{longestName}";
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr0711[0];
            int max = arr0711[0];

            foreach (int num in arr0711)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            labShow.Text = $"int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
               $"最大值為{max}\n最小值為{min}";

        }

        private void btnCountC_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "Emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int countC = 0;
            foreach (string str in arr0711_Str)
            {
                foreach (char c in str)
                {
                    if (c == 'c' || c == 'C')
                    {
                        countC++;
                        break;
                    }
                }
            }
            labShow.Text = $"arr0711_str陣列 : mother張, Emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker\n" +
                $"有C 及 c的名字共有 {countC} 個";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = 0;
            foreach (int num in arr0711)
            {
                sum += num;
            }

            labShow.Text = $"int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
               $"加總為 {sum}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr0711[0];

            foreach (int num in arr0711)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            labShow.Text = $"int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
               $"最大值為 {max}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr0711[0];
            foreach (int num in arr0711)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            labShow.Text = $"int陣列arr0711[ 1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n" +
               $"最小值為 {min}";
        }

        private void btntwodense10_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            // Fill 0s
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            // Fill 1s
            for (int i = 0; i < 10; i++)
            {
                matrix[i, 0] = 1;
                matrix[i, 9] = 1;
                matrix[0, i] = 1;
                matrix[9, i] = 1;
            }


            string result = "";
            //巢狀迴圈:顯示各二維矩陣裡的內容
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, count = 0; j < matrix.GetLength(1); j++, count++)
                {
                    result += $"{matrix[i, j]} ";
                    if (count == 9)
                    {
                        result += "\n";
                        count = -1;
                    }
                }
            }
            labShow.Text = result;




        }

        private void btntwodense01_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                matrix[i, 0] = 0;
                matrix[i, 9] = 0;
                matrix[0, i] = 0;
                matrix[9, i] = 0;
            }

            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, count = 0; j < matrix.GetLength(1); j++, count++)
                {
                    result += $"{matrix[i, j]} ";
                    if (count == 9)
                    {
                        result += "\n";
                        count = -1;
                    }
                }

                labShow.Text = result;
            }
        }

        private void btntwdense_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                matrix[i, 0] = 0;
                matrix[i, 9] = 0;
                matrix[0, i] = 0;
                matrix[9, i] = 0;
            }

            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, count = 0; j < matrix.GetLength(1); j++, count++)
                {
                    if (i % 2 == 0)
                    {
                        result += count % 2 == 0 ? "0 " : "1 ";
                    }
                    else
                    {
                        result += count % 2 == 0 ? "1 " : "0 ";
                    }
                    if (count == 9)
                    {
                        result += "\n";
                        count = -1;
                    }
                }

                labShow.Text = result;
            }
        }
    }
}
