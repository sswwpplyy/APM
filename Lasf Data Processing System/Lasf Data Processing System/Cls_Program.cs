using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lasf_Data_Processing_System
{
    static class Cls_Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Main());
        }
    }
}
