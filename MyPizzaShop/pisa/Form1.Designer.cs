﻿namespace pisa
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNaiLao = new System.Windows.Forms.RadioButton();
            this.rbPeiGen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rbPeiGen);
            this.groupBox1.Controls.Add(this.rbNaiLao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订购窗口";
            // 
            // rbNaiLao
            // 
            this.rbNaiLao.AutoSize = true;
            this.rbNaiLao.Location = new System.Drawing.Point(34, 40);
            this.rbNaiLao.Name = "rbNaiLao";
            this.rbNaiLao.Size = new System.Drawing.Size(47, 16);
            this.rbNaiLao.TabIndex = 0;
            this.rbNaiLao.TabStop = true;
            this.rbNaiLao.Text = "奶酪";
            this.rbNaiLao.UseVisualStyleBackColor = true;
            this.rbNaiLao.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPeiGen
            // 
            this.rbPeiGen.AutoSize = true;
            this.rbPeiGen.Location = new System.Drawing.Point(34, 108);
            this.rbPeiGen.Name = "rbPeiGen";
            this.rbPeiGen.Size = new System.Drawing.Size(47, 16);
            this.rbPeiGen.TabIndex = 0;
            this.rbPeiGen.TabStop = true;
            this.rbPeiGen.Text = "培根";
            this.rbPeiGen.UseVisualStyleBackColor = true;
            this.rbPeiGen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "订购";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 210);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNaiLao;
        private System.Windows.Forms.RadioButton rbPeiGen;
        private System.Windows.Forms.Button button1;
    }
}

