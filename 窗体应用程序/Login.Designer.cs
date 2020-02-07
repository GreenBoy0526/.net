namespace 窗体应用程序
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbLoginType = new System.Windows.Forms.ComboBox();
            this.butdenglu = new System.Windows.Forms.Button();
            this.butquxiao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "登录类型：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 223);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 21);
            this.textBox2.TabIndex = 4;
            // 
            // cmbLoginType
            // 
            this.cmbLoginType.FormattingEnabled = true;
            this.cmbLoginType.Items.AddRange(new object[] {
            "管理员",
            "学生"});
            this.cmbLoginType.Location = new System.Drawing.Point(246, 263);
            this.cmbLoginType.Name = "cmbLoginType";
            this.cmbLoginType.Size = new System.Drawing.Size(178, 20);
            this.cmbLoginType.TabIndex = 5;
            // 
            // butdenglu
            // 
            this.butdenglu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butdenglu.BackgroundImage")));
            this.butdenglu.Location = new System.Drawing.Point(189, 294);
            this.butdenglu.Name = "butdenglu";
            this.butdenglu.Size = new System.Drawing.Size(84, 21);
            this.butdenglu.TabIndex = 6;
            this.butdenglu.Text = "登录";
            this.butdenglu.UseVisualStyleBackColor = true;
            this.butdenglu.Click += new System.EventHandler(this.button1_Click);
            // 
            // butquxiao
            // 
            this.butquxiao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butquxiao.BackgroundImage")));
            this.butquxiao.Location = new System.Drawing.Point(313, 294);
            this.butquxiao.Name = "butquxiao";
            this.butquxiao.Size = new System.Drawing.Size(84, 21);
            this.butquxiao.TabIndex = 7;
            this.butquxiao.Text = "取消";
            this.butquxiao.UseVisualStyleBackColor = true;
            this.butquxiao.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.butquxiao);
            this.Controls.Add(this.butdenglu);
            this.Controls.Add(this.cmbLoginType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(522, 413);
            this.MinimumSize = new System.Drawing.Size(522, 413);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbLoginType;
        private System.Windows.Forms.Button butdenglu;
        private System.Windows.Forms.Button butquxiao;
    }
}
