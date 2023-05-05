namespace Lab_Form
{
    partial class Frm_H06_StuGradeList
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
            this.labSum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.txtSearchStart = new System.Windows.Forms.TextBox();
            this.txtSearchEnd = new System.Windows.Forms.TextBox();
            this.labSearchChiScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labSum
            // 
            this.labSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labSum.Font = new System.Drawing.Font("標楷體", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSum.Location = new System.Drawing.Point(286, 378);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(494, 114);
            this.labSum.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(92, 483);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 36);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCleanData
            // 
            this.btnCleanData.Enabled = false;
            this.btnCleanData.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCleanData.Location = new System.Drawing.Point(73, 310);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(152, 32);
            this.btnCleanData.TabIndex = 27;
            this.btnCleanData.Text = "清除資料";
            this.btnCleanData.UseVisualStyleBackColor = true;
            // 
            // btnInsertData
            // 
            this.btnInsertData.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertData.Location = new System.Drawing.Point(73, 268);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(152, 32);
            this.btnInsertData.TabIndex = 26;
            this.btnInsertData.Text = "插入儲存資料";
            this.btnInsertData.UseVisualStyleBackColor = true;
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddData.Location = new System.Drawing.Point(73, 226);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(152, 32);
            this.btnAddData.TabIndex = 25;
            this.btnAddData.Text = "加入學生資料";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(131, 171);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 33);
            this.txtMath.TabIndex = 24;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(61, 174);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 23;
            this.labMath.Text = "數學：";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(131, 121);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 33);
            this.txtEnglish.TabIndex = 22;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(61, 124);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(67, 24);
            this.labEnglish.TabIndex = 21;
            this.labEnglish.Text = "英文：";
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(131, 74);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 33);
            this.txtChinese.TabIndex = 20;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(61, 77);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(67, 24);
            this.labChinese.TabIndex = 19;
            this.labChinese.Text = "國文：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(131, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 33);
            this.txtName.TabIndex = 18;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(61, 29);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 17;
            this.labName.Text = "姓名：";
            // 
            // btnClearAllData
            // 
            this.btnClearAllData.Enabled = false;
            this.btnClearAllData.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAllData.Location = new System.Drawing.Point(73, 352);
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.Size = new System.Drawing.Size(152, 32);
            this.btnClearAllData.TabIndex = 34;
            this.btnClearAllData.Text = "清除所有資料";
            this.btnClearAllData.UseVisualStyleBackColor = true;
            // 
            // txtSearchStart
            // 
            this.txtSearchStart.Font = new System.Drawing.Font("微軟正黑體", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchStart.Location = new System.Drawing.Point(73, 438);
            this.txtSearchStart.Name = "txtSearchStart";
            this.txtSearchStart.Size = new System.Drawing.Size(58, 29);
            this.txtSearchStart.TabIndex = 35;
            // 
            // txtSearchEnd
            // 
            this.txtSearchEnd.Font = new System.Drawing.Font("微軟正黑體", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchEnd.Location = new System.Drawing.Point(167, 438);
            this.txtSearchEnd.Name = "txtSearchEnd";
            this.txtSearchEnd.Size = new System.Drawing.Size(58, 29);
            this.txtSearchEnd.TabIndex = 36;
            // 
            // labSearchChiScore
            // 
            this.labSearchChiScore.AutoSize = true;
            this.labSearchChiScore.Font = new System.Drawing.Font("微軟正黑體", 12.90566F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSearchChiScore.Location = new System.Drawing.Point(61, 402);
            this.labSearchChiScore.Name = "labSearchChiScore";
            this.labSearchChiScore.Size = new System.Drawing.Size(181, 24);
            this.labSearchChiScore.TabIndex = 37;
            this.labSearchChiScore.Text = "搜尋國文成績範圍：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(139, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "-";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(672, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("標楷體", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(10, 30);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(2, 17);
            this.labShow.TabIndex = 40;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("標楷體", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(298, 33);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(455, 16);
            this.labTitle.TabIndex = 33;
            this.labTitle.Text = "姓名      國文   英文   數學   總分   平均   最低   最高";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(286, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 348);
            this.panel1.TabIndex = 41;
            // 
            // Frm_H06_StuGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 558);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labSearchChiScore);
            this.Controls.Add(this.txtSearchEnd);
            this.Controls.Add(this.txtSearchStart);
            this.Controls.Add(this.btnClearAllData);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCleanData);
            this.Controls.Add(this.btnInsertData);
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
            this.Name = "Frm_H06_StuGradeList";
            this.Text = "Frm_H06_StuGradeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnClearAllData;
        private System.Windows.Forms.TextBox txtSearchStart;
        private System.Windows.Forms.TextBox txtSearchEnd;
        private System.Windows.Forms.Label labSearchChiScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
    }
}