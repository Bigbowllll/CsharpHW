namespace Lab_Form
{
    partial class Frm_H08_MyClac
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum2 = new System.Windows.Forms.Label();
            this.labAns = new System.Windows.Forms.Label();
            this.labAnsShow = new System.Windows.Forms.Label();
            this.labline = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.Location = new System.Drawing.Point(56, 61);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(78, 27);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.Location = new System.Drawing.Point(140, 58);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(140, 35);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.Location = new System.Drawing.Point(140, 111);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(140, 35);
            this.txtNum2.TabIndex = 3;
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.Location = new System.Drawing.Point(56, 114);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(78, 27);
            this.labNum2.TabIndex = 2;
            this.labNum2.Text = "Num2:";
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.Location = new System.Drawing.Point(43, 193);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(91, 27);
            this.labAns.TabIndex = 4;
            this.labAns.Text = "Answer:";
            // 
            // labAnsShow
            // 
            this.labAnsShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labAnsShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAnsShow.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnsShow.Location = new System.Drawing.Point(140, 192);
            this.labAnsShow.Name = "labAnsShow";
            this.labAnsShow.Size = new System.Drawing.Size(140, 36);
            this.labAnsShow.TabIndex = 5;
            // 
            // labline
            // 
            this.labline.AutoSize = true;
            this.labline.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labline.Location = new System.Drawing.Point(43, 149);
            this.labline.Name = "labline";
            this.labline.Size = new System.Drawing.Size(252, 27);
            this.labline.TabIndex = 6;
            this.labline.Text = "================";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(332, 43);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(71, 44);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(332, 93);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(71, 44);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(332, 143);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(71, 44);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(332, 193);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(71, 44);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Frm_H08_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 284);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.labline);
            this.Controls.Add(this.labAnsShow);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.labNum1);
            this.Name = "Frm_H08_MyClac";
            this.Text = "Myhomework_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Label labAnsShow;
        private System.Windows.Forms.Label labline;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivision;
    }
}