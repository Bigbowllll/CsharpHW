using System.Windows.Forms;

namespace Lab_Form
{
    partial class Frm_H05_StudentsGrade
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnRandomSave = new System.Windows.Forms.Button();
            this.btnEachSum = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandomAdd = new System.Windows.Forms.Button();
            this.labSum = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(33, 25);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(103, 22);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(103, 70);
            this.txtChinese.MaxLength = 3;
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 33);
            this.txtChinese.TabIndex = 3;
            this.txtChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(33, 73);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(67, 24);
            this.labChinese.TabIndex = 2;
            this.labChinese.Text = "國文：";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(103, 117);
            this.txtEnglish.MaxLength = 3;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 33);
            this.txtEnglish.TabIndex = 5;
            this.txtEnglish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(33, 120);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(67, 24);
            this.labEnglish.TabIndex = 4;
            this.labEnglish.Text = "英文：";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(103, 167);
            this.txtMath.MaxLength = 3;
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 33);
            this.txtMath.TabIndex = 7;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(33, 170);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學：";
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddData.Location = new System.Drawing.Point(30, 224);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(181, 36);
            this.btnAddData.TabIndex = 8;
            this.btnAddData.Text = "加入學生資料";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnRandomSave
            // 
            this.btnRandomSave.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomSave.Location = new System.Drawing.Point(30, 266);
            this.btnRandomSave.Name = "btnRandomSave";
            this.btnRandomSave.Size = new System.Drawing.Size(181, 36);
            this.btnRandomSave.TabIndex = 9;
            this.btnRandomSave.Text = "隨機儲存資料";
            this.btnRandomSave.UseVisualStyleBackColor = true;
            this.btnRandomSave.Click += new System.EventHandler(this.btnRandomSave_Click);
            // 
            // btnEachSum
            // 
            this.btnEachSum.Enabled = false;
            this.btnEachSum.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEachSum.Location = new System.Drawing.Point(30, 308);
            this.btnEachSum.Name = "btnEachSum";
            this.btnEachSum.Size = new System.Drawing.Size(181, 36);
            this.btnEachSum.TabIndex = 10;
            this.btnEachSum.Text = "各科統計";
            this.btnEachSum.UseVisualStyleBackColor = true;
            this.btnEachSum.Click += new System.EventHandler(this.btnEachSum_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(30, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(181, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "重設所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandomAdd
            // 
            this.btnRandomAdd.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomAdd.Location = new System.Drawing.Point(30, 435);
            this.btnRandomAdd.Name = "btnRandomAdd";
            this.btnRandomAdd.Size = new System.Drawing.Size(181, 36);
            this.btnRandomAdd.TabIndex = 12;
            this.btnRandomAdd.Text = "隨機加入20筆";
            this.btnRandomAdd.UseVisualStyleBackColor = true;
            this.btnRandomAdd.Click += new System.EventHandler(this.btnRandomAdd_Click);
            // 
            // labSum
            // 
            this.labSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labSum.Font = new System.Drawing.Font("標楷體", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSum.Location = new System.Drawing.Point(252, 373);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(517, 114);
            this.labSum.TabIndex = 15;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("標楷體", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(10, 30);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(2, 17);
            this.labShow.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(252, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 337);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " 姓名     國文   英文   數學   總分   平均   最低    最高";
            // 
            // Frm_H05_StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 499);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.btnRandomAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEachSum);
            this.Controls.Add(this.btnRandomSave);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_H05_StudentsGrade";
            this.Text = "StudentsGrade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnRandomSave;
        private System.Windows.Forms.Button btnEachSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandomAdd;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Label labShow;
        private Panel panel1;
        private Label label1;
    }
}