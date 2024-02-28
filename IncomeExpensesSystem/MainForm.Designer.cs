namespace IncomeExpensesSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            logoutBtn = new Button();
            expenseBtn = new Button();
            incomeBtn = new Button();
            addCategoryBtn = new Button();
            dashboardBtn = new Button();
            userNameLabel = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dashboardForm1 = new Controls.DashboardForm();
            expensesForm1 = new Controls.ExpensesForm();
            incomeForm1 = new Controls.IncomeForm();
            categoryForm1 = new Controls.CategoryForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 45);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 18);
            label1.TabIndex = 3;
            label1.Text = "Доходы и расходы";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1370, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 2;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(expenseBtn);
            panel2.Controls.Add(incomeBtn);
            panel2.Controls.Add(addCategoryBtn);
            panel2.Controls.Add(dashboardBtn);
            panel2.Controls.Add(userNameLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 755);
            panel2.TabIndex = 1;
            // 
            // logoutBtn
            // 
            logoutBtn.FlatAppearance.BorderColor = Color.White;
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(23, 693);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(190, 40);
            logoutBtn.TabIndex = 7;
            logoutBtn.Text = "Выйти";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // expenseBtn
            // 
            expenseBtn.FlatAppearance.BorderColor = Color.White;
            expenseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            expenseBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            expenseBtn.FlatStyle = FlatStyle.Flat;
            expenseBtn.Font = new Font("Microsoft Sans Serif", 12F);
            expenseBtn.ForeColor = Color.White;
            expenseBtn.Location = new Point(23, 385);
            expenseBtn.Name = "expenseBtn";
            expenseBtn.Size = new Size(190, 40);
            expenseBtn.TabIndex = 6;
            expenseBtn.Text = "Расходы";
            expenseBtn.UseVisualStyleBackColor = true;
            expenseBtn.Click += expenseBtn_Click;
            // 
            // incomeBtn
            // 
            incomeBtn.FlatAppearance.BorderColor = Color.White;
            incomeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            incomeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            incomeBtn.FlatStyle = FlatStyle.Flat;
            incomeBtn.Font = new Font("Microsoft Sans Serif", 12F);
            incomeBtn.ForeColor = Color.White;
            incomeBtn.Location = new Point(23, 339);
            incomeBtn.Name = "incomeBtn";
            incomeBtn.Size = new Size(190, 40);
            incomeBtn.TabIndex = 5;
            incomeBtn.Text = "Доходы";
            incomeBtn.UseVisualStyleBackColor = true;
            incomeBtn.Click += incomeBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.FlatAppearance.BorderColor = Color.White;
            addCategoryBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            addCategoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            addCategoryBtn.FlatStyle = FlatStyle.Flat;
            addCategoryBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addCategoryBtn.ForeColor = Color.White;
            addCategoryBtn.Location = new Point(23, 293);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(190, 40);
            addCategoryBtn.TabIndex = 4;
            addCategoryBtn.Text = "Добавить категорию";
            addCategoryBtn.UseVisualStyleBackColor = true;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderColor = Color.White;
            dashboardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            dashboardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Microsoft Sans Serif", 12F);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.Location = new Point(23, 247);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(190, 40);
            dashboardBtn.TabIndex = 3;
            dashboardBtn.Text = "Личный кабинет";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(23, 197);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(54, 25);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 163);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 1;
            label2.Text = "Добро пожаловать";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(58, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(expensesForm1);
            panel3.Controls.Add(incomeForm1);
            panel3.Controls.Add(categoryForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 755);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1165, 755);
            dashboardForm1.TabIndex = 2;
            // 
            // expensesForm1
            // 
            expensesForm1.Location = new Point(0, 0);
            expensesForm1.Name = "expensesForm1";
            expensesForm1.Size = new Size(1165, 755);
            expensesForm1.TabIndex = 3;
            expensesForm1.Visible = false;
            // 
            // incomeForm1
            // 
            incomeForm1.Location = new Point(0, 0);
            incomeForm1.Name = "incomeForm1";
            incomeForm1.Size = new Size(1165, 755);
            incomeForm1.TabIndex = 1;
            incomeForm1.Visible = false;
            // 
            // categoryForm1
            // 
            categoryForm1.Location = new Point(0, 0);
            categoryForm1.Name = "categoryForm1";
            categoryForm1.Size = new Size(1165, 755);
            categoryForm1.TabIndex = 0;
            categoryForm1.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label userNameLabel;
        private Label label2;
        private PictureBox pictureBox2;
        private Button dashboardBtn;
        private Button expenseBtn;
        private Button incomeBtn;
        private Button addCategoryBtn;
        private Button logoutBtn;
        private Panel panel3;
        private Controls.CategoryForm categoryForm1;
        private Controls.DashboardForm dashboardForm1;
        private Controls.IncomeForm incomeForm1;
        private Controls.ExpensesForm expensesForm1;
    }
}