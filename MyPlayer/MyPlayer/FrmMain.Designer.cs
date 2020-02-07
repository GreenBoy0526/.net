namespace MyPlayer
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.dgvVedioList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVedioList)).BeginInit();
            this.cms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVedioList
            // 
            this.dgvVedioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVedioList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.videoname,
            this.Path});
            this.dgvVedioList.ContextMenuStrip = this.cms;
            this.dgvVedioList.Location = new System.Drawing.Point(6, 20);
            this.dgvVedioList.Name = "dgvVedioList";
            this.dgvVedioList.RowTemplate.Height = 23;
            this.dgvVedioList.Size = new System.Drawing.Size(345, 190);
            this.dgvVedioList.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            // 
            // videoname
            // 
            this.videoname.DataPropertyName = "Name";
            this.videoname.HeaderText = "名称";
            this.videoname.Name = "videoname";
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "位置";
            this.Path.Name = "Path";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlayer});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiPlayer
            // 
            this.tsmiPlayer.Name = "tsmiPlayer";
            this.tsmiPlayer.Size = new System.Drawing.Size(100, 22);
            this.tsmiPlayer.Text = "播放";
            this.tsmiPlayer.Click += new System.EventHandler(this.tsmiPlayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVedioList);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "播放列表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 240);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVedioList)).EndInit();
            this.cms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVedioList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
    }
}