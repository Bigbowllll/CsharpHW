namespace Lab_Loan
{
    partial class Frm_LoanCal_M01
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labLoanPrice = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFirstPrice = new System.Windows.Forms.Label();
            this.txtLoanPrice = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtFirstPrice = new System.Windows.Forms.TextBox();
            this.btnMonPaid = new System.Windows.Forms.Button();
            this.btnTotalPaid = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoanPrice
            // 
            this.labLoanPrice.AutoSize = true;
            this.labLoanPrice.BackColor = System.Drawing.Color.Transparent;
            this.labLoanPrice.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanPrice.Location = new System.Drawing.Point(156, 57);
            this.labLoanPrice.Name = "labLoanPrice";
            this.labLoanPrice.Size = new System.Drawing.Size(123, 34);
            this.labLoanPrice.TabIndex = 0;
            this.labLoanPrice.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BackColor = System.Drawing.Color.Transparent;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(156, 114);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(114, 34);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.Transparent;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(156, 180);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(111, 34);
            this.labRate.TabIndex = 2;
            this.labRate.Text = "利率(%)";
            // 
            // labFirstPrice
            // 
            this.labFirstPrice.AutoSize = true;
            this.labFirstPrice.BackColor = System.Drawing.Color.Transparent;
            this.labFirstPrice.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirstPrice.Location = new System.Drawing.Point(156, 244);
            this.labFirstPrice.Name = "labFirstPrice";
            this.labFirstPrice.Size = new System.Drawing.Size(96, 34);
            this.labFirstPrice.TabIndex = 3;
            this.labFirstPrice.Text = "頭期款";
            // 
            // txtLoanPrice
            // 
            this.txtLoanPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanPrice.Location = new System.Drawing.Point(302, 56);
            this.txtLoanPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoanPrice.Name = "txtLoanPrice";
            this.txtLoanPrice.Size = new System.Drawing.Size(167, 35);
            this.txtLoanPrice.TabIndex = 4;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(302, 180);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(167, 35);
            this.txtRate.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(302, 117);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(167, 35);
            this.txtYear.TabIndex = 6;
            // 
            // txtFirstPrice
            // 
            this.txtFirstPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstPrice.Location = new System.Drawing.Point(302, 243);
            this.txtFirstPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstPrice.Name = "txtFirstPrice";
            this.txtFirstPrice.Size = new System.Drawing.Size(167, 35);
            this.txtFirstPrice.TabIndex = 7;
            // 
            // btnMonPaid
            // 
            this.btnMonPaid.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonPaid.Location = new System.Drawing.Point(156, 328);
            this.btnMonPaid.Name = "btnMonPaid";
            this.btnMonPaid.Size = new System.Drawing.Size(140, 65);
            this.btnMonPaid.TabIndex = 8;
            this.btnMonPaid.Text = "PTM(月付款)";
            this.btnMonPaid.UseVisualStyleBackColor = true;
            this.btnMonPaid.Click += new System.EventHandler(this.btnMonPaid_Click);
            // 
            // btnTotalPaid
            // 
            this.btnTotalPaid.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPaid.Location = new System.Drawing.Point(329, 328);
            this.btnTotalPaid.Name = "btnTotalPaid";
            this.btnTotalPaid.Size = new System.Drawing.Size(140, 65);
            this.btnTotalPaid.TabIndex = 9;
            this.btnTotalPaid.Text = "總付款";
            this.btnTotalPaid.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(557, 328);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 65);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // Frm_LoanCal_M01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPaid);
            this.Controls.Add(this.btnMonPaid);
            this.Controls.Add(this.txtFirstPrice);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLoanPrice);
            this.Controls.Add(this.labFirstPrice);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoanPrice);
            this.Name = "Frm_LoanCal_M01";
            this.Text = "貸款金額計算";
            this.Load += new System.EventHandler(this.Frm_LoanCal_M01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoanPrice;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFirstPrice;
        private System.Windows.Forms.TextBox txtLoanPrice;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtFirstPrice;
        private System.Windows.Forms.Button btnMonPaid;
        private System.Windows.Forms.Button btnTotalPaid;
        private System.Windows.Forms.Button btnReport;
    }
}

