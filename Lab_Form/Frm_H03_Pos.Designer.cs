namespace Lab_Form
{
    partial class Frm_H03_Pos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_H03_Pos));
            this.labMenu = new System.Windows.Forms.Label();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.BtnRedWine = new System.Windows.Forms.Button();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labPaymentWay = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.labCardis = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.labPrice = new System.Windows.Forms.Label();
            this.labShoppingList = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labMenu.Location = new System.Drawing.Point(39, 30);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(319, 381);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Menu";
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(58, 78);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(120, 147);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒 \r\nBeer\r\nNT$120\r\n";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Location = new System.Drawing.Point(207, 78);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(120, 147);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\r\nTequlia\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(58, 243);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(120, 147);
            this.btnWhisky.TabIndex = 3;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // BtnRedWine
            // 
            this.BtnRedWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRedWine.BackgroundImage")));
            this.BtnRedWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRedWine.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRedWine.ForeColor = System.Drawing.Color.Black;
            this.BtnRedWine.Location = new System.Drawing.Point(207, 243);
            this.BtnRedWine.Name = "BtnRedWine";
            this.BtnRedWine.Size = new System.Drawing.Size(120, 147);
            this.BtnRedWine.TabIndex = 4;
            this.BtnRedWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.BtnRedWine.UseVisualStyleBackColor = true;
            this.BtnRedWine.Click += new System.EventHandler(this.BtnRedWine_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(380, 78);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(297, 101);
            this.labTotalPrice.TabIndex = 5;
            this.labTotalPrice.Text = "總金額 Total Price";
            // 
            // labPaymentWay
            // 
            this.labPaymentWay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labPaymentWay.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPaymentWay.Location = new System.Drawing.Point(380, 213);
            this.labPaymentWay.Name = "labPaymentWay";
            this.labPaymentWay.Size = new System.Drawing.Size(297, 160);
            this.labPaymentWay.TabIndex = 6;
            this.labPaymentWay.Text = "付款方式";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(408, 257);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(109, 58);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(538, 257);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(109, 58);
            this.btnCard.TabIndex = 8;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // labCardis
            // 
            this.labCardis.BackColor = System.Drawing.Color.White;
            this.labCardis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCardis.Font = new System.Drawing.Font("微軟正黑體", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCardis.Location = new System.Drawing.Point(538, 328);
            this.labCardis.Name = "labCardis";
            this.labCardis.Size = new System.Drawing.Size(109, 32);
            this.labCardis.TabIndex = 9;
            this.labCardis.Text = "信用卡享九折!";
            this.labCardis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labList.Location = new System.Drawing.Point(697, 34);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(352, 403);
            this.labList.TabIndex = 10;
            this.labList.Text = "購物清單 List";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("微軟正黑體", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClean.Location = new System.Drawing.Point(934, 395);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(91, 30);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "清除清單";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.Color.Black;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 19.69811F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.ForeColor = System.Drawing.Color.White;
            this.labPrice.Location = new System.Drawing.Point(464, 121);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(198, 41);
            this.labPrice.TabIndex = 13;
            this.labPrice.Text = "NT $0";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labShoppingList
            // 
            this.labShoppingList.BackColor = System.Drawing.Color.White;
            this.labShoppingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShoppingList.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShoppingList.ForeColor = System.Drawing.Color.Black;
            this.labShoppingList.Location = new System.Drawing.Point(718, 78);
            this.labShoppingList.Name = "labShoppingList";
            this.labShoppingList.Size = new System.Drawing.Size(307, 299);
            this.labShoppingList.TabIndex = 16;
            this.labShoppingList.Text = "尚未購買";
            this.labShoppingList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listProducts
            // 
            this.listProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listProducts.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 27;
            this.listProducts.Items.AddRange(new object[] {
            "尚未購買"});
            this.listProducts.Location = new System.Drawing.Point(718, 78);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(307, 299);
            this.listProducts.TabIndex = 15;
            // 
            // Frm_H03_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 531);
            this.Controls.Add(this.labShoppingList);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.labCardis);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labPaymentWay);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.BtnRedWine);
            this.Controls.Add(this.btnWhisky);
            this.Controls.Add(this.btnTequila);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.labMenu);
            this.Name = "Frm_H03_Pos";
            this.Text = "Bar Pos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button BtnRedWine;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labPaymentWay;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label labCardis;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labShoppingList;
        private System.Windows.Forms.ListBox listProducts;
    }
}