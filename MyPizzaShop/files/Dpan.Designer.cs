namespace files
{
    partial class Dpan
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(191, 638);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.fileLength,
            this.fileType,
            this.filePath});
            this.lvFiles.GridLines = true;
            this.lvFiles.Location = new System.Drawing.Point(209, 12);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(605, 638);
            this.lvFiles.TabIndex = 2;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // filename
            // 
            this.filename.Text = "文件名";
            this.filename.Width = 107;
            // 
            // fileLength
            // 
            this.fileLength.Text = "文件大小(KB)";
            this.fileLength.Width = 101;
            // 
            // fileType
            // 
            this.fileType.Text = "文件类型";
            this.fileType.Width = 96;
            // 
            // filePath
            // 
            this.filePath.Text = "文件路径";
            this.filePath.Width = 69;
            // 
            // Dpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 662);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.treeView1);
            this.Name = "Dpan";
            this.Text = "Dpan";
            this.Load += new System.EventHandler(this.Dpan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader fileLength;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader filePath;
    }
}