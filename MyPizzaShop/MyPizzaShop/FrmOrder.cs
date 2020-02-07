using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPizzaShop
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            //根据选择的类型
            string type = null;
            if(this.rdoCheese.Checked)
            {
                type = "奶酪";
            }else if(this.rdoBacon.Checked)
            {
                type = "培根";
            }
            Pizza pizza = OrderPizza(type);
            MessageBox.Show("制作完毕！","提示");
        }

        /// <summary>
        /// 订购
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Pizza OrderPizza(string type) 
        {
            StringBuilder sb = new StringBuilder();
            Pizza pizza = PizzaFactory.CreatePizza(type);
            sb.Append(pizza.Prepare());
            sb.Append(pizza.Bake());
            sb.Append(pizza.Box());
            MessageBox.Show(sb.ToString(),"制作Pizza");
            return pizza;   
        }
    }
}
