namespace IncomeExpensesSystem.Controls
{
    partial class IncomeForm
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
            panel1 = new Panel();
            label1 = new Label();
            incomesDgv = new DataGridView();
            panel2 = new Panel();
            incomeClearBtn = new Button();
            incomeDeleteBtn = new Button();
            incomeUpdateBtn = new Button();
            incomeAddBtn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            incomeDescriptionTb = new TextBox();
            label5 = new Label();
            incomeSumTb = new TextBox();
            label4 = new Label();
            incomeNameTb = new TextBox();
            label3 = new Label();
            incomeCategoriesCmb = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)incomesDgv).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(incomesDgv);
            panel1.Location = new Point(15, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 333);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 1;
            label1.Text = "Список доходов";
            // 
            // incomesDgv
            // 
            incomesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incomesDgv.Location = new Point(19, 57);
            incomesDgv.Name = "incomesDgv";
            incomesDgv.Size = new Size(1100, 258);
            incomesDgv.TabIndex = 0;
            incomesDgv.SelectionChanged += expensesDgv_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(incomeClearBtn);
            panel2.Controls.Add(incomeDeleteBtn);
            panel2.Controls.Add(incomeUpdateBtn);
            panel2.Controls.Add(incomeAddBtn);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(incomeDescriptionTb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(incomeSumTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(incomeNameTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(incomeCategoriesCmb);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(15, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(1135, 244);
            panel2.TabIndex = 1;
            // 
            // incomeClearBtn
            // 
            incomeClearBtn.BackColor = Color.FromArgb(255, 128, 0);
            incomeClearBtn.FlatAppearance.BorderSize = 0;
            incomeClearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            incomeClearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            incomeClearBtn.FlatStyle = FlatStyle.Flat;
            incomeClearBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeClearBtn.Location = new Point(772, 176);
            incomeClearBtn.Name = "incomeClearBtn";
            incomeClearBtn.Size = new Size(125, 44);
            incomeClearBtn.TabIndex = 14;
            incomeClearBtn.Text = "Очистить";
            incomeClearBtn.UseVisualStyleBackColor = false;
            // 
            // incomeDeleteBtn
            // 
            incomeDeleteBtn.BackColor = Color.FromArgb(255, 128, 0);
            incomeDeleteBtn.FlatAppearance.BorderSize = 0;
            incomeDeleteBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            incomeDeleteBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            incomeDeleteBtn.FlatStyle = FlatStyle.Flat;
            incomeDeleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeDeleteBtn.Location = new Point(619, 176);
            incomeDeleteBtn.Name = "incomeDeleteBtn";
            incomeDeleteBtn.Size = new Size(125, 44);
            incomeDeleteBtn.TabIndex = 13;
            incomeDeleteBtn.Text = "Удалить";
            incomeDeleteBtn.UseVisualStyleBackColor = false;
            incomeDeleteBtn.Click += incomeDeleteBtn_Click;
            // 
            // incomeUpdateBtn
            // 
            incomeUpdateBtn.BackColor = Color.FromArgb(255, 128, 0);
            incomeUpdateBtn.FlatAppearance.BorderSize = 0;
            incomeUpdateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            incomeUpdateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            incomeUpdateBtn.FlatStyle = FlatStyle.Flat;
            incomeUpdateBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeUpdateBtn.Location = new Point(384, 176);
            incomeUpdateBtn.Name = "incomeUpdateBtn";
            incomeUpdateBtn.Size = new Size(125, 44);
            incomeUpdateBtn.TabIndex = 12;
            incomeUpdateBtn.Text = "Обновить";
            incomeUpdateBtn.UseVisualStyleBackColor = false;
            incomeUpdateBtn.Click += incomeUpdateBtn_Click_1;
            // 
            // incomeAddBtn
            // 
            incomeAddBtn.BackColor = Color.FromArgb(255, 128, 0);
            incomeAddBtn.FlatAppearance.BorderSize = 0;
            incomeAddBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            incomeAddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            incomeAddBtn.FlatStyle = FlatStyle.Flat;
            incomeAddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeAddBtn.Location = new Point(231, 176);
            incomeAddBtn.Name = "incomeAddBtn";
            incomeAddBtn.Size = new Size(125, 44);
            incomeAddBtn.TabIndex = 11;
            incomeAddBtn.Text = "Добавить";
            incomeAddBtn.UseVisualStyleBackColor = false;
            incomeAddBtn.Click += incomeAddBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(653, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(599, 123);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 9;
            label6.Text = "Item:";
            // 
            // incomeDescriptionTb
            // 
            incomeDescriptionTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeDescriptionTb.Location = new Point(653, 21);
            incomeDescriptionTb.Multiline = true;
            incomeDescriptionTb.Name = "incomeDescriptionTb";
            incomeDescriptionTb.Size = new Size(415, 76);
            incomeDescriptionTb.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(561, 24);
            label5.Name = "label5";
            label5.Size = new Size(86, 19);
            label5.TabIndex = 7;
            label5.Text = "Описание:";
            // 
            // incomeSumTb
            // 
            incomeSumTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeSumTb.Location = new Point(200, 120);
            incomeSumTb.Name = "incomeSumTb";
            incomeSumTb.Size = new Size(254, 26);
            incomeSumTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(133, 125);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 5;
            label4.Text = "Сумма:";
            // 
            // incomeNameTb
            // 
            incomeNameTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeNameTb.Location = new Point(200, 71);
            incomeNameTb.Name = "incomeNameTb";
            incomeNameTb.Size = new Size(254, 26);
            incomeNameTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 74);
            label3.Name = "label3";
            label3.Size = new Size(178, 19);
            label3.TabIndex = 3;
            label3.Text = "Наименование дохода:";
            // 
            // incomeCategoriesCmb
            // 
            incomeCategoriesCmb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            incomeCategoriesCmb.FormattingEnabled = true;
            incomeCategoriesCmb.Location = new Point(200, 21);
            incomeCategoriesCmb.Name = "incomeCategoriesCmb";
            incomeCategoriesCmb.Size = new Size(254, 28);
            incomeCategoriesCmb.TabIndex = 2;
            incomeCategoriesCmb.VisibleChanged += incomeCategoriesCmb_VisibleChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(103, 24);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 1;
            label2.Text = "Категория:";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeForm";
            Size = new Size(1165, 755);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)incomesDgv).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView incomesDgv;
        private Label label1;
        private Panel panel2;
        private ComboBox incomeCategoriesCmb;
        private Label label2;
        private TextBox incomeDescriptionTb;
        private Label label5;
        private TextBox incomeSumTb;
        private Label label4;
        private TextBox incomeNameTb;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button incomeClearBtn;
        private Button incomeDeleteBtn;
        private Button incomeUpdateBtn;
        private Button incomeAddBtn;
    }
}
