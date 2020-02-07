namespace MyPizzaShop
{
    partial class FrmOrder
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCheese = new System.Windows.Forms.RadioButton();
            this.rdoBacon = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.rdoBacon);
            this.groupBox1.Controls.Add(this.rdoCheese);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订购窗口";
            // 
            // rdoCheese
            // 
            this.rdoCheese.AutoSize = true;
            this.rdoCheese.Location = new System.Drawing.Point(29, 36);
            this.rdoCheese.Name = "rdoCheese";
            this.rdoCheese.Size = new System.Drawing.Size(71, 16);
            this.rdoCheese.TabIndex = 0;
            this.rdoCheese.TabStop = true;
            this.rdoCheese.Text = "奶酪比萨";
            this.rdoCheese.UseVisualStyleBackColor = true;
            // 
            // rdoBacon
            // 
            this.rdoBacon.AutoSize = true;
            this.rdoBacon.Location = new System.Drawing.Point(29, 67);
            this.rdoBacon.Name = "rdoBacon";
            this.rdoBacon.Size = new System.Drawing.Size(71, 16);
            this.rdoBacon.TabIndex = 1;
            this.rdoBacon.TabStop = true;
            this.rdoBacon.Text = "培根比萨";
            this.rdoBacon.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(170, 100);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "订购";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 165);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrder";
            this.Text = "MyPizzaShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton rdoBacon;
        private System.Windows.Forms.RadioButton rdoCheese;
    }
}

