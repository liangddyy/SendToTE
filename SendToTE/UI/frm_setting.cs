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
        private Config mConfig;
        public frm_setting()
        {
            InitializeComponent();
        }

        private void initData()
        {
            if (mConfig == null)
            {
                mConfig=new Config();
            }
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
            if (SQLCon.getIsAble())
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败,请检查参数!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initData();
            ConfigManage.setConfig(mConfig);
            if (SQLCon.getIsAble())
            {
                Form frm = new frm_main();
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("数据库连接失败，请检查配置");
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_setting_Load(object sender, EventArgs e)
        {
            mConfig = ConfigManage.getConfig();
            if (mConfig != null)
            {
                tB_dbServer.Text = mConfig.DbServer;
                tB_dbUser.Text = mConfig.DbUser;
                tB_dbPwd.Text = mConfig.DbPwd;
                tB_database.Text = mConfig.Database;
                tB_preTableName.Text = mConfig.PreTableName;
                tB_uploadFileUrl.Text = mConfig.UploadFileUrl;
                tB_blogUrl.Text = mConfig.BlogUrl;
            }
        }
    }
}
