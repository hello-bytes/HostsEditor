using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Diagnostics;
using System.Security.Principal;
using System.Runtime.InteropServices;

namespace ModifyHost
{
    static class Program
    {
       private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static void RunAsAdmin()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Application.ExecutablePath;
            proc.Verb = "runas";

            try
            {
                Process.Start(proc);
            }
            catch
            {
                return;
            }
        }

        private static Boolean IsInstanceExist()
        {
            Boolean result = false;
            System.Threading.Mutex m = new System.Threading.Mutex(true, @"HostModifyInstalce_Mutex", out result);
            if (result)
            {
                m.ReleaseMutex();
            }
            return result;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (IsRunAsAdmin() == false)
            {
                RunAsAdmin();
                return;
            }

            if (IsInstanceExist() == false)
            {
                WindowFinder fw = new WindowFinder(IntPtr.Zero, null, "Host修改器", 10);
                if (fw.FoundHandle != IntPtr.Zero)
                {
                    NativeBridge.SendMessage(fw.FoundHandle, NativeBridge.WM_SENDINSTANCE_CALL, 0, 0);
                }
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
