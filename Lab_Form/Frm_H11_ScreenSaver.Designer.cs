namespace Lab_Form
{
    partial class Frm_H11_ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PbLala = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLala)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PbLala
            // 
            this.PbLala.Location = new System.Drawing.Point(-1, 0);
            this.PbLala.Name = "PbLala";
            this.PbLala.Size = new System.Drawing.Size(378, 261);
            this.PbLala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbLala.TabIndex = 0;
            this.PbLala.TabStop = false;
            // 
            // Frm_H11_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(958, 711);
            this.Controls.Add(this.PbLala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_H11_ScreenSaver";
            this.ShowInTaskbar = false;
            this.Text = "Frm_H11_ScreenSaver";
            this.Load += new System.EventHandler(this.Frm_H11_ScreenSaver_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_H11_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PbLala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PbLala;
    }
}