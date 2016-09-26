namespace ModifyHost
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加HostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miReloadHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miBackHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestoreFromBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miViewBackupFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewBackupFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbReload = new System.Windows.Forms.ToolStripButton();
            this.tbSaveHost = new System.Windows.Forms.ToolStripButton();
            this.hostTextBox = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.查看ToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(886, 25);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加HostToolStripMenuItem,
            this.miReloadHost,
            this.toolStripMenuItem2,
            this.miBackHosts,
            this.miRestoreFromBackup});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 增加HostToolStripMenuItem
            // 
            this.增加HostToolStripMenuItem.Name = "增加HostToolStripMenuItem";
            this.增加HostToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.增加HostToolStripMenuItem.Text = "增加Host记录";
            this.增加HostToolStripMenuItem.Visible = false;
            // 
            // miReloadHost
            // 
            this.miReloadHost.Name = "miReloadHost";
            this.miReloadHost.Size = new System.Drawing.Size(151, 22);
            this.miReloadHost.Text = "重新加载";
            this.miReloadHost.Click += new System.EventHandler(this.miReloadHost_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 6);
            // 
            // miBackHosts
            // 
            this.miBackHosts.Name = "miBackHosts";
            this.miBackHosts.Size = new System.Drawing.Size(151, 22);
            this.miBackHosts.Text = "备份Host";
            this.miBackHosts.Click += new System.EventHandler(this.miBackHosts_Click);
            // 
            // miRestoreFromBackup
            // 
            this.miRestoreFromBackup.Name = "miRestoreFromBackup";
            this.miRestoreFromBackup.Size = new System.Drawing.Size(151, 22);
            this.miRestoreFromBackup.Text = "从备份区恢复";
            this.miRestoreFromBackup.Click += new System.EventHandler(this.miRestoreFromBackup_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewHost,
            this.toolStripMenuItem1,
            this.miViewBackupFile,
            this.miViewBackupFolder});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // miViewHost
            // 
            this.miViewHost.Name = "miViewHost";
            this.miViewHost.Size = new System.Drawing.Size(169, 22);
            this.miViewHost.Text = "查看Hosts文件夹";
            this.miViewHost.Click += new System.EventHandler(this.miViewHost_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // miViewBackupFile
            // 
            this.miViewBackupFile.Name = "miViewBackupFile";
            this.miViewBackupFile.Size = new System.Drawing.Size(169, 22);
            this.miViewBackupFile.Text = "查看备份文件";
            this.miViewBackupFile.Click += new System.EventHandler(this.miViewBackupFile_Click);
            // 
            // miViewBackupFolder
            // 
            this.miViewBackupFolder.Name = "miViewBackupFolder";
            this.miViewBackupFolder.Size = new System.Drawing.Size(169, 22);
            this.miViewBackupFolder.Text = "查看备份文件夹";
            this.miViewBackupFolder.Click += new System.EventHandler(this.miViewBackupFolder_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbReload,
            this.tbSaveHost});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(886, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbReload
            // 
            this.tbReload.Image = ((System.Drawing.Image)(resources.GetObject("tbReload.Image")));
            this.tbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbReload.Name = "tbReload";
            this.tbReload.Size = new System.Drawing.Size(127, 22);
            this.tbReload.Text = "重新加载Host文件";
            this.tbReload.Click += new System.EventHandler(this.tbReload_Click);
            // 
            // tbSaveHost
            // 
            this.tbSaveHost.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveHost.Image")));
            this.tbSaveHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveHost.Name = "tbSaveHost";
            this.tbSaveHost.Size = new System.Drawing.Size(103, 22);
            this.tbSaveHost.Text = "保存Host文件";
            this.tbSaveHost.Click += new System.EventHandler(this.tbSaveHost_Click);
            // 
            // hostTextBox
            // 
            this.hostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hostTextBox.DetectUrls = false;
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTextBox.Location = new System.Drawing.Point(0, 50);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(886, 477);
            this.hostTextBox.TabIndex = 2;
            this.hostTextBox.Text = "";
            this.hostTextBox.WordWrap = false;
            this.hostTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hostTextBox_KeyDown);
            this.hostTextBox.TextChanged += new System.EventHandler(this.hostTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 527);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扣钉盖(http://www.codingsky.com)Hosts文件修改器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加HostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miReloadHost;
        private System.Windows.Forms.ToolStripMenuItem miBackHosts;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miViewBackupFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbReload;
        private System.Windows.Forms.RichTextBox hostTextBox;
        private System.Windows.Forms.ToolStripButton tbSaveHost;
        private System.Windows.Forms.ToolStripMenuItem miViewBackupFolder;
        private System.Windows.Forms.ToolStripMenuItem miViewHost;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miRestoreFromBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

