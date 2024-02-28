namespace IncomeExpensesSystem.Controls
{
    partial class ResidueForm
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
            panel2 = new Panel();
            expenseDvg = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            incomeDvg = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            buttonAll = new Button();
            buttonYear = new Button();
            buttonMonth = new Button();
            buttonYesterday = new Button();
            buttonNow = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseDvg).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)incomeDvg).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(expenseDvg);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(680, 377);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 364);
            panel2.TabIndex = 1;
            // 
            // expenseDvg
            // 
            expenseDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expenseDvg.Location = new Point(3, 29);
            expenseDvg.Name = "expenseDvg";
            expenseDvg.Size = new Size(459, 331);
            expenseDvg.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 0;
            label1.Text = "Расходы:";
            // 
            // panel1
            // 
            panel1.Controls.Add(incomeDvg);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(680, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 360);
            panel1.TabIndex = 2;
            // 
            // incomeDvg
            // 
            incomeDvg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incomeDvg.Location = new Point(3, 26);
            incomeDvg.Name = "incomeDvg";
            incomeDvg.Size = new Size(459, 331);
            incomeDvg.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 1;
            label2.Text = "Доходы:";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(14, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 224);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 0);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(13, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 74);
            panel5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 20F);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(16, 35);
            label6.Name = "label6";
            label6.Size = new Size(30, 33);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 3);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 2;
            label5.Text = "Общий расход:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 128, 0);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(13, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 74);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 5);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 1;
            label4.Text = "Общий доход:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 20F);
            label7.ForeColor = Color.YellowGreen;
            label7.Location = new Point(16, 28);
            label7.Name = "label7";
            label7.Size = new Size(30, 33);
            label7.TabIndex = 4;
            label7.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 0);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label8);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(13, 170);
            panel6.Name = "panel6";
            panel6.Size = new Size(402, 49);
            panel6.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Coral;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(2, 10);
            label3.Name = "label3";
            label3.Size = new Size(179, 33);
            label3.TabIndex = 0;
            label3.Text = "Ваш остаток:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 128, 0);
            label8.Font = new Font("Tahoma", 20F);
            label8.Location = new Point(187, 10);
            label8.Name = "label8";
            label8.Size = new Size(30, 33);
            label8.TabIndex = 5;
            label8.Text = "0";
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonAll);
            panel7.Controls.Add(buttonYear);
            panel7.Controls.Add(buttonMonth);
            panel7.Controls.Add(buttonYesterday);
            panel7.Controls.Add(buttonNow);
            panel7.Location = new Point(119, 260);
            panel7.Name = "panel7";
            panel7.Size = new Size(555, 64);
            panel7.TabIndex = 9;
            // 
            // buttonAll
            // 
            buttonAll.BackColor = Color.FromArgb(255, 128, 0);
            buttonAll.Font = new Font("Microsoft Sans Serif", 12F);
            buttonAll.ForeColor = Color.White;
            buttonAll.Location = new Point(447, 3);
            buttonAll.Name = "buttonAll";
            buttonAll.Size = new Size(105, 58);
            buttonAll.TabIndex = 4;
            buttonAll.Text = "Всего";
            buttonAll.UseVisualStyleBackColor = false;
            buttonAll.Click += buttonAll_Click;
            // 
            // buttonYear
            // 
            buttonYear.BackColor = Color.FromArgb(255, 128, 0);
            buttonYear.Font = new Font("Microsoft Sans Serif", 12F);
            buttonYear.ForeColor = Color.White;
            buttonYear.Location = new Point(336, 3);
            buttonYear.Name = "buttonYear";
            buttonYear.Size = new Size(105, 58);
            buttonYear.TabIndex = 3;
            buttonYear.Text = "За год";
            buttonYear.UseVisualStyleBackColor = false;
            buttonYear.Click += buttonYear_Click;
            // 
            // buttonMonth
            // 
            buttonMonth.BackColor = Color.FromArgb(255, 128, 0);
            buttonMonth.Font = new Font("Microsoft Sans Serif", 12F);
            buttonMonth.ForeColor = Color.White;
            buttonMonth.Location = new Point(225, 3);
            buttonMonth.Name = "buttonMonth";
            buttonMonth.Size = new Size(105, 58);
            buttonMonth.TabIndex = 2;
            buttonMonth.Text = "За месяц";
            buttonMonth.UseVisualStyleBackColor = false;
            buttonMonth.Click += buttonMonth_Click;
            // 
            // buttonYesterday
            // 
            buttonYesterday.BackColor = Color.FromArgb(255, 128, 0);
            buttonYesterday.Font = new Font("Microsoft Sans Serif", 12F);
            buttonYesterday.ForeColor = Color.White;
            buttonYesterday.Location = new Point(114, 3);
            buttonYesterday.Name = "buttonYesterday";
            buttonYesterday.Size = new Size(105, 58);
            buttonYesterday.TabIndex = 1;
            buttonYesterday.Text = "За вчера";
            buttonYesterday.UseVisualStyleBackColor = false;
            buttonYesterday.Click += buttonYesterday_Click;
            // 
            // buttonNow
            // 
            buttonNow.BackColor = Color.FromArgb(255, 128, 0);
            buttonNow.Font = new Font("Microsoft Sans Serif", 12F);
            buttonNow.ForeColor = Color.White;
            buttonNow.Location = new Point(3, 3);
            buttonNow.Name = "buttonNow";
            buttonNow.Size = new Size(105, 58);
            buttonNow.TabIndex = 0;
            buttonNow.Text = "За сегодня";
            buttonNow.UseVisualStyleBackColor = false;
            buttonNow.Click += buttonNow_Click;
            // 
            // ResidueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ResidueForm";
            Size = new Size(1165, 755);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expenseDvg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)incomeDvg).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private DataGridView expenseDvg;
        private DataGridView incomeDvg;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Button buttonAll;
        private Button buttonYear;
        private Button buttonMonth;
        private Button buttonYesterday;
        private Button buttonNow;
    }
}
