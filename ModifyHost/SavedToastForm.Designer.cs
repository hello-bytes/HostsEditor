namespace ModifyHost
{
    partial class SavedToastForm
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
            this.lblSaved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaved
            // 
            this.lblSaved.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.ForeColor = System.Drawing.Color.White;
            this.lblSaved.Location = new System.Drawing.Point(185, 22);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(152, 23);
            this.lblSaved.TabIndex = 0;
            this.lblSaved.Text = "Host文件已保存";
            this.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavedToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(555, 59);
            this.Controls.Add(this.lblSaved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SavedToastForm";
            this.Opacity = 0.5;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SavedToastForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaved;
    }
}