namespace SendToTE.ui
{
    partial class frm_setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_dbServer = new System.Windows.Forms.TextBox();
            this.tB_dbUser = new System.Windows.Forms.TextBox();
            this.tB_dbPwd = new System.Windows.Forms.TextBox();
            this.tB_database = new System.Windows.Forms.TextBox();
            this.tB_preTableName = new System.Windows.Forms.TextBox();
            this.tB_uploadFileUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tB_blogUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库用户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(47, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据库密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(68, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(89, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "表前缀：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(68, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "上传地址：";
            // 
            // tB_dbServer
            // 
            this.tB_dbServer.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_dbServer.Location = new System.Drawing.Point(172, 41);
            this.tB_dbServer.Name = "tB_dbServer";
            this.tB_dbServer.Size = new System.Drawing.Size(158, 29);
            this.tB_dbServer.TabIndex = 7;
            this.tB_dbServer.Text = "localhost";
            // 
            // tB_dbUser
            // 
            this.tB_dbUser.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_dbUser.Location = new System.Drawing.Point(173, 89);
            this.tB_dbUser.Name = "tB_dbUser";
            this.tB_dbUser.Size = new System.Drawing.Size(158, 30);
            this.tB_dbUser.TabIndex = 8;
            this.tB_dbUser.Text = "root";
            // 
            // tB_dbPwd
            // 
            this.tB_dbPwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_dbPwd.Location = new System.Drawing.Point(172, 133);
            this.tB_dbPwd.Name = "tB_dbPwd";
            this.tB_dbPwd.Size = new System.Drawing.Size(158, 30);
            this.tB_dbPwd.TabIndex = 9;
            // 
            // tB_database
            // 
            this.tB_database.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_database.Location = new System.Drawing.Point(172, 177);
            this.tB_database.Name = "tB_database";
            this.tB_database.Size = new System.Drawing.Size(158, 30);
            this.tB_database.TabIndex = 10;
            this.tB_database.Text = "typecho";
            // 
            // tB_preTableName
            // 
            this.tB_preTableName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_preTableName.Location = new System.Drawing.Point(173, 220);
            this.tB_preTableName.Name = "tB_preTableName";
            this.tB_preTableName.Size = new System.Drawing.Size(158, 30);
            this.tB_preTableName.TabIndex = 11;
            this.tB_preTableName.Text = "typecho_";
            // 
            // tB_uploadFileUrl
            // 
            this.tB_uploadFileUrl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_uploadFileUrl.Location = new System.Drawing.Point(173, 261);
            this.tB_uploadFileUrl.Name = "tB_uploadFileUrl";
            this.tB_uploadFileUrl.Size = new System.Drawing.Size(327, 21);
            this.tB_uploadFileUrl.TabIndex = 12;
            this.tB_uploadFileUrl.Text = "http://localhost/typecho/usr/upload_file.php";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "测试连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tB_blogUrl
            // 
            this.tB_blogUrl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tB_blogUrl.Location = new System.Drawing.Point(131, 294);
            this.tB_blogUrl.Name = "tB_blogUrl";
            this.tB_blogUrl.Size = new System.Drawing.Size(167, 21);
            this.tB_blogUrl.TabIndex = 16;
            this.tB_blogUrl.Text = "http://localhost/typecho/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(26, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "博客地址：";
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 368);
            this.Controls.Add(this.tB_blogUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_uploadFileUrl);
            this.Controls.Add(this.tB_preTableName);
            this.Controls.Add(this.tB_database);
            this.Controls.Add(this.tB_dbPwd);
            this.Controls.Add(this.tB_dbUser);
            this.Controls.Add(this.tB_dbServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_setting";
            this.Text = "配置";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_dbServer;
        private System.Windows.Forms.TextBox tB_dbUser;
        private System.Windows.Forms.TextBox tB_dbPwd;
        private System.Windows.Forms.TextBox tB_database;
        private System.Windows.Forms.TextBox tB_preTableName;
        private System.Windows.Forms.TextBox tB_uploadFileUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tB_blogUrl;
        private System.Windows.Forms.Label label7;
    }
}