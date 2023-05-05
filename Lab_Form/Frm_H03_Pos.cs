using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class Frm_H03_Pos : Form
    {

        private List<string> items = new List<string>();
        public Frm_H03_Pos()
        {
            InitializeComponent();
        }

        int beer, tequila, whisky, wine, totalprice = 0;
        double cardprice = 0;
        int numb, numt, numwh, numw = 0;
        string Display, BeerDisplay, WineDisplay, TeqDisplay, WhiskyDisplay;
        

        private void btnCash_Click(object sender, EventArgs e)
        {

            if (totalprice > 0)
            {
                totalprice = beer + tequila + whisky + wine;
                MessageBox.Show("總金額 : NT$" + totalprice, "確認付款", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("總金額 : NT$" + totalprice, "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("總金額 : NT$" + totalprice, "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cardprice = (beer + tequila + whisky + wine) * 0.9;
                totalprice = beer + tequila + whisky + wine;
                MessageBox.Show("總金額 : NT$" + totalprice + "\r\n" + "折扣後金額 : NT$" + cardprice, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnClean_Click(object sender, EventArgs e) //清除清單和金額重新計算
        {
            //重置總金額&清單
            labPrice.Text = string.Empty;
            ButtonClean(out beer);
            


        }

        void ButtonClean(out int beer)
        {
            beer = 0;
            tequila = 0;
            whisky = 0;
            wine = 0;
            totalprice = 0;
            numb = numt = numw = numwh = 0;
            labPrice.Text = "NT $0";
            labShoppingList.Text = "尚未購買";
            BeerDisplay = "";
            TeqDisplay = "";
            WhiskyDisplay="";
             WineDisplay="" ;
            RedWineButtonClick = false;
           BeerButtonClick = false;
           WhiskyButtonClick = false;
           TequilaButtonClick = false;
           
        }

        static bool RedWineButtonClick = false;
        static bool BeerButtonClick = false;
        static bool WhiskyButtonClick = false;
        static bool TequilaButtonClick = false;

        private void BtnRedWine_Click(object sender, EventArgs e)
        {
            RedWineButtonClick = true;
            wine += 320;
            totalprice = beer + tequila + whisky + wine;
            labPrice.Text = "NT $ " + totalprice;

            numw += 1;

            WineDisplay = "紅酒Red Wine x" + numw + ",共NT $" + wine + "元"+Environment.NewLine;
            Display = BeerDisplay + TeqDisplay + WhiskyDisplay + WineDisplay;
            labShoppingList.Text = Display;


            //ShopList(numt);
           
        }
      




    private void btnWhisky_Click(object sender, EventArgs e)
        {
            WhiskyButtonClick = true;
            whisky +=350;
            totalprice = beer + tequila+whisky+wine;
            labPrice.Text = "NT $ " + totalprice;

            numwh += 1;

            WhiskyDisplay = "威士忌Whisky x" + numwh + ",共NT $" + whisky + "元" + Environment.NewLine;
            Display = BeerDisplay + TeqDisplay + WhiskyDisplay + WineDisplay;
            labShoppingList.Text = Display;

            //ShopList(numt);
           

        }

       
        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeerButtonClick = true;
            //beer:120 Tequila:180 Whisky:350 Wine:320
            beer += 120;
            totalprice = beer + tequila + whisky + wine;
            labPrice.Text = "NT $ " + totalprice;

            numb += 1;

            BeerDisplay = "啤酒Beer x" + numb + ",共NT $" + beer + "元" + Environment.NewLine;
            Display = BeerDisplay + TeqDisplay +  WhiskyDisplay + WineDisplay;            
            labShoppingList.Text = Display;

            //ShopList(numt);
            

        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            TequilaButtonClick = true;
            tequila += 180;
            totalprice = beer + tequila + whisky + wine;
            labPrice.Text = "NT $ " + totalprice;
            numt += 1;

            TeqDisplay = "龍舌蘭 Tequlia x" + numt + ",共NT $" + tequila + "元" + Environment.NewLine;
            Display = BeerDisplay  + TeqDisplay + WhiskyDisplay  + WineDisplay;            
            labShoppingList.Text = Display;

            //ShopList(numt);
            

        }

       void ShopList(int numt)
        {
            string sBeer = "啤酒Beer x" + numb + ",共NT $" + beer + "元";
            string sWine="紅酒Red Wine x" + numw + ",共NT $" + wine + "元";
            string sWhisky="威士忌Whisky x" + numwh + ",共NT $" + whisky + "元";
            string sTeq="龍舌蘭 Tequlia x" + numt + ",共NT $" + tequila + "元";
            if (BeerButtonClick == true)
            {
                labShoppingList.Text = sBeer;
            }
            if (RedWineButtonClick == true)
            {
                labShoppingList.Text = sWine;
            }
            if (WhiskyButtonClick == true)
            {
                labShoppingList.Text = sWhisky;
            }
            if (TequilaButtonClick == true)
            {
                labShoppingList.Text = sTeq;
            }
            if(BeerButtonClick == true&&TequilaButtonClick==true) {
                labShoppingList.Text=sBeer+"\r\n"+sTeq;
            }
            if (BeerButtonClick == true && WhiskyButtonClick == true)
            {
                labShoppingList.Text = sBeer + "\r\n" + sWhisky;
            }
            if (BeerButtonClick == true && RedWineButtonClick == true)
            {
                labShoppingList.Text = sBeer + "\r\n" + sWine;
            }
            if (TequilaButtonClick == true && WhiskyButtonClick == true)
            {
                labShoppingList.Text = sTeq + "\r\n" + sWhisky;
            }
            if (TequilaButtonClick == true && RedWineButtonClick == true)
            {
                labShoppingList.Text = sTeq + "\r\n" + sWine;
            }
            if (WhiskyButtonClick == true && RedWineButtonClick == true)
            {
                labShoppingList.Text = sWhisky + "\r\n" + sWine;
            }
            if (BeerButtonClick == true && TequilaButtonClick == true && WhiskyButtonClick==true)
            {
                labShoppingList.Text = sBeer + "\r\n" + sTeq+"\r\n"+sWhisky;
            }
            if (TequilaButtonClick == true && WhiskyButtonClick == true&& RedWineButtonClick == true)
            {
                labShoppingList.Text = sTeq + "\r\n" + sWhisky+ "\r\n"+sWine;
            }
            if (BeerButtonClick == true && TequilaButtonClick == true && WhiskyButtonClick == true&& RedWineButtonClick == true)
            {
                labShoppingList.Text = sBeer + "\r\n" + sTeq + "\r\n" + sWhisky + "\r\n"+sWine;
            }


        }
           
        

            //"龍舌蘭 Tequlia x" + numt + ",共NT $" + tequila + "元" + Environment.NewLine;
            //"威士忌Whisky x" + numwh + ",共NT $" + whisky + "元"+ Environment.NewLine +
            //"紅酒Red Wine x" + numw + ",共NT $" + wine + "元";
        
        }

       
    
}

