using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendToTE.Ado;
using SendToTE.Manage;
using SendToTE.test;
using SendToTE.ui;

namespace SendToTE
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (ConfigManage.initConfig() != null)
            {
                if (SQLCon.getConn() != null)
                {
                    Application.Run(new frm_main());
                }
                
            }
            else
            {
                Application.Run(new frm_setting());
            }
        }
    }
}
