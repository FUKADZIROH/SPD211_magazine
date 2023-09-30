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
            addinggoods.ShowDialog();
        }
    }
}
