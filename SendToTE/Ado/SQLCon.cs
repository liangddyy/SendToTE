using MySql.Data.MySqlClient;

namespace SendToTE.Ado
{
    class SQLCon
    {
        public static MySqlConnection conn = null;
        public static MySqlConnection getConn()
        {
            if (conn == null)
            {
                return new MySqlConnection("server=localhost;user id=root;password=;database=test;Charset=utf8;");
            }
            return conn;
        }
    }
}