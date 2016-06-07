using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SendToTE.Model;

namespace SendToTE.Ado
{
    public class TypechoDA : ITypechoDA
    {
        private MySqlConnection conn = SQLCon.getConn();

        private String str = "typecho_contents";
        public int getCid()
        {

            return 0;
        }

        public void updateSlug(int cid, String contentTableName)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("update "+contentTableName+" set slug=@slug where cid=@cid;", conn);

            cmd.Parameters.AddWithValue("@slug", cid);
            cmd.Parameters.AddWithValue("@cid", cid);

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            Console.WriteLine("修改了slug：" + i);
        }

        public int sendWrittings(Content content, String contentTableName)
        {
            conn.Open();
            MySqlCommand cmd =
                new MySqlCommand(
                    "insert into " + contentTableName + " (title,slug,created,modified,text,authorId,allowComment,allowPing,allowFeed) values(@title,@slug,@created,@modified,@text,@authorId,@allowComment,@allowPing,@allowFeed)",
                    conn);
            cmd.Parameters.AddWithValue("@title", content.Title);
            cmd.Parameters.AddWithValue("@slug", content.Slug);
            cmd.Parameters.AddWithValue("@created", content.Created);
            cmd.Parameters.AddWithValue("@modified", content.Modified);
            cmd.Parameters.AddWithValue("@text", @content.Text);
            cmd.Parameters.AddWithValue("@authorId", content.AuthorId);
            cmd.Parameters.AddWithValue("@allowComment", content.AllowComment);
            cmd.Parameters.AddWithValue("@allowPing", content.AllowPing);
            cmd.Parameters.AddWithValue("@allowFeed", content.AllowFeed);

            Console.WriteLine(",comment:" + content.AllowComment + ",ping:" + content.AllowPing + "feed" +
                              content.AllowFeed);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return i;
        }
        public List<Metas> selMetasCategory()
        {
            
            List<Metas> list = new List<Metas>();
            
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from typecho_metas where type='category'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Metas metas = new Metas();
                metas.Mid = dr[0].ToString();
                metas.Name = (string) dr[1];
                list.Add(metas);
            }
            return list;
        }

        public void insertRelations(int cid, int mid, string contentTableName)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("insert into " + contentTableName + " (cid,mid) values(@cid,@mid)",
                    conn);

            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@mid", mid);

            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@IDENTITY";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            Console.WriteLine("插入relations：" + i);
        }
    }
}