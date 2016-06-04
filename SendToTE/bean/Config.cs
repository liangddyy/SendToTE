using System;

namespace SendToTE.Model
{
    public class Config
    {
        private String dbServer;
        private String dbUser;
        private String dbPwd;
        private String database;
        private String charset;

        private String preTableName;    //表前缀
        private String uploadFileUrl;   //http://localhost/typecho/usr/upload_file.php
        private String blogUrl;

        public string DbServer
        {
            get { return dbServer; }
            set { dbServer = value; }
        }

        public string DbUser
        {
            get { return dbUser; }
            set { dbUser = value; }
        }

        public string DbPwd
        {
            get { return dbPwd; }
            set { dbPwd = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public string Charset
        {
            get { return charset; }
            set { charset = value; }
        }

        public string PreTableName
        {
            get { return preTableName; }
            set { preTableName = value; }
        }

        public string UploadFileUrl
        {
            get { return uploadFileUrl; }
            set { uploadFileUrl = value; }
        }

        public string BlogUrl
        {
            get { return blogUrl; }
            set { blogUrl = value; }
        }
    }
}