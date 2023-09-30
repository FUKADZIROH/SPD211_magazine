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
    public partial class ChangeScreen : Form
    {
        public Good good2 { get; set; }
        public ChangeScreen()
        {
            InitializeComponent();
        }

        private void ChangeClick(object sender, EventArgs e)
        {
            if (tb_nameGood == null)
            {
                throw new Exception("Ви не ввели назву!");
            }
            else if (tb_priceGood == null)
            {
                throw new Exception("Ви не ввели ціну!");
            }

            good2 = new Good(tb_nameGood.Text, Convert.ToInt32(tb_priceGood.Text));
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
