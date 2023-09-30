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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AddGoods(object sender, EventArgs e)
        {
            AddingGoods addinggoods = new AddingGoods();
            addinggoods.StartPosition = FormStartPosition.CenterScreen;
            var res = addinggoods.ShowDialog();
            if (res == DialogResult.OK)
            {
                lb_goods.Items.Add(addinggoods.good);
            }

        }

        private void RemoveClick(object sender, EventArgs e)
        {
            int index = lb_goods.SelectedIndex;
            lb_goods.Items.RemoveAt(index);
        }

        private void ChangeGoodsClick(object sender, EventArgs e)
        {
            int index = lb_goods.SelectedIndex;
            ChangeScreen changeScreen = new ChangeScreen();
            changeScreen.StartPosition = FormStartPosition.CenterScreen;
            var rs = changeScreen.ShowDialog();
            if (rs == DialogResult.OK)
            {
                lb_goods.Items.RemoveAt(index);
                lb_goods.Items.Insert(index, changeScreen.good2);
            }
        }
    }
}
