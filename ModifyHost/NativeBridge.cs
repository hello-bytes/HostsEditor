using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ModifyHost
{
    class NativeBridge
    {
        public static int WM_SENDINSTANCE_CALL = 2000;

        //if found  return the handle , otherwise return IntPtr.Zero
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    }
}
