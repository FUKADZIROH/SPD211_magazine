namespace SPD211_magazine
{
    partial class RegistrationForm
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
            lb_1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            bt_AddUser = new Button();
            tb_Name = new TextBox();
            tb_Surname = new TextBox();
            tb_Middlename = new TextBox();
            tb_Age = new TextBox();
            tb_PhoneNumber = new TextBox();
            tb_Email = new TextBox();
            tb_UserLogin = new TextBox();
            tb_UserPassword = new TextBox();
            tb_UserPasswordConfirm = new TextBox();
            cb_IsAdmin = new CheckBox();
            SuspendLayout();
            // 
            // lb_1
            // 
            lb_1.AutoSize = true;
            lb_1.Location = new Point(244, 9);
            lb_1.Name = "lb_1";
            lb_1.Size = new Size(276, 20);
            lb_1.TabIndex = 1;
            lb_1.Text = "Форма реєстрації нового користувача";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 53);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 88);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Прізвище";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 127);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 4;
            label3.Text = "По батькові";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 199);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 5;
            label4.Text = "Контактний телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 165);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 6;
            label5.Text = "Вік";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 291);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 7;
            label6.Text = "Логін";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 238);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 8;
            label7.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 333);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 9;
            label8.Text = "Пароль";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 380);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 10;
            label9.Text = "Повторіть пароль";
            // 
            // bt_AddUser
            // 
            bt_AddUser.Location = new Point(130, 457);
            bt_AddUser.Name = "bt_AddUser";
            bt_AddUser.Size = new Size(390, 47);
            bt_AddUser.TabIndex = 11;
            bt_AddUser.Text = "Зареєструватись";
            bt_AddUser.UseVisualStyleBackColor = true;
            bt_AddUser.Click += AddNewUser;
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(298, 53);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(222, 27);
            tb_Name.TabIndex = 13;
            // 
            // tb_Surname
            // 
            tb_Surname.Location = new Point(298, 88);
            tb_Surname.Name = "tb_Surname";
            tb_Surname.Size = new Size(222, 27);
            tb_Surname.TabIndex = 14;
            // 
            // tb_Middlename
            // 
            tb_Middlename.Location = new Point(298, 127);
            tb_Middlename.Name = "tb_Middlename";
            tb_Middlename.Size = new Size(222, 27);
            tb_Middlename.TabIndex = 15;
            // 
            // tb_Age
            // 
            tb_Age.Location = new Point(298, 165);
            tb_Age.Name = "tb_Age";
            tb_Age.Size = new Size(125, 27);
            tb_Age.TabIndex = 16;
            // 
            // tb_PhoneNumber
            // 
            tb_PhoneNumber.Location = new Point(298, 199);
            tb_PhoneNumber.Name = "tb_PhoneNumber";
            tb_PhoneNumber.Size = new Size(222, 27);
            tb_PhoneNumber.TabIndex = 17;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(298, 235);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(222, 27);
            tb_Email.TabIndex = 18;
            // 
            // tb_UserLogin
            // 
            tb_UserLogin.Location = new Point(298, 288);
            tb_UserLogin.Name = "tb_UserLogin";
            tb_UserLogin.Size = new Size(222, 27);
            tb_UserLogin.TabIndex = 19;
            // 
            // tb_UserPassword
            // 
            tb_UserPassword.Location = new Point(298, 330);
            tb_UserPassword.Name = "tb_UserPassword";
            tb_UserPassword.Size = new Size(222, 27);
            tb_UserPassword.TabIndex = 20;
            // 
            // tb_UserPasswordConfirm
            // 
            tb_UserPasswordConfirm.Location = new Point(298, 373);
            tb_UserPasswordConfirm.Name = "tb_UserPasswordConfirm";
            tb_UserPasswordConfirm.Size = new Size(222, 27);
            tb_UserPasswordConfirm.TabIndex = 21;
            // 
            // cb_IsAdmin
            // 
            cb_IsAdmin.AutoSize = true;
            cb_IsAdmin.Location = new Point(138, 417);
            cb_IsAdmin.Name = "cb_IsAdmin";
            cb_IsAdmin.Size = new Size(84, 24);
            cb_IsAdmin.TabIndex = 22;
            cb_IsAdmin.Text = "Я адмін";
            cb_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 552);
            Controls.Add(cb_IsAdmin);
            Controls.Add(tb_UserPasswordConfirm);
            Controls.Add(tb_UserPassword);
            Controls.Add(tb_UserLogin);
            Controls.Add(tb_Email);
            Controls.Add(tb_PhoneNumber);
            Controls.Add(tb_Age);
            Controls.Add(tb_Middlename);
            Controls.Add(tb_Surname);
            Controls.Add(tb_Name);
            Controls.Add(bt_AddUser);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistationScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button bt_AddUser;
        private TextBox tb_Name;
        private TextBox tb_Surname;
        private TextBox tb_Middlename;
        private TextBox tb_Age;
        private TextBox tb_PhoneNumber;
        private TextBox tb_Email;
        private TextBox tb_UserLogin;
        private TextBox tb_UserPassword;
        private TextBox tb_UserPasswordConfirm;
        private CheckBox cb_IsAdmin;
    }
}