namespace calc
{
    partial class FrmCalc
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
            this.txtLeftOper = new System.Windows.Forms.TextBox();
            this.txtRightOper = new System.Windows.Forms.TextBox();
            this.cmdOper = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.gbCalc = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.gbCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLeftOper
            // 
            this.txtLeftOper.Location = new System.Drawing.Point(20, 35);
            this.txtLeftOper.Name = "txtLeftOper";
            this.txtLeftOper.Size = new System.Drawing.Size(66, 21);
            this.txtLeftOper.TabIndex = 0;
            // 
            // txtRightOper
            // 
            this.txtRightOper.Location = new System.Drawing.Point(202, 35);
            this.txtRightOper.Name = "txtRightOper";
            this.txtRightOper.Size = new System.Drawing.Size(63, 21);
            this.txtRightOper.TabIndex = 0;
            // 
            // cmdOper
            // 
            this.cmdOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdOper.FormattingEnabled = true;
            this.cmdOper.Items.AddRange(new object[] {
            "    +",
            "    -",
            "    *",
            "    /"});
            this.cmdOper.Location = new System.Drawing.Point(110, 35);
            this.cmdOper.Name = "cmdOper";
            this.cmdOper.Size = new System.Drawing.Size(67, 20);
            this.cmdOper.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(283, 35);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.ForeColor = System.Drawing.Color.Black;
            this.lbInfo.Location = new System.Drawing.Point(99, 123);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(72, 16);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Text = "计算结果";
            // 
            // gbCalc
            // 
            this.gbCalc.Controls.Add(this.btnCalc);
            this.gbCalc.Controls.Add(this.txtLeftOper);
            this.gbCalc.Controls.Add(this.txtRightOper);
            this.gbCalc.Controls.Add(this.cmdOper);
            this.gbCalc.Location = new System.Drawing.Point(24, 34);
            this.gbCalc.Name = "gbCalc";
            this.gbCalc.Size = new System.Drawing.Size(374, 72);
            this.gbCalc.TabIndex = 4;
            this.gbCalc.TabStop = false;
            this.gbCalc.Text = "计算";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.ForeColor = System.Drawing.Color.Black;
            this.lbResult.Location = new System.Drawing.Point(188, 122);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(79, 20);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "       ";
            this.lbResult.Visible = false;
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 165);
            this.Controls.Add(this.gbCalc);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbInfo);
            this.MaximizeBox = false;
            this.Name = "FrmCalc";
            this.Text = "计算器";
            this.gbCalc.ResumeLayout(false);
            this.gbCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeftOper;
        private System.Windows.Forms.TextBox txtRightOper;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.GroupBox gbCalc;
        private System.Windows.Forms.Label lbResult;
        public System.Windows.Forms.ComboBox cmdOper;
    }
}