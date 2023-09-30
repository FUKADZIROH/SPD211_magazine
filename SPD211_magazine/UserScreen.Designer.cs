namespace SPD211_magazine
{
    partial class UserScreen
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
            LB_Basket = new ListBox();
            LB_Goods = new ListBox();
            TB_Sum = new TextBox();
            L_Sum = new Label();
            L_Payment = new Label();
            L_CardNum = new Label();
            L_EndDate = new Label();
            TB_EndDate = new TextBox();
            L_CVV2 = new Label();
            TB_CVV2 = new TextBox();
            BT_Pay = new Button();
            label1 = new Label();
            CB_Print_Pay = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            TB_CardNum = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // LB_Basket
            // 
            LB_Basket.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Basket.FormattingEnabled = true;
            LB_Basket.ItemHeight = 20;
            LB_Basket.Location = new Point(9, 12);
            LB_Basket.Name = "LB_Basket";
            LB_Basket.Size = new Size(360, 184);
            LB_Basket.TabIndex = 4;
            // 
            // LB_Goods
            // 
            LB_Goods.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Goods.FormattingEnabled = true;
            LB_Goods.ItemHeight = 20;
            LB_Goods.Location = new Point(378, 14);
            LB_Goods.Name = "LB_Goods";
            LB_Goods.Size = new Size(410, 344);
            LB_Goods.TabIndex = 5;
            // 
            // TB_Sum
            // 
            TB_Sum.Location = new Point(75, 332);
            TB_Sum.Name = "TB_Sum";
            TB_Sum.Size = new Size(104, 27);
            TB_Sum.TabIndex = 6;
            // 
            // L_Sum
            // 
            L_Sum.AutoSize = true;
            L_Sum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            L_Sum.Location = new Point(7, 331);
            L_Sum.Name = "L_Sum";
            L_Sum.Size = new Size(62, 28);
            L_Sum.TabIndex = 7;
            L_Sum.Text = "Сума:";
            // 
            // L_Payment
            // 
            L_Payment.AutoSize = true;
            L_Payment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            L_Payment.Location = new Point(139, 199);
            L_Payment.Name = "L_Payment";
            L_Payment.Size = new Size(79, 28);
            L_Payment.TabIndex = 8;
            L_Payment.Text = "Оплата";
            // 
            // L_CardNum
            // 
            L_CardNum.AutoSize = true;
            L_CardNum.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            L_CardNum.Location = new Point(9, 225);
            L_CardNum.Name = "L_CardNum";
            L_CardNum.Size = new Size(79, 15);
            L_CardNum.TabIndex = 9;
            L_CardNum.Text = "Номер карти";
            L_CardNum.Click += L_CardNum_Click;
            // 
            // L_EndDate
            // 
            L_EndDate.AutoSize = true;
            L_EndDate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            L_EndDate.Location = new Point(7, 281);
            L_EndDate.Name = "L_EndDate";
            L_EndDate.Size = new Size(110, 15);
            L_EndDate.TabIndex = 11;
            L_EndDate.Text = "Термін Закінчення";
            // 
            // TB_EndDate
            // 
            TB_EndDate.Location = new Point(9, 299);
            TB_EndDate.Name = "TB_EndDate";
            TB_EndDate.Size = new Size(170, 27);
            TB_EndDate.TabIndex = 12;
            // 
            // L_CVV2
            // 
            L_CVV2.AutoSize = true;
            L_CVV2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            L_CVV2.Location = new Point(185, 281);
            L_CVV2.Name = "L_CVV2";
            L_CVV2.Size = new Size(35, 15);
            L_CVV2.TabIndex = 13;
            L_CVV2.Text = "CVV2";
            // 
            // TB_CVV2
            // 
            TB_CVV2.Location = new Point(185, 299);
            TB_CVV2.Name = "TB_CVV2";
            TB_CVV2.Size = new Size(170, 27);
            TB_CVV2.TabIndex = 14;
            // 
            // BT_Pay
            // 
            BT_Pay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BT_Pay.Location = new Point(9, 377);
            BT_Pay.Name = "BT_Pay";
            BT_Pay.Size = new Size(344, 61);
            BT_Pay.TabIndex = 15;
            BT_Pay.Text = "Оплатити";
            BT_Pay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(185, 338);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 16;
            label1.Text = "Видрукувати чек:";
            label1.Click += label1_Click;
            // 
            // CB_Print_Pay
            // 
            CB_Print_Pay.AutoSize = true;
            CB_Print_Pay.Location = new Point(317, 342);
            CB_Print_Pay.Name = "CB_Print_Pay";
            CB_Print_Pay.Size = new Size(18, 17);
            CB_Print_Pay.TabIndex = 17;
            CB_Print_Pay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(579, 377);
            button1.Name = "button1";
            button1.Size = new Size(209, 61);
            button1.TabIndex = 18;
            button1.Text = "Додати в кошик";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(378, 388);
            label2.Name = "label2";
            label2.Size = new Size(120, 35);
            label2.TabIndex = 19;
            label2.Text = "Кількість:";
            // 
            // TB_CardNum
            // 
            TB_CardNum.Location = new Point(9, 243);
            TB_CardNum.Name = "TB_CardNum";
            TB_CardNum.Size = new Size(344, 27);
            TB_CardNum.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(504, 396);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(550, 400);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 21;
            label3.Text = "шт.";
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(CB_Print_Pay);
            Controls.Add(label1);
            Controls.Add(BT_Pay);
            Controls.Add(TB_CVV2);
            Controls.Add(L_CVV2);
            Controls.Add(TB_EndDate);
            Controls.Add(L_EndDate);
            Controls.Add(TB_CardNum);
            Controls.Add(L_CardNum);
            Controls.Add(L_Payment);
            Controls.Add(L_Sum);
            Controls.Add(TB_Sum);
            Controls.Add(LB_Goods);
            Controls.Add(LB_Basket);
            Name = "UserScreen";
            Text = "UserScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LB_Basket;
        private ListBox LB_Goods;
        private TextBox TB_Sum;
        private Label L_Sum;
        private Label L_Payment;
        private Label L_CardNum;
        private Label L_EndDate;
        private TextBox TB_EndDate;
        private Label L_CVV2;
        private TextBox TB_CVV2;
        private Button BT_Pay;
        private Label label1;
        private CheckBox CB_Print_Pay;
        private Button button1;
        private Label label2;
        private TextBox TB_CardNum;
        private TextBox textBox1;
        private Label label3;
    }
}