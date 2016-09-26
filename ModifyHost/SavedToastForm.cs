using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModifyHost
{
    public partial class SavedToastForm : Form
    {
        public Size ParentSize{ get; set; }
        public Point ParentLocation { get; set; }

        public SavedToastForm()
        {
            InitializeComponent();
        }

        private void SavedToastForm_Load(object sender, EventArgs e)
        {
            Size saveToastSize = Size;
            Left = ParentLocation.X + (ParentSize.Width - saveToastSize.Width) / 2;
            Top = ParentLocation.Y + 82;

            Timer time = new Timer();
            time.Interval = 1600;
            time.Tick += new EventHandler(time_Tick);
            time.Start();
        }

        void time_Tick(object sender, EventArgs e)
        {
            Hide();
        }


    }
}
