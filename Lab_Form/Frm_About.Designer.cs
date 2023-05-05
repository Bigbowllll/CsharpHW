namespace Lab_Form
{
    partial class Frm_About
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
            this.labAbout = new System.Windows.Forms.Label();
            this.labIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labAbout
            // 
            this.labAbout.AutoSize = true;
            this.labAbout.Font = new System.Drawing.Font("微軟正黑體", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAbout.Location = new System.Drawing.Point(24, 22);
            this.labAbout.Name = "labAbout";
            this.labAbout.Size = new System.Drawing.Size(69, 34);
            this.labAbout.TabIndex = 0;
            this.labAbout.Text = "關於";
            // 
            // labIntro
            // 
            this.labIntro.AutoSize = true;
            this.labIntro.Font = new System.Drawing.Font("微軟正黑體", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIntro.Location = new System.Drawing.Point(27, 74);
            this.labIntro.Name = "labIntro";
            this.labIntro.Size = new System.Drawing.Size(391, 34);
            this.labIntro.TabIndex = 1;
            this.labIntro.Text = "此版本為林琬諭在C#的作業，敬請您安心使用。\r\n如有遇一些按鈕無效，因時間問題先製作佑晨的1.0版本，請見諒。";
            // 
            // Frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 151);
            this.Controls.Add(this.labIntro);
            this.Controls.Add(this.labAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_About";
            this.Text = "關於";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAbout;
        private System.Windows.Forms.Label labIntro;
    }
}