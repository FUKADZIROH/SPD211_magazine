using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPD211_magazine
{
    public class Good
    {


        public string name { get; set; }
        public int price { get; set; }

        public Good()
        {
            name = string.Empty;
            price = 0;
        }

        public Good(string Name, int Price)
        {
            name = Name;
            price = Price;
        }
        public override string ToString()
        {
            return $"{name} - {price}$";
        }
    }
    public partial class AddingGoods : Form
    {
       
        public Good good { set; get; }
        public AddingGoods()
        {
            InitializeComponent();
        }

        private void adding(object sender, EventArgs e)
        {
            try
            {
                if (tb_goodsName == null)
                {
                    throw new Exception("Ви не ввели назву!");
                }
                else if (tb_price == null)
                {
                    throw new Exception("Ви не ввели ціну!");
                }

                good = new Good(tb_goodsName.Text, Convert.ToInt32(tb_price.Text));
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
