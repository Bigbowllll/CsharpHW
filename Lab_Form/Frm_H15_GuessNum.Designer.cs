namespace Lab_Form
{
    partial class Frm_H15_GuessNum
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(76, 141);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(628, 37);
            this.labName.TabIndex = 0;
            this.labName.Text = "Please Select A Number Between 1 to 100！";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(156, 216);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(136, 53);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "GUESS";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("微軟正黑體", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAns.Location = new System.Drawing.Point(430, 216);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(136, 53);
            this.btnAns.TabIndex = 2;
            this.btnAns.Text = "Answer";
            this.btnAns.UseVisualStyleBackColor = true;
            // 
            // Frm_H15_GuessNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labName);
            this.Name = "Frm_H15_GuessNum";
            this.Text = "Frm_H15_GuessNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnAns;
    }
}