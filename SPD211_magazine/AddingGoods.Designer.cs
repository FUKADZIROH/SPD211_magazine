namespace SPD211_magazine
{
    partial class AddingGoods
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
            l3 = new Label();
            tb_goodsName = new TextBox();
            l_goodName = new Label();
            tb_price = new TextBox();
            add_ = new Button();
            SuspendLayout();
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(22, 65);
            l3.Name = "l3";
            l3.Size = new Size(72, 15);
            l3.TabIndex = 3;
            l3.Text = "Ціна товару";
            // 
            // tb_goodsName
            // 
            tb_goodsName.Location = new Point(107, 27);
            tb_goodsName.Name = "tb_goodsName";
            tb_goodsName.Size = new Size(164, 23);
            tb_goodsName.TabIndex = 5;
            // 
            // l_goodName
            // 
            l_goodName.AutoSize = true;
            l_goodName.Location = new Point(22, 30);
            l_goodName.Name = "l_goodName";
            l_goodName.Size = new Size(79, 15);
            l_goodName.TabIndex = 6;
            l_goodName.Text = "Назва товару";
            // 
            // tb_price
            // 
            tb_price.Location = new Point(107, 62);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(164, 23);
            tb_price.TabIndex = 8;
            // 
            // add_
            // 
            add_.Location = new Point(22, 102);
            add_.Name = "add_";
            add_.Size = new Size(249, 42);
            add_.TabIndex = 9;
            add_.Text = "Додати товар";
            add_.UseVisualStyleBackColor = true;
            add_.Click += adding;
            // 
            // AddingGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 162);
            Controls.Add(add_);
            Controls.Add(tb_price);
            Controls.Add(l_goodName);
            Controls.Add(tb_goodsName);
            Controls.Add(l3);
            Name = "AddingGoods";
            Text = "AddingGoods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label l3;
        private TextBox tb_goodsName;
        private Label l_goodName;
        private TextBox tb_price;
        private Button Add;
        private Button add_;
    }
}