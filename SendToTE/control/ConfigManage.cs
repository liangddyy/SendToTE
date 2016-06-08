using System;
using SendToTE.Model;
using SendToTE.test;

namespace SendToTE.Manage
{
    /// <summary>
    /// 管理配置文件（读取/保存）
    /// </summary>
    public class ConfigManage
    {
        
        public static bool isInit = false;

        private static Config mConfig = new Config();

        public static Config getConfig()
        {
            if(isInit==false)
            {
                return initConfig();
            }
            return mConfig;
        }
        public static Config initConfig()
        {
            mConfig.DbServer = AppConfigSettings.GetValue("dbServer");
            mConfig.DbUser = AppConfigSettings.GetValue("dbUser");
            mConfig.DbPwd = AppConfigSettings.GetValue("dbPwd");
            mConfig.Database = AppConfigSettings.GetValue("database");
            mConfig.Charset = AppConfigSettings.GetValue("charset");
            mConfig.PreTableName = AppConfigSettings.GetValue("preTableName");
            mConfig.UploadFileUrl = AppConfigSettings.GetValue("uploadFileUrl");
            mConfig.BlogUrl = AppConfigSettings.GetValue("blogUrl");

            if (mConfig.DbServer == ""||mConfig.DbUser==""|| mConfig.Database=="")
            {
                return null;
            }
            isInit = true;
            return mConfig;
        }

        public static void setConfig(Config tConfig)
        {
            AppConfigSettings.SetValue("dbServer", tConfig.DbServer);
            AppConfigSettings.SetValue("dbUser", tConfig.DbUser);
            AppConfigSettings.SetValue("dbPwd", tConfig.DbPwd);
            AppConfigSettings.SetValue("database", tConfig.Database);
            AppConfigSettings.SetValue("charset", tConfig.Charset);
            AppConfigSettings.SetValue("preTableName", tConfig.PreTableName);
            AppConfigSettings.SetValue("uploadFileUrl", tConfig.UploadFileUrl);
            AppConfigSettings.SetValue("blogUrl", tConfig.BlogUrl);
            mConfig = tConfig;
        }

        public static String getSqlConnectionCmd()
        {
            return "server =" + mConfig.DbServer + "; user id = " + mConfig.DbUser + "; password =" + mConfig.DbPwd +
                   "; database = " + mConfig.Database + "; Charset = utf8;";
        }
    }
}