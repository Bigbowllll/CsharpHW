namespace Lab_Form
{
    partial class Frm_H01_HelloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_H01_HelloForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.labEngName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labSign = new System.Windows.Forms.Label();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtSign = new System.Windows.Forms.TextBox();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(641, 109);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 35);
            this.txtName.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.Control;
            this.labName.Location = new System.Drawing.Point(556, 112);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 27);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名：";
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSayHello.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(578, 334);
            this.btnSayHello.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(126, 73);
            this.btnSayHello.TabIndex = 2;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.ForeColor = System.Drawing.SystemColors.Control;
            this.labEngName.Location = new System.Drawing.Point(556, 161);
            this.labEngName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(168, 27);
            this.labEngName.TabIndex = 3;
            this.labEngName.Text = "English Name：";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.SystemColors.Control;
            this.labGender.Location = new System.Drawing.Point(556, 213);
            this.labGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(75, 27);
            this.labGender.TabIndex = 4;
            this.labGender.Text = "性別：";
            // 
            // labSign
            // 
            this.labSign.AutoSize = true;
            this.labSign.BackColor = System.Drawing.Color.Transparent;
            this.labSign.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSign.ForeColor = System.Drawing.SystemColors.Control;
            this.labSign.Location = new System.Drawing.Point(556, 261);
            this.labSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSign.Name = "labSign";
            this.labSign.Size = new System.Drawing.Size(75, 27);
            this.labSign.TabIndex = 5;
            this.labSign.Text = "星座：";
            // 
            // txtEngName
            // 
            this.txtEngName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngName.Location = new System.Drawing.Point(732, 158);
            this.txtEngName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.Size = new System.Drawing.Size(167, 35);
            this.txtEngName.TabIndex = 6;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(641, 210);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(167, 35);
            this.txtGender.TabIndex = 7;
            // 
            // txtSign
            // 
            this.txtSign.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSign.Location = new System.Drawing.Point(641, 257);
            this.txtSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(167, 35);
            this.txtSign.TabIndex = 8;
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSayHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(732, 333);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(119, 74);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Frm_H01_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 488);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.labSign);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_H01_HelloForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labSign;
        private System.Windows.Forms.TextBox txtEngName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSign;
        private System.Windows.Forms.Button btnSayHi;
    }
}

