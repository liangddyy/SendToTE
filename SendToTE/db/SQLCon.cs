using System;
using MySql.Data.MySqlClient;
using SendToTE.Manage;

namespace SendToTE.Ado
{
    class SQLCon
    {
        public static MySqlConnection conn = null;
        public static MySqlConnection getConn()
        {
            if (conn == null)
            {
                return new MySqlConnection(ConfigManage.getSqlConnectionCmd());
                //return new MySqlConnection("server=localhost;user id=root;password=;database=test;Charset=utf8;");
                
            }
            return conn;
        }

        public static bool getIsAble()
        {
            try
            {
                getConn().Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                getConn().Close();
            }
        }
    }
}