using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_H11_ScreenSaver : Form
    {
        public Frm_H11_ScreenSaver()
        {
            InitializeComponent();
            lastMousePosition = Cursor.Position;
        }

        private void Frm_H11_ScreenSaver_Load(object sender, EventArgs e)
        {
            string gif = @"C:\Bigbowl\Csharp\Hw_Csharp\Lab_Form\Image\screensaver01.gif";
            PbLala.Image = Image.FromFile(gif);
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            Cursor.Hide();
            timer1.Enabled = true;
            timer1.Interval = 20;
        }

        int dx = 5;
        int dy = 5;
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = PbLala.Location.X;
            int y = PbLala.Location.Y;
                      
            x += dx;
            y += dy;

           if (x < 0 || x + PbLala.Width > this.ClientSize.Width)
            {
                dx = -dx;
            }
            if (y < 0 || y + PbLala.Height > this.ClientSize.Height)
            {
                dy = -dy;
            }
                     
            PbLala.Location = new Point(x, y);
        }
        
        public Point lastMousePosition;


        private void Frm_H11_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {

            Point currentMousePosition = Cursor.Position;
            int distance = (int)Math.Sqrt(
                Math.Pow(currentMousePosition.X - lastMousePosition.X, 2) +
                Math.Pow(currentMousePosition.Y - lastMousePosition.Y, 2));
            if (distance > 50) // 如果滑鼠移動距離超過 50 像素，則關閉程式
            {
                this.Close();
                Cursor.Show();
            }
            lastMousePosition = currentMousePosition;
        }
    }
}
