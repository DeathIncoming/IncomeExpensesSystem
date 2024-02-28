namespace IncomeExpensesSystem
{
    partial class AuthorizeForm
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
            panel1 = new Panel();
            loginRegistryBtn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
            label3 = new Label();
            label4 = new Label();
            loginUserName = new TextBox();
            loginPassword = new TextBox();
            label5 = new Label();
            loginBtn = new Button();
            loginShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(loginRegistryBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 588);
            panel1.TabIndex = 0;
            // 
            // loginRegistryBtn
            // 
            loginRegistryBtn.BackColor = Color.FromArgb(255, 128, 0);
            loginRegistryBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            loginRegistryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            loginRegistryBtn.FlatStyle = FlatStyle.Flat;
            loginRegistryBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginRegistryBtn.ForeColor = Color.White;
            loginRegistryBtn.Location = new Point(12, 497);
            loginRegistryBtn.Name = "loginRegistryBtn";
            loginRegistryBtn.Size = new Size(356, 52);
            loginRegistryBtn.TabIndex = 9;
            loginRegistryBtn.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            loginRegistryBtn.UseVisualStyleBackColor = false;
            loginRegistryBtn.Click += loginRegistryBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(124, 461);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 9;
            label6.Text = "РЕГИСТРАЦИЯ";
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(134, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(770, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(420, 84);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 2;
            label3.Text = "АВТОРИЗАЦИЯ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(420, 179);
            label4.Name = "label4";
            label4.Size = new Size(143, 19);
            label4.TabIndex = 3;
            label4.Text = "Имя пользователя";
            // 
            // loginUserName
            // 
            loginUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginUserName.Location = new Point(420, 201);
            loginUserName.Name = "loginUserName";
            loginUserName.Size = new Size(326, 33);
            loginUserName.TabIndex = 4;
            // 
            // loginPassword
            // 
            loginPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginPassword.Location = new Point(420, 261);
            loginPassword.Name = "loginPassword";
            loginPassword.PasswordChar = '*';
            loginPassword.Size = new Size(326, 33);
            loginPassword.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(420, 239);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 5;
            label5.Text = "Пароль";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(255, 128, 0);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(420, 447);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 50);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "ВОЙТИ";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // loginShowPass
            // 
            loginShowPass.AutoSize = true;
            loginShowPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginShowPass.Location = new Point(586, 300);
            loginShowPass.Name = "loginShowPass";
            loginShowPass.Size = new Size(160, 24);
            loginShowPass.TabIndex = 8;
            loginShowPass.Text = "Показать пароль";
            loginShowPass.UseVisualStyleBackColor = true;
            loginShowPass.CheckedChanged += loginShowPass_CheckedChanged;
            // 
            // AuthorizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(loginShowPass);
            Controls.Add(loginBtn);
            Controls.Add(loginPassword);
            Controls.Add(label5);
            Controls.Add(loginUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorizeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox loginUserName;
        private TextBox loginPassword;
        private Label label5;
        private Button loginBtn;
        private CheckBox loginShowPass;
        private Button loginRegistryBtn;
        private Label label6;
    }
}
