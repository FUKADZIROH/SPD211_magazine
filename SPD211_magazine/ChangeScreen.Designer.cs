namespace SPD211_magazine
{
    partial class ChangeScreen
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
            label1 = new Label();
            label2 = new Label();
            tb_nameGood = new TextBox();
            tb_priceGood = new TextBox();
            b_change = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Ціна товару";
            // 
            // tb_nameGood
            // 
            tb_nameGood.Location = new Point(97, 15);
            tb_nameGood.Name = "tb_nameGood";
            tb_nameGood.Size = new Size(100, 23);
            tb_nameGood.TabIndex = 2;
            // 
            // tb_priceGood
            // 
            tb_priceGood.Location = new Point(97, 44);
            tb_priceGood.Name = "tb_priceGood";
            tb_priceGood.Size = new Size(100, 23);
            tb_priceGood.TabIndex = 3;
            // 
            // b_change
            // 
            b_change.Location = new Point(12, 73);
            b_change.Name = "b_change";
            b_change.Size = new Size(185, 32);
            b_change.TabIndex = 4;
            b_change.Text = "Зберегти зміни";
            b_change.UseVisualStyleBackColor = true;
            b_change.Click += ChangeClick;
            // 
            // ChangeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 120);
            Controls.Add(b_change);
            Controls.Add(tb_priceGood);
            Controls.Add(tb_nameGood);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangeScreen";
            Text = "ChangeScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_nameGood;
        private TextBox tb_priceGood;
        private Button b_change;
    }
}