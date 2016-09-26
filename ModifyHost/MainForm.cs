using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Security.Principal;

namespace ModifyHost
{
    public partial class MainForm : Form
    {
        private Boolean _unsavedModify = false;
        private String _hostFilePath = null;
        private String _appDataPath = null;
        private SavedToastForm _toastForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m != null && m.Msg == NativeBridge.WM_SENDINSTANCE_CALL)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }
                BringToFront();
            }
            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //C:\Windows\System32\drivers\etc
            _hostFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            _appDataPath += @"\HostModify";
            _hostFilePath += @"\drivers\etc\hosts";

            LoadHost();
        }

        //重新加载Host
        private void tbReload_Click(object sender, EventArgs e)
        {
            LoadHost();
        }

        //文本被改变
        private void hostTextBox_TextChanged(object sender, EventArgs e)
        {
            _unsavedModify = true;
        }

        private void tbSaveHost_Click(object sender, EventArgs e)
        {
            SaveHost();

            //重新加载数据
            LoadHost();

            PopupToast();
        }

        private void miReloadHost_Click(object sender, EventArgs e)
        {
            LoadHost();
        }

        private void miViewBackupFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", _appDataPath);
        }

        private void miViewHost_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(_hostFilePath));
        }

        private void miViewBackupFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", _appDataPath + @"\hosts.log");
        }

        //从备份区恢复
        private void miRestoreFromBackup_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void hostTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveHost();
                LoadHost();
                PopupToast();
            }
        }

        //窗体关闭消息
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e != null)
            {
                if (_unsavedModify)
                {
                    DialogResult dr = MessageBox.Show("您对当前Host文件做了修改，但还没有保存，请选择\r\n【是】保存并退出\r\n【否】放弃修改并退出\r\n【取消】关闭此能话框不退出!", "Host文件修改器", MessageBoxButtons.YesNoCancel);
                    switch(dr)
                    {
                        case DialogResult.Yes:
                            SaveHost();
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 加载本地的Host文件
        /// </summary>
        private void LoadHost()
        {
            try
            {
                using (StreamReader txtReader = new StreamReader(_hostFilePath))
                {
                    string strText = txtReader.ReadToEnd();
                    hostTextBox.Text = strText;
                    _unsavedModify = false;
                }
            }
            catch (System.Exception ex)
            {
            	MessageBox.Show("读取文件时出错了，\r\n错误信息:" + ex.ToString());
            }
        }

        
        

        /// <summary>
        /// 保存输入框中的Host文件到本地
        /// </summary>
        private void SaveHost()
        {
            string text = hostTextBox.Text;
            if (text.IndexOf("\r\n") <= 0)
            {
                text = text.Replace("\n", "\r\n");
            }

            try
            {
                using (TextWriter txtWriter = new StreamWriter(_hostFilePath))
                {
                    txtWriter.Write(text);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("保存文件时出错了，\r\n错误信息:" + ex.ToString());
            }
        }

        private void PopupToast()
        {
            _toastForm = new SavedToastForm();
            _toastForm.ParentSize = this.Size;
            _toastForm.ParentLocation = this.Location;
            _toastForm.Show();
        }

        private void Restore()
        {
            if (IsBackupExist())
            {
                try
                {
                    File.Copy(_appDataPath + @"\hosts.log", _hostFilePath, true);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("恢复文件时出错，\r\n错误信息:" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("没有可用于恢复的备份文件!", "Host文件修改器", MessageBoxButtons.OK);
            }
        }

        private Boolean IsBackupExist()
        {
            String strHost = _appDataPath + @"\hosts.log";
            return File.Exists(strHost);
        }

        private void BackupHost()
        {
            String strHost = _appDataPath + @"\hosts.log";
            if (Directory.Exists(_appDataPath) == false)
            {
                Directory.CreateDirectory(_appDataPath);
            }
            File.Copy(_hostFilePath, strHost, true);
        }

        private void RemoveHost(String strHostName)
        {

        }

        private void AddHost(HostItem hostItem)
        {

        }

        private void miBackHosts_Click(object sender, EventArgs e)
        {
            Boolean bBackup = true;
            if (IsBackupExist())
            {
                if (MessageBox.Show("您已经备份过了，本次备份会删除上一次的备份，是否进行备份？", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bBackup = true;
                }
                else
                {
                    bBackup = false;
                }
            }

            if (bBackup)
            {
                BackupHost();
            }
        }

        
   }
}
