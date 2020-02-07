namespace 窗体应用程序
{
    partial class Tree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("S1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 299);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(624, 299);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点5";
            treeNode1.Text = "男";
            treeNode2.Name = "节点7";
            treeNode2.Text = "女";
            treeNode3.Name = "节点3";
            treeNode3.Text = "S1";
            treeNode4.Name = "节点0";
            treeNode4.Text = "男";
            treeNode5.Name = "节点2";
            treeNode5.Text = "女";
            treeNode6.Name = "节点8";
            treeNode6.Text = "S2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(177, 299);
            this.treeView1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Sex,
            this.BornDate,
            this.Address});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(443, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // BornDate
            // 
            this.BornDate.HeaderText = "出生日期";
            this.BornDate.Name = "BornDate";
            // 
            // Address
            // 
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 299);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(640, 0);
            this.Name = "Tree";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Tree_Load);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BornDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}