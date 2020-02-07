using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calc
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
            this.cmdOper.SelectedIndex = 0;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region 验证
            if (string.IsNullOrEmpty(this.txtLeftOper.Text.Trim()))
            {
                MessageBox.Show("操作数不能为空！");
                this.txtLeftOper.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtRightOper.Text.Trim()))
            {
                MessageBox.Show("操作数不能为空！");
                this.txtRightOper.Focus();
                return;
            }
            #endregion
            //设置符号
            try
            {
                Operation opr = new Operation();
              
                switch (this.cmdOper.SelectedItem.ToString().Trim())
                {
                    case "+":
                    {
                        opr = new OperationAdd();
                        break;
                    } 
                    case "-":
                    {
                        opr = new OperationSub(); 
                        break;
                    } 
                    case "*":
                    {
                        opr = new OperationMul();
                        break;
                    } 
                    case "/":
                    {
                        opr = new OperationDiv();
                        break;           
                     } 
                }
                //设置参与计算的数据

                opr.NumberA = double.Parse(this.txtLeftOper.Text.Trim());
                opr.NumberB = double.Parse(this.txtRightOper.Text.Trim());
                //计算
                this.lbResult.Text = opr.GetResult().ToString();
                this.lbInfo.Visible = true;
                this.lbResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生错误！"+ex.Message);
            }
        }

        private void axWebBrowser1_Enter(object sender, EventArgs e)
        {

        }
    }
}
