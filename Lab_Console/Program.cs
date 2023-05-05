using Lab_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓名：");  //write:不換行 writeline:換行
            string Name = Console.ReadLine();  //變數資料 使用者輸入
            Console.WriteLine("Hello C#! " + Name);  // "string" char:'B'

            MyClass mc = new MyClass();  //如需引用其他專案namespace，先加入參考
            mc.Method04();
            
            Console.ReadKey();


        }
    }
}
