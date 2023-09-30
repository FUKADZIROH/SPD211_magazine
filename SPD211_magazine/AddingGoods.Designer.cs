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
            l_number = new Label();
            l3 = new Label();
            tb_goodsName = new TextBox();
            l_goodName = new Label();
            tb_number = new TextBox();
            tb_price = new TextBox();
            Add = new Button();
            SuspendLayout();
            // 
            // l_number
            // 
            l_number.AutoSize = true;
            l_number.Location = new Point(38, 60);
            l_number.Name = "l_number";
            l_number.Size = new Size(56, 15);
            l_number.TabIndex = 1;
            l_number.Text = "Кількість";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(22, 92);
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
            // tb_number
            // 
            tb_number.Location = new Point(107, 57);
            tb_number.Name = "tb_number";
            tb_number.Size = new Size(164, 23);
            tb_number.TabIndex = 7;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(107, 89);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(164, 23);
            tb_price.TabIndex = 8;
            // 
            // Add
            // 
            Add.Location = new Point(22, 125);
            Add.Name = "Add";
            Add.Size = new Size(249, 41);
            Add.TabIndex = 9;
            Add.Text = "Додати товар";
            Add.UseVisualStyleBackColor = true;
            // 
            // AddingGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 191);
            Controls.Add(Add);
            Controls.Add(tb_price);
            Controls.Add(tb_number);
            Controls.Add(l_goodName);
            Controls.Add(tb_goodsName);
            Controls.Add(l3);
            Controls.Add(l_number);
            Name = "AddingGoods";
            Text = "AddingGoods";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label l_number;
        private Label l3;
        private TextBox tb_goodsName;
        private Label l_goodName;
        private TextBox tb_number;
        private TextBox tb_price;
        private Button Add;
    }
}