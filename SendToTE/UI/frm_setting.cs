using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendToTE.Ado;
using SendToTE.Manage;
using SendToTE.Model;

namespace SendToTE.ui
{
    public partial class frm_setting : Form
    {
        private Config mConfig= new Config();
        public frm_setting()
        {
            InitializeComponent();
        }

        private void initData()
        {
            mConfig.DbServer = tB_dbServer.Text;
            mConfig.DbUser = tB_dbUser.Text;
            mConfig.DbPwd = tB_dbPwd.Text;
            mConfig.Database = tB_database.Text;
            mConfig.PreTableName = tB_preTableName.Text;
            mConfig.UploadFileUrl = tB_uploadFileUrl.Text;
            mConfig.BlogUrl = tB_blogUrl.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initData();
            ConfigManage.setConfig(mConfig);
            if (SQLCon.getConn() == null)
            {
                MessageBox.Show("链接失败");

            }
            else
            {
                MessageBox.Show("连接成功");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initData();
            ConfigManage.setConfig(mConfig);
            if (SQLCon.getConn() == null)
            {
                MessageBox.Show("数据库连接失败，请检查配置");

            }
            else
            {
                Form frm = new frm_main();
                frm.Show();
                this.Hide();

            }
        }
    }
}
