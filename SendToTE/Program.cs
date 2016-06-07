using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
                if (SQLCon.getIsAble())
                {
                    Application.Run(new frm_main());
                }
            }
            Application.Run(new frm_setting());
        }
    }
}
