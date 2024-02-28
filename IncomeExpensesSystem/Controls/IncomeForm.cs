using IncomeExpensesSystem.Models;
using System.ComponentModel;
using System.Data;

namespace IncomeExpensesSystem.Controls
{
    public partial class IncomeForm : UserControl
    {
        private BindingList<Category> categories;
        private BindingList<Income> incomes;
        private Income? selectedIncome;
        public IncomeForm()
        {
            InitializeComponent();
            using var context = new ContextDB();
            incomes = new BindingList<Income>(context.Incomes.ToList<Income>());
            incomesDgv.DataSource = incomes;
            incomesDgv.Columns["Category"].Visible = false; // Скрывает столбец "Category" в конце
            incomesDgv.Columns["Id"].Visible = false; // Скрывает столбец "Id" в начале 
            incomesDgv.RowHeadersVisible = false; // Скрывает "Нулевей столбец" в самом начале
            incomesDgv.CellDoubleClick += incomesDgv_CellDoubleClick;
        }


        private void incomeAddBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();

            if (incomeCategoriesCmb.SelectedItem != null)
            {
                Category selectedCategory = (Category)incomeCategoriesCmb.SelectedItem;

                var newIncome = new Income
                {
                    Name = incomeNameTb.Text,
                    Summ = Convert.ToDecimal(incomeSumTb.Text),
                    Description = incomeDescriptionTb.Text,
                    CategoryId = selectedCategory.Id,
                    TimeAdded = dateTimePicker1.Value
                };


                if (context.Incomes.Any(x => x.Name == newIncome.Name))
                {
                    MessageBox.Show("Доход с таким именем уже существует.");
                }
                else
                {
                    incomes.Add(newIncome);
                    context.Incomes.Add(newIncome);
                    context.SaveChanges();
                    incomesDgv.Refresh();
                }
            }
            else MessageBox.Show("Выберите категорию");
        }

        private void incomeDeleteBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (incomesDgv.CurrentRow != null)
            {
                selectedIncome = incomes.ElementAt(incomesDgv.CurrentRow.Index);
                incomeNameTb.Text = selectedIncome.Name;
                incomeSumTb.Text = selectedIncome.Summ.ToString();
                incomeCategoriesCmb.SelectedItem = selectedIncome.Category;
                incomeDescriptionTb.Text = selectedIncome.Description;
                context.Incomes.Remove(selectedIncome);
                context.SaveChanges();
                incomes.Remove(incomes.First(x => x.Id == selectedIncome.Id));
                incomesDgv.Update();
            }
        }

        private void expensesDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).GetType().GetProperty("CurrentRow") != null && ((DataGridView)sender).CurrentRow.Index >= 0)
            {
                selectedIncome = incomes.ElementAt(((DataGridView)sender).CurrentRow.Index);
                incomeNameTb.Text = selectedIncome.Name;
                incomeSumTb.Text = selectedIncome.Summ.ToString();
                incomeCategoriesCmb.SelectedItem = (Category)selectedIncome.Category;
                incomeDescriptionTb.Text = selectedIncome.Description;
                dateTimePicker1.Value = selectedIncome.TimeAdded;
            }

        }


        private void incomeCategoriesCmb_VisibleChanged(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            categories = new BindingList<Category>(context.Categories.Where(c => c.IsIncome == true).ToList());
            incomes = new BindingList<Income>(context.Incomes.ToList());
            incomesDgv.DataSource = incomes;
            incomeCategoriesCmb.DataSource = categories;
            incomeCategoriesCmb.DisplayMember = "NameCategory";
        }

        private void incomeUpdateBtn_Click_1(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (incomesDgv.CurrentRow != null && incomesDgv.CurrentRow.Index < incomes.Count)
            {
                selectedIncome = incomes.ElementAt(incomesDgv.CurrentRow.Index);
                selectedIncome.Name = incomeNameTb.Text;
                selectedIncome.Summ = Decimal.Parse(incomeSumTb.Text);
                selectedIncome.Category = (Category)incomeCategoriesCmb.SelectedItem;
                selectedIncome.Description = incomeDescriptionTb.Text;
                context.Incomes.Update(selectedIncome);
                context.SaveChanges();
                incomes = new BindingList<Income>(context.Incomes.ToList());
                incomesDgv.DataSource = incomes;
            }
        }

        private void incomesDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < incomes.Count) // Проверяем, что индекс строки корректный
            {
                selectedIncome = incomes[e.RowIndex];
                incomeNameTb.Text = selectedIncome.Name;
                incomeSumTb.Text = selectedIncome.Summ.ToString();
                incomeCategoriesCmb.SelectedItem = selectedIncome.Category;
                incomeDescriptionTb.Text = selectedIncome.Description;
            }
        }
    }
}



