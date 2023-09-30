namespace SPD211_magazine
{
    partial class AdminScreen
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
            gb_adminTools = new GroupBox();
            changeGoods = new Button();
            removeGoods = new Button();
            addGoods = new Button();
            lb_goods = new ListBox();
            gb_adminTools.SuspendLayout();
            SuspendLayout();
            // 
            // gb_adminTools
            // 
            gb_adminTools.Controls.Add(changeGoods);
            gb_adminTools.Controls.Add(removeGoods);
            gb_adminTools.Controls.Add(addGoods);
            gb_adminTools.Location = new Point(12, 12);
            gb_adminTools.Name = "gb_adminTools";
            gb_adminTools.Size = new Size(359, 203);
            gb_adminTools.TabIndex = 0;
            gb_adminTools.TabStop = false;
            gb_adminTools.Text = "Інструменти";
            // 
            // changeGoods
            // 
            changeGoods.Location = new Point(17, 143);
            changeGoods.Name = "changeGoods";
            changeGoods.Size = new Size(322, 44);
            changeGoods.TabIndex = 2;
            changeGoods.Text = "Змінити товар";
            changeGoods.UseVisualStyleBackColor = true;
            changeGoods.Click += ChangeGoodsClick;
            // 
            // removeGoods
            // 
            removeGoods.Location = new Point(17, 83);
            removeGoods.Name = "removeGoods";
            removeGoods.Size = new Size(322, 44);
            removeGoods.TabIndex = 1;
            removeGoods.Text = "Видалити товар";
            removeGoods.UseVisualStyleBackColor = true;
            removeGoods.Click += RemoveClick;
            // 
            // addGoods
            // 
            addGoods.Location = new Point(17, 22);
            addGoods.Name = "addGoods";
            addGoods.Size = new Size(322, 44);
            addGoods.TabIndex = 0;
            addGoods.Text = "Додати товар";
            addGoods.UseVisualStyleBackColor = true;
            addGoods.Click += AddGoods;
            // 
            // lb_goods
            // 
            lb_goods.FormattingEnabled = true;
            lb_goods.ItemHeight = 15;
            lb_goods.Location = new Point(389, 9);
            lb_goods.Name = "lb_goods";
            lb_goods.Size = new Size(399, 424);
            lb_goods.TabIndex = 1;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_goods);
            Controls.Add(gb_adminTools);
            Name = "AdminScreen";
            Text = "AdminScreen";
            gb_adminTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_adminTools;
        private Button changeGoods;
        private Button removeGoods;
        private Button addGoods;
        private ListBox lb_goods;
    }
}