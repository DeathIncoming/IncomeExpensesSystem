using IncomeExpensesSystem.Models;
using System.ComponentModel;
using System.Data;

namespace IncomeExpensesSystem.Controls
{
    public partial class ExpensesForm : UserControl
    {
        private BindingList<Category> categories;
        private BindingList<Expense> expenses;
        private Expense selectedExpense;
        public ExpensesForm()
        {
            InitializeComponent();
            expensesDgv.CellDoubleClick += expensesDgv_CellDoubleClick; // Для выбора существуещей строки в бд и занесения данных в textBoxы
        }

        private void incomeAddBtn_Click(object sender, EventArgs e) // Добавляем в бд значения
        {
            using var context = new ContextDB();
            if (expenseCategoriesCmb.SelectedItem != null)
            {
                var expense = new Expense()
                {
                    Name = expenseNameTb.Text,
                    Summ = Decimal.Parse(expenseSumTb.Text),
                    Description = expenseDescriptionTb.Text,
                    CategoryId = ((Category)expenseCategoriesCmb.SelectedItem).Id,
                    TimeAdded = dateTimePicker1.Value
                };
                if (context.Expenses.FirstOrDefault(x => x.Name == expense.Name) == null)
                {
                    expenses.Add(expense);
                    context.Expenses.Add(expense);
                    context.SaveChanges();
                    expensesDgv.Refresh();
                }
                else MessageBox.Show("Расход с таким именем уже существует.");
            }
            else MessageBox.Show("Выберите категорию");
        }

        private void expenseCategoriesCmb_VisibleChanged(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            categories = new BindingList<Category>(context.Categories.Where(c => c.IsIncome == false).ToList());
            expenseCategoriesCmb.DataSource = categories;
            expenseCategoriesCmb.DisplayMember = "NameCategory";
            expenses = new BindingList<Expense>(context.Expenses.ToList());
            expensesDgv.DataSource = expenses;
            // Далее скрытие колонок из expensesDgv, т.к. это нужно прописывать после строчки сверху (это выдает в ошибке)
            expensesDgv.Columns["Category"].Visible = false; // Скрывает столбец "Category" в конце
            expensesDgv.Columns["Id"].Visible = false; // Скрывает столбец "Id" в начале 
            expensesDgv.RowHeadersVisible = false; // Скрывает "Нулевой" столбец в самом начале
        }

        private void incomeDeleteBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (expensesDgv.CurrentRow != null)
            {
                selectedExpense = expenses.ElementAt(expensesDgv.CurrentRow.Index);
                expenseNameTb.Text = selectedExpense.Name;
                expenseSumTb.Text = selectedExpense.Summ.ToString();
                expenseCategoriesCmb.SelectedItem = selectedExpense.Category;
                expenseDescriptionTb.Text = selectedExpense.Description;
                context.Expenses.Remove(selectedExpense);
                context.SaveChanges();
                expenses.Remove(expenses.First(x => x.Id == selectedExpense.Id));
                expensesDgv.Update();
            }
        }

        private void incomeUpdateBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (expensesDgv.CurrentRow != null)
            {
                selectedExpense = expenses.ElementAt(expensesDgv.CurrentRow.Index);
                selectedExpense.Name = expenseNameTb.Text;
                selectedExpense.Summ = Decimal.Parse(expenseSumTb.Text);
                selectedExpense.Category = (Category)expenseCategoriesCmb.SelectedItem;
                selectedExpense.Description = expenseDescriptionTb.Text;
                selectedExpense.TimeAdded = dateTimePicker1.Value;
                context.Expenses.Update(selectedExpense);
                context.SaveChanges();
                expenses = new BindingList<Expense>(context.Expenses.ToList());
                expensesDgv.Refresh();
            }
        }

        private void expensesDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).GetType().GetProperty("CurrentRow") != null && ((DataGridView)sender).CurrentRow.Index >= 0)
            {
                selectedExpense = expenses.ElementAt(((DataGridView)sender).CurrentRow.Index);
                expenseNameTb.Text = selectedExpense.Name;
                expenseSumTb.Text = selectedExpense.Summ.ToString();
                expenseCategoriesCmb.SelectedItem = (Category)selectedExpense.Category;
                expenseDescriptionTb.Text = selectedExpense.Description;
            }

        }

        private void expensesDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < expenses.Count) // Проверяем, что индекс строки корректный
            {
                selectedExpense = expenses[e.RowIndex];
                expenseNameTb.Text = selectedExpense.Name;
                expenseSumTb.Text = selectedExpense.Summ.ToString();
                expenseCategoriesCmb.SelectedItem = selectedExpense.Category;
                expenseDescriptionTb.Text = selectedExpense.Description;
            }
        }

        private void expenseSumTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
