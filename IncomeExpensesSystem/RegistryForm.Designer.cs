namespace IncomeExpensesSystem
{
    partial class RegistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryForm));
            registryShowPass = new CheckBox();
            registryBtn = new Button();
            registryPassword = new TextBox();
            label5 = new Label();
            registryUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            close = new Label();
            panel1 = new Panel();
            registryLoginBtn = new Button();
            label6 = new Label();
            label2 = new Label();
            registryRepeatPassword = new TextBox();
            label1 = new Label();
            label7 = new Label();
            addUserIcon = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registryShowPass
            // 
            registryShowPass.AutoSize = true;
            registryShowPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryShowPass.Location = new Point(588, 363);
            registryShowPass.Name = "registryShowPass";
            registryShowPass.Size = new Size(160, 24);
            registryShowPass.TabIndex = 17;
            registryShowPass.Text = "Показать пароль";
            registryShowPass.UseVisualStyleBackColor = true;
            registryShowPass.CheckedChanged += registryShowPass_CheckedChanged;
            // 
            // registryBtn
            // 
            registryBtn.BackColor = Color.FromArgb(255, 128, 0);
            registryBtn.FlatAppearance.BorderSize = 0;
            registryBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            registryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            registryBtn.FlatStyle = FlatStyle.Flat;
            registryBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryBtn.ForeColor = Color.White;
            registryBtn.Location = new Point(422, 507);
            registryBtn.Name = "registryBtn";
            registryBtn.Size = new Size(200, 50);
            registryBtn.TabIndex = 16;
            registryBtn.Text = "ЗАРЕГИСТРИРОВАТЬ";
            registryBtn.UseVisualStyleBackColor = false;
            registryBtn.Click += registryBtn_Click;
            // 
            // registryPassword
            // 
            registryPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryPassword.Location = new Point(422, 262);
            registryPassword.Name = "registryPassword";
            registryPassword.PasswordChar = '*';
            registryPassword.Size = new Size(326, 33);
            registryPassword.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(422, 240);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 14;
            label5.Text = "Пароль";
            // 
            // registryUserName
            // 
            registryUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryUserName.Location = new Point(422, 201);
            registryUserName.Name = "registryUserName";
            registryUserName.Size = new Size(326, 33);
            registryUserName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(422, 179);
            label4.Name = "label4";
            label4.Size = new Size(143, 19);
            label4.TabIndex = 12;
            label4.Text = "Имя пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(422, 84);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 11;
            label3.Text = "РЕГИСТРАЦИЯ";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(768, 9);
            close.Name = "close";
            close.Size = new Size(20, 20);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(registryLoginBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 588);
            panel1.TabIndex = 9;
            // 
            // registryLoginBtn
            // 
            registryLoginBtn.BackColor = Color.FromArgb(255, 128, 0);
            registryLoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            registryLoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            registryLoginBtn.FlatStyle = FlatStyle.Flat;
            registryLoginBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryLoginBtn.ForeColor = Color.White;
            registryLoginBtn.Location = new Point(12, 507);
            registryLoginBtn.Name = "registryLoginBtn";
            registryLoginBtn.Size = new Size(356, 52);
            registryLoginBtn.TabIndex = 9;
            registryLoginBtn.Text = "ПЕРЕЙТИ К АВТОРИЗАЦИИ";
            registryLoginBtn.UseVisualStyleBackColor = false;
            registryLoginBtn.Click += registryLoginBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(124, 464);
            label6.Name = "label6";
            label6.Size = new Size(138, 23);
            label6.TabIndex = 9;
            label6.Text = "АВТОРИЗАЦИЯ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(71, 199);
            label2.Name = "label2";
            label2.Size = new Size(227, 30);
            label2.TabIndex = 1;
            label2.Text = "Доходы и расходы";
            // 
            // registryRepeatPassword
            // 
            registryRepeatPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registryRepeatPassword.Location = new Point(422, 324);
            registryRepeatPassword.Name = "registryRepeatPassword";
            registryRepeatPassword.PasswordChar = '*';
            registryRepeatPassword.Size = new Size(326, 33);
            registryRepeatPassword.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(422, 302);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 18;
            label1.Text = "Повторите пароль";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(422, 390);
            label7.Name = "label7";
            label7.Size = new Size(247, 19);
            label7.TabIndex = 20;
            label7.Text = "Выберите иконку пользователя:";
            // 
            // addUserIcon
            // 
            addUserIcon.BorderStyle = BorderStyle.FixedSingle;
            addUserIcon.Location = new Point(648, 412);
            addUserIcon.Name = "addUserIcon";
            addUserIcon.Size = new Size(100, 100);
            addUserIcon.TabIndex = 21;
            addUserIcon.TabStop = false;
            addUserIcon.Click += addUserIcon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 100);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // RegistryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(addUserIcon);
            Controls.Add(label7);
            Controls.Add(registryRepeatPassword);
            Controls.Add(label1);
            Controls.Add(registryShowPass);
            Controls.Add(registryBtn);
            Controls.Add(registryPassword);
            Controls.Add(label5);
            Controls.Add(registryUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox registryShowPass;
        private Button registryBtn;
        private TextBox registryPassword;
        private Label label5;
        private TextBox registryUserName;
        private Label label4;
        private Label label3;
        private Label close;
        private Panel panel1;
        private Button registryLoginBtn;
        private Label label6;
        private Label label2;
        private TextBox registryRepeatPassword;
        private Label label1;
        private Label label7;
        private PictureBox addUserIcon;
        private PictureBox pictureBox1;
    }
}