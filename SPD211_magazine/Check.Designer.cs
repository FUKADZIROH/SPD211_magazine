namespace SPD211_magazine
{
    partial class F_Check
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
            L_ShopName = new Label();
            LB_CheckGoods = new ListBox();
            L_ToPay = new Label();
            LB_PaySum = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // L_ShopName
            // 
            L_ShopName.AutoSize = true;
            L_ShopName.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            L_ShopName.Location = new Point(41, 9);
            L_ShopName.Name = "L_ShopName";
            L_ShopName.Size = new Size(246, 40);
            L_ShopName.TabIndex = 0;
            L_ShopName.Text = "Магазин СПД211";
            // 
            // LB_CheckGoods
            // 
            LB_CheckGoods.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LB_CheckGoods.FormattingEnabled = true;
            LB_CheckGoods.ItemHeight = 20;
            LB_CheckGoods.Location = new Point(13, 52);
            LB_CheckGoods.Name = "LB_CheckGoods";
            LB_CheckGoods.SelectionMode = SelectionMode.None;
            LB_CheckGoods.Size = new Size(308, 264);
            LB_CheckGoods.TabIndex = 5;
            // 
            // L_ToPay
            // 
            L_ToPay.AutoSize = true;
            L_ToPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_ToPay.Location = new Point(12, 338);
            L_ToPay.Name = "L_ToPay";
            L_ToPay.Size = new Size(112, 28);
            L_ToPay.TabIndex = 6;
            L_ToPay.Text = "До оплати:";
            L_ToPay.Click += label1_Click;
            // 
            // LB_PaySum
            // 
            LB_PaySum.BorderStyle = BorderStyle.None;
            LB_PaySum.Location = new Point(130, 345);
            LB_PaySum.Name = "LB_PaySum";
            LB_PaySum.ReadOnly = true;
            LB_PaySum.Size = new Size(156, 20);
            LB_PaySum.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(292, 346);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 8;
            label2.Text = "грн.";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(13, 396);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(308, 20);
            textBox1.TabIndex = 9;
            textBox1.Text = "№";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 450);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 10;
            label1.Text = "Гарного дня!";
            // 
            // F_Check
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 522);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(LB_PaySum);
            Controls.Add(L_ToPay);
            Controls.Add(LB_CheckGoods);
            Controls.Add(L_ShopName);
            Name = "F_Check";
            Text = "Чек";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label L_ShopName;
        private ListBox LB_CheckGoods;
        private Label L_ToPay;
        private TextBox LB_PaySum;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}