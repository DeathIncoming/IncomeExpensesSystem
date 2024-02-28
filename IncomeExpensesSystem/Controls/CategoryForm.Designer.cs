namespace IncomeExpensesSystem.Controls
{
    partial class CategoryForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            categoryDeleteBtn = new Button();
            categoryClearBtn = new Button();
            categoryUpdateBtn = new Button();
            categoryAddBtn = new Button();
            categoryStatus = new ComboBox();
            label3 = new Label();
            categoryType = new ComboBox();
            label2 = new Label();
            categoryName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            CategriesDgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIncomeDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dateInsertDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            categoryBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategriesDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(categoryDeleteBtn);
            panel1.Controls.Add(categoryClearBtn);
            panel1.Controls.Add(categoryUpdateBtn);
            panel1.Controls.Add(categoryAddBtn);
            panel1.Controls.Add(categoryStatus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(categoryType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(categoryName);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 726);
            panel1.TabIndex = 0;
            // 
            // categoryDeleteBtn
            // 
            categoryDeleteBtn.BackColor = Color.FromArgb(255, 128, 0);
            categoryDeleteBtn.FlatAppearance.BorderSize = 0;
            categoryDeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            categoryDeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            categoryDeleteBtn.FlatStyle = FlatStyle.Flat;
            categoryDeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryDeleteBtn.Location = new Point(189, 327);
            categoryDeleteBtn.Name = "categoryDeleteBtn";
            categoryDeleteBtn.Size = new Size(125, 44);
            categoryDeleteBtn.TabIndex = 9;
            categoryDeleteBtn.Text = "Удалить";
            categoryDeleteBtn.UseVisualStyleBackColor = false;
            categoryDeleteBtn.Click += categoryDeleteBtn_Click;
            // 
            // categoryClearBtn
            // 
            categoryClearBtn.BackColor = Color.FromArgb(255, 128, 0);
            categoryClearBtn.FlatAppearance.BorderSize = 0;
            categoryClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            categoryClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            categoryClearBtn.FlatStyle = FlatStyle.Flat;
            categoryClearBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryClearBtn.Location = new Point(14, 327);
            categoryClearBtn.Name = "categoryClearBtn";
            categoryClearBtn.Size = new Size(125, 44);
            categoryClearBtn.TabIndex = 8;
            categoryClearBtn.Text = "Очистить";
            categoryClearBtn.UseVisualStyleBackColor = false;
            // 
            // categoryUpdateBtn
            // 
            categoryUpdateBtn.BackColor = Color.FromArgb(255, 128, 0);
            categoryUpdateBtn.FlatAppearance.BorderSize = 0;
            categoryUpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            categoryUpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            categoryUpdateBtn.FlatStyle = FlatStyle.Flat;
            categoryUpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryUpdateBtn.Location = new Point(189, 265);
            categoryUpdateBtn.Name = "categoryUpdateBtn";
            categoryUpdateBtn.Size = new Size(125, 44);
            categoryUpdateBtn.TabIndex = 7;
            categoryUpdateBtn.Text = "Обновить";
            categoryUpdateBtn.UseVisualStyleBackColor = false;
            categoryUpdateBtn.Click += categoryUpdateBtn_Click;
            // 
            // categoryAddBtn
            // 
            categoryAddBtn.BackColor = Color.FromArgb(255, 128, 0);
            categoryAddBtn.FlatAppearance.BorderSize = 0;
            categoryAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            categoryAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            categoryAddBtn.FlatStyle = FlatStyle.Flat;
            categoryAddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryAddBtn.Location = new Point(14, 265);
            categoryAddBtn.Name = "categoryAddBtn";
            categoryAddBtn.Size = new Size(125, 44);
            categoryAddBtn.TabIndex = 6;
            categoryAddBtn.Text = "Добавить";
            categoryAddBtn.UseVisualStyleBackColor = false;
            categoryAddBtn.Click += categoryAddBtn_Click;
            // 
            // categoryStatus
            // 
            categoryStatus.BackColor = Color.FromArgb(255, 192, 128);
            categoryStatus.DisplayMember = "0";
            categoryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryStatus.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryStatus.Items.AddRange(new object[] { "Не активна", "Активна" });
            categoryStatus.Location = new Point(14, 208);
            categoryStatus.Name = "categoryStatus";
            categoryStatus.RightToLeft = RightToLeft.No;
            categoryStatus.Size = new Size(300, 32);
            categoryStatus.TabIndex = 5;
            categoryStatus.ValueMember = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 182);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 4;
            label3.Text = "Статус";
            // 
            // categoryType
            // 
            categoryType.BackColor = Color.FromArgb(255, 192, 128);
            categoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryType.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryType.ImeMode = ImeMode.On;
            categoryType.Items.AddRange(new object[] { "Расходы", "Доходы" });
            categoryType.Location = new Point(14, 121);
            categoryType.Name = "categoryType";
            categoryType.Size = new Size(300, 32);
            categoryType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 2;
            label2.Text = "Тип";
            // 
            // categoryName
            // 
            categoryName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            categoryName.Location = new Point(14, 42);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(300, 29);
            categoryName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Категория";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(CategriesDgv);
            panel2.Location = new Point(356, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 726);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 1;
            label4.Text = "Список категорий";
            // 
            // CategriesDgv
            // 
            CategriesDgv.AllowUserToAddRows = false;
            CategriesDgv.AllowUserToDeleteRows = false;
            CategriesDgv.AllowUserToResizeRows = false;
            CategriesDgv.AutoGenerateColumns = false;
            CategriesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategriesDgv.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategriesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategriesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategriesDgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameCategoryDataGridViewTextBoxColumn, isIncomeDataGridViewCheckBoxColumn, statusDataGridViewCheckBoxColumn, dateInsertDataGridViewTextBoxColumn });
            CategriesDgv.DataSource = categoryBindingSource;
            CategriesDgv.EnableHeadersVisualStyles = false;
            CategriesDgv.Location = new Point(12, 42);
            CategriesDgv.MultiSelect = false;
            CategriesDgv.Name = "CategriesDgv";
            CategriesDgv.ReadOnly = true;
            CategriesDgv.RowHeadersVisible = false;
            CategriesDgv.Size = new Size(764, 672);
            CategriesDgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameCategoryDataGridViewTextBoxColumn
            // 
            nameCategoryDataGridViewTextBoxColumn.DataPropertyName = "NameCategory";
            nameCategoryDataGridViewTextBoxColumn.HeaderText = "Наименование";
            nameCategoryDataGridViewTextBoxColumn.Name = "nameCategoryDataGridViewTextBoxColumn";
            nameCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isIncomeDataGridViewCheckBoxColumn
            // 
            isIncomeDataGridViewCheckBoxColumn.DataPropertyName = "IsIncome";
            isIncomeDataGridViewCheckBoxColumn.HeaderText = "Явл. доходом";
            isIncomeDataGridViewCheckBoxColumn.Name = "isIncomeDataGridViewCheckBoxColumn";
            isIncomeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "Активность";
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dateInsertDataGridViewTextBoxColumn
            // 
            dateInsertDataGridViewTextBoxColumn.DataPropertyName = "DateInsert";
            dateInsertDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
            dateInsertDataGridViewTextBoxColumn.Name = "dateInsertDataGridViewTextBoxColumn";
            dateInsertDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // categoryBindingSource1
            // 
            categoryBindingSource1.DataSource = typeof(Models.Category);
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1165, 755);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategriesDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox categoryName;
        private Label label1;
        private Panel panel2;
        private Button categoryAddBtn;
        private ComboBox categoryStatus;
        private Label label3;
        private ComboBox categoryType;
        private Label label2;
        private Button categoryDeleteBtn;
        private Button categoryClearBtn;
        private Button categoryUpdateBtn;
        private DataGridView CategriesDgv;
        private Label label4;
        private BindingSource categoryBindingSource;
        private BindingSource categoryBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameCategoryDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIncomeDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dateInsertDataGridViewTextBoxColumn;
    }
}
