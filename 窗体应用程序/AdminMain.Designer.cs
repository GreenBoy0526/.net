namespace 窗体应用程序
{
    partial class AdminMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增学生ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.学生信息管理ToolStripMenuItem.Text = "学生用户管理";
            // 
            // 新增学生ToolStripMenuItem
            // 
            this.新增学生ToolStripMenuItem.Name = "新增学生ToolStripMenuItem";
            this.新增学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增学生ToolStripMenuItem.Text = "新增学生";
            this.新增学生ToolStripMenuItem.Click += new System.EventHandler(this.新增学生ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 463);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMain";
            this.Text = "MySchool-管理员";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
    }
}