using IncomeExpensesSystem.Models;
using System.ComponentModel;

namespace IncomeExpensesSystem.Controls
{
    public partial class CategoryForm : UserControl
    {
        private BindingList<Category> categoriesBindingList;
        private Category? selectedCategory;
        public CategoryForm()
        {
            InitializeComponent();
            categoryStatus.SelectedIndex = 0;
            categoryType.SelectedIndex = 0;
            using var context = new ContextDB();
            categoriesBindingList = new BindingList<Category>(context.Categories.ToList<Category>());
            CategriesDgv.DataSource = categoriesBindingList;
        }

        private void categoryAddBtn_Click(object sender, EventArgs e)
        {
            var category = new Category() { NameCategory = categoryName.Text, IsIncome = categoryType.Text == "Доходы", Status = categoryStatus.Text == "Активн", DateInsert = DateTime.Now.Date };
            using var context = new ContextDB();
            context.Categories.Add(category);
            context.SaveChanges();
            categoriesBindingList.Add(category);
        }

        private void categoryDeleteBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (selectedCategory != null)
            {
                context.Categories.Remove(selectedCategory);
                context.SaveChanges();
                categoriesBindingList.Remove(categoriesBindingList.First(x => x.Id == selectedCategory.Id));
                CategriesDgv.Update();
            }
        }

        private void categoryUpdateBtn_Click(object sender, EventArgs e)
        {
            using var context = new ContextDB();
            if (selectedCategory != null)
            {
                selectedCategory.NameCategory = categoryName.Text;
                selectedCategory.Status = Convert.ToBoolean(categoryStatus.SelectedIndex);
                selectedCategory.IsIncome = Convert.ToBoolean(categoryType.SelectedIndex);
                context.Categories.Update(selectedCategory);
                context.SaveChanges();
                categoriesBindingList = new BindingList<Category>(context.Categories.ToList<Category>());
                CategriesDgv.Refresh();
            }
        }

        private void CategriesDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).GetType().GetProperty("CurrentRow") != null && ((DataGridView)sender).CurrentRow.Index >= 0)
            {
                selectedCategory = categoriesBindingList.ElementAt(((DataGridView)sender).CurrentRow.Index);
                categoryName.Text = selectedCategory.NameCategory;
                categoryType.SelectedIndex = Convert.ToInt32(selectedCategory.IsIncome);
                categoryStatus.SelectedIndex = Convert.ToInt32(selectedCategory.Status);
            }

        }
    }
}