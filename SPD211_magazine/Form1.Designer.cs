namespace SPD211_magazine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_1 = new Button();
            bt_2 = new Button();
            lb_1 = new Label();
            lb_2 = new Label();
            tb_1 = new TextBox();
            tb_2 = new TextBox();
            lb_3 = new Label();
            SuspendLayout();
            // 
            // bt_1
            // 
            bt_1.Location = new Point(116, 126);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(125, 31);
            bt_1.TabIndex = 0;
            bt_1.Text = "Sign In";
            bt_1.UseVisualStyleBackColor = true;
            bt_1.Click += SingInAccount;
            // 
            // bt_2
            // 
            bt_2.Location = new Point(116, 204);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(125, 31);
            bt_2.TabIndex = 1;
            bt_2.Text = "Register";
            bt_2.UseVisualStyleBackColor = true;
            bt_2.Click += RedisterAnAccount;
            // 
            // lb_1
            // 
            lb_1.AutoSize = true;
            lb_1.Location = new Point(12, 38);
            lb_1.Name = "lb_1";
            lb_1.Size = new Size(46, 20);
            lb_1.TabIndex = 2;
            lb_1.Text = "Login";
            // 
            // lb_2
            // 
            lb_2.AutoSize = true;
            lb_2.Location = new Point(12, 82);
            lb_2.Name = "lb_2";
            lb_2.Size = new Size(70, 20);
            lb_2.TabIndex = 3;
            lb_2.Text = "Password";
            // 
            // tb_1
            // 
            tb_1.Location = new Point(116, 31);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(125, 27);
            tb_1.TabIndex = 4;
            // 
            // tb_2
            // 
            tb_2.Location = new Point(116, 75);
            tb_2.Name = "tb_2";
            tb_2.Size = new Size(125, 27);
            tb_2.TabIndex = 5;
            // 
            // lb_3
            // 
            lb_3.AutoSize = true;
            lb_3.Location = new Point(12, 171);
            lb_3.Name = "lb_3";
            lb_3.Size = new Size(167, 20);
            lb_3.TabIndex = 6;
            lb_3.Text = "Don't have an account? ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 250);
            Controls.Add(lb_3);
            Controls.Add(tb_2);
            Controls.Add(tb_1);
            Controls.Add(lb_2);
            Controls.Add(lb_1);
            Controls.Add(bt_2);
            Controls.Add(bt_1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_1;
        private Button bt_2;
        private Label lb_1;
        private Label lb_2;
        private TextBox tb_1;
        private TextBox tb_2;
        private Label lb_3;
    }
}