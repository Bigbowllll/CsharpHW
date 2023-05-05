namespace Lab_Form
{
    partial class Frm_H12_Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_H12_Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFileF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenO = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSaveS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmPrintP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrePrintV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNotepad = new System.Windows.Forms.ToolStrip();
            this.新增NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開啟OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.列印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.複製CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼上PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.說明LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.stsNotepad = new System.Windows.Forms.StatusStrip();
            this.tsstime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStripNotepad.SuspendLayout();
            this.stsNotepad.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileF,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.toolStripMenuItem1,
            this.說明HToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmFileF
            // 
            resources.ApplyResources(this.tsmFileF, "tsmFileF");
            this.tsmFileF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewN,
            this.tsmOpenO,
            this.toolStripSeparator,
            this.tsmSaveS,
            this.tsmNewSave,
            this.toolStripSeparator1,
            this.tsmPrintP,
            this.tsmPrePrintV,
            this.toolStripSeparator2,
            this.tsmExit});
            this.tsmFileF.Name = "tsmFileF";
            // 
            // tsmNewN
            // 
            resources.ApplyResources(this.tsmNewN, "tsmNewN");
            this.tsmNewN.Name = "tsmNewN";
            // 
            // tsmOpenO
            // 
            resources.ApplyResources(this.tsmOpenO, "tsmOpenO");
            this.tsmOpenO.Name = "tsmOpenO";
            this.tsmOpenO.Click += new System.EventHandler(this.tsmOpenO_Click);
            // 
            // toolStripSeparator
            // 
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            this.toolStripSeparator.Name = "toolStripSeparator";
            // 
            // tsmSaveS
            // 
            resources.ApplyResources(this.tsmSaveS, "tsmSaveS");
            this.tsmSaveS.Name = "tsmSaveS";
            // 
            // tsmNewSave
            // 
            resources.ApplyResources(this.tsmNewSave, "tsmNewSave");
            this.tsmNewSave.Name = "tsmNewSave";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tsmPrintP
            // 
            resources.ApplyResources(this.tsmPrintP, "tsmPrintP");
            this.tsmPrintP.Name = "tsmPrintP";
            // 
            // tsmPrePrintV
            // 
            resources.ApplyResources(this.tsmPrePrintV, "tsmPrePrintV");
            this.tsmPrePrintV.Name = "tsmPrePrintV";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tsmExit
            // 
            resources.ApplyResources(this.tsmExit, "tsmExit");
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            resources.ApplyResources(this.編輯EToolStripMenuItem, "編輯EToolStripMenuItem");
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原UToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選AToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            // 
            // 復原UToolStripMenuItem
            // 
            resources.ApplyResources(this.復原UToolStripMenuItem, "復原UToolStripMenuItem");
            this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            // 
            // 取消復原RToolStripMenuItem
            // 
            resources.ApplyResources(this.取消復原RToolStripMenuItem, "取消復原RToolStripMenuItem");
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // 剪下TToolStripMenuItem
            // 
            resources.ApplyResources(this.剪下TToolStripMenuItem, "剪下TToolStripMenuItem");
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.Click += new System.EventHandler(this.剪下TToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            resources.ApplyResources(this.複製CToolStripMenuItem, "複製CToolStripMenuItem");
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            resources.ApplyResources(this.貼上PToolStripMenuItem, "貼上PToolStripMenuItem");
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // 全選AToolStripMenuItem
            // 
            resources.ApplyResources(this.全選AToolStripMenuItem, "全選AToolStripMenuItem");
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.Click += new System.EventHandler(this.全選AToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            resources.ApplyResources(this.工具TToolStripMenuItem, "工具TToolStripMenuItem");
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            // 
            // 自訂CToolStripMenuItem
            // 
            resources.ApplyResources(this.自訂CToolStripMenuItem, "自訂CToolStripMenuItem");
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            // 
            // 選項OToolStripMenuItem
            // 
            resources.ApplyResources(this.選項OToolStripMenuItem, "選項OToolStripMenuItem");
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem,
            this.字型VToolStripMenuItem,
            this.toUpperToolStripMenuItem,
            this.toLowerToolStripMenuItem,
            this.自動換行ToolStripMenuItem,
            this.快選顏色ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // 顏色ToolStripMenuItem
            // 
            resources.ApplyResources(this.顏色ToolStripMenuItem, "顏色ToolStripMenuItem");
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // 字型VToolStripMenuItem
            // 
            resources.ApplyResources(this.字型VToolStripMenuItem, "字型VToolStripMenuItem");
            this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
            this.字型VToolStripMenuItem.Click += new System.EventHandler(this.字型VToolStripMenuItem_Click);
            // 
            // toUpperToolStripMenuItem
            // 
            resources.ApplyResources(this.toUpperToolStripMenuItem, "toUpperToolStripMenuItem");
            this.toUpperToolStripMenuItem.Name = "toUpperToolStripMenuItem";
            this.toUpperToolStripMenuItem.Click += new System.EventHandler(this.toUpperToolStripMenuItem_Click);
            // 
            // toLowerToolStripMenuItem
            // 
            resources.ApplyResources(this.toLowerToolStripMenuItem, "toLowerToolStripMenuItem");
            this.toLowerToolStripMenuItem.Name = "toLowerToolStripMenuItem";
            this.toLowerToolStripMenuItem.Click += new System.EventHandler(this.toLowerToolStripMenuItem_Click);
            // 
            // 自動換行ToolStripMenuItem
            // 
            resources.ApplyResources(this.自動換行ToolStripMenuItem, "自動換行ToolStripMenuItem");
            this.自動換行ToolStripMenuItem.Name = "自動換行ToolStripMenuItem";
            this.自動換行ToolStripMenuItem.Click += new System.EventHandler(this.自動換行ToolStripMenuItem_Click);
            // 
            // 快選顏色ToolStripMenuItem
            // 
            resources.ApplyResources(this.快選顏色ToolStripMenuItem, "快選顏色ToolStripMenuItem");
            this.快選顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.快選顏色ToolStripMenuItem.Name = "快選顏色ToolStripMenuItem";
            // 
            // redToolStripMenuItem
            // 
            resources.ApplyResources(this.redToolStripMenuItem, "redToolStripMenuItem");
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            resources.ApplyResources(this.greenToolStripMenuItem, "greenToolStripMenuItem");
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            resources.ApplyResources(this.blueToolStripMenuItem, "blueToolStripMenuItem");
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            resources.ApplyResources(this.blackToolStripMenuItem, "blackToolStripMenuItem");
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            resources.ApplyResources(this.說明HToolStripMenuItem, "說明HToolStripMenuItem");
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於AToolStripMenuItem});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            // 
            // 內容CToolStripMenuItem
            // 
            resources.ApplyResources(this.內容CToolStripMenuItem, "內容CToolStripMenuItem");
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            // 
            // 索引IToolStripMenuItem
            // 
            resources.ApplyResources(this.索引IToolStripMenuItem, "索引IToolStripMenuItem");
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            // 
            // 搜尋SToolStripMenuItem
            // 
            resources.ApplyResources(this.搜尋SToolStripMenuItem, "搜尋SToolStripMenuItem");
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // 關於AToolStripMenuItem
            // 
            resources.ApplyResources(this.關於AToolStripMenuItem, "關於AToolStripMenuItem");
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Click += new System.EventHandler(this.關於AToolStripMenuItem_Click);
            // 
            // toolStripNotepad
            // 
            resources.ApplyResources(this.toolStripNotepad, "toolStripNotepad");
            this.toolStripNotepad.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStripNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripButton,
            this.開啟OToolStripButton,
            this.儲存SToolStripButton,
            this.列印PToolStripButton,
            this.toolStripSeparator8,
            this.剪下UToolStripButton,
            this.複製CToolStripButton,
            this.貼上PToolStripButton,
            this.toolStripSeparator9,
            this.說明LToolStripButton});
            this.toolStripNotepad.Name = "toolStripNotepad";
            // 
            // 新增NToolStripButton
            // 
            resources.ApplyResources(this.新增NToolStripButton, "新增NToolStripButton");
            this.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增NToolStripButton.Name = "新增NToolStripButton";
            // 
            // 開啟OToolStripButton
            // 
            resources.ApplyResources(this.開啟OToolStripButton, "開啟OToolStripButton");
            this.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟OToolStripButton.Name = "開啟OToolStripButton";
            this.開啟OToolStripButton.Click += new System.EventHandler(this.開啟OToolStripButton_Click);
            // 
            // 儲存SToolStripButton
            // 
            resources.ApplyResources(this.儲存SToolStripButton, "儲存SToolStripButton");
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            // 
            // 列印PToolStripButton
            // 
            resources.ApplyResources(this.列印PToolStripButton, "列印PToolStripButton");
            this.列印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.列印PToolStripButton.Name = "列印PToolStripButton";
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // 剪下UToolStripButton
            // 
            resources.ApplyResources(this.剪下UToolStripButton, "剪下UToolStripButton");
            this.剪下UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪下UToolStripButton.Name = "剪下UToolStripButton";
            this.剪下UToolStripButton.Click += new System.EventHandler(this.剪下UToolStripButton_Click);
            // 
            // 複製CToolStripButton
            // 
            resources.ApplyResources(this.複製CToolStripButton, "複製CToolStripButton");
            this.複製CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.複製CToolStripButton.Name = "複製CToolStripButton";
            this.複製CToolStripButton.Click += new System.EventHandler(this.複製CToolStripButton_Click);
            // 
            // 貼上PToolStripButton
            // 
            resources.ApplyResources(this.貼上PToolStripButton, "貼上PToolStripButton");
            this.貼上PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼上PToolStripButton.Name = "貼上PToolStripButton";
            this.貼上PToolStripButton.Click += new System.EventHandler(this.貼上PToolStripButton_Click);
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            // 
            // 說明LToolStripButton
            // 
            resources.ApplyResources(this.說明LToolStripButton, "說明LToolStripButton");
            this.說明LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.說明LToolStripButton.Name = "說明LToolStripButton";
            this.說明LToolStripButton.Click += new System.EventHandler(this.說明LToolStripButton_Click);
            // 
            // txtWrite
            // 
            resources.ApplyResources(this.txtWrite, "txtWrite");
            this.txtWrite.Name = "txtWrite";
            // 
            // stsNotepad
            // 
            resources.ApplyResources(this.stsNotepad, "stsNotepad");
            this.stsNotepad.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.stsNotepad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsstime,
            this.toolStripStatusTime});
            this.stsNotepad.Name = "stsNotepad";
            // 
            // tsstime
            // 
            resources.ApplyResources(this.tsstime, "tsstime");
            this.tsstime.Name = "tsstime";
            // 
            // toolStripStatusTime
            // 
            resources.ApplyResources(this.toolStripStatusTime, "toolStripStatusTime");
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // Frm_H12_Notepad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stsNotepad);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.toolStripNotepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_H12_Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripNotepad.ResumeLayout(false);
            this.toolStripNotepad.PerformLayout();
            this.stsNotepad.ResumeLayout(false);
            this.stsNotepad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFileF;
        private System.Windows.Forms.ToolStripMenuItem tsmNewN;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveS;
        private System.Windows.Forms.ToolStripMenuItem tsmNewSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmPrintP;
        private System.Windows.Forms.ToolStripMenuItem tsmPrePrintV;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toUpperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動換行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripNotepad;
        private System.Windows.Forms.ToolStripButton 新增NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開啟OToolStripButton;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 列印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton 剪下UToolStripButton;
        private System.Windows.Forms.ToolStripButton 複製CToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼上PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton 說明LToolStripButton;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.StatusStrip stsNotepad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel tsstime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}