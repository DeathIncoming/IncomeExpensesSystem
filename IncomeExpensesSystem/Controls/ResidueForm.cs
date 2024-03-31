using IncomeExpensesSystem.Models;

namespace IncomeExpensesSystem.Controls
{
    public partial class ResidueForm : UserControl
    {
        private DateTime selectedDate;

        private readonly ContextDB context;

        public ResidueForm()
        {
            context = new ContextDB();
            InitializeComponent();
            UpdateData();
            /*ResidueAndSum();*/
        }

        private void UpdateData() // чтобы покрасивее вывод таблиц был
        {
            incomeDvg.AutoGenerateColumns = true;
            expenseDvg.AutoGenerateColumns = true;
            incomeDvg.DataSource = context.Incomes.ToList();
            expenseDvg.DataSource = context.Expenses.ToList();
            incomeDvg.Columns["Category"].Visible = false;
            expenseDvg.Columns["Category"].Visible = false;
            expenseDvg.Columns["Id"].Visible = false;
            incomeDvg.Columns["Id"].Visible = false;
            expenseDvg.Columns["CategoryId"].Visible = false;
            incomeDvg.Columns["CategoryId"].Visible = false;
            expenseDvg.RowHeadersVisible = false;
            incomeDvg.RowHeadersVisible = false;
        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            decimal incomeSum = context.Incomes.Where(i => i.TimeAdded.Date == selectedDate.Date).AsEnumerable().Sum(i => i.Summ);
            label7.Text = incomeSum.ToString();

            decimal expenseSum = -context.Expenses.Where(i => i.TimeAdded.Date == selectedDate.Date).AsEnumerable().Sum(i => i.Summ);
            label6.Text = expenseSum.ToString();

            decimal totalSum = incomeSum + expenseSum;
            label8.Text = totalSum.ToString();
        }

        private void buttonYesterday_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today.AddDays(-1);

            decimal incomeSum = context.Incomes.Where(i => i.TimeAdded.Date == selectedDate.Date).AsEnumerable().Sum(i => i.Summ);
            label7.Text = incomeSum.ToString();

            decimal expenseSum = -context.Expenses.Where(i => i.TimeAdded.Date == selectedDate.Date).AsEnumerable().Sum(i => i.Summ);
            label6.Text = expenseSum.ToString();

            decimal totalSum = incomeSum + expenseSum;
            label8.Text = totalSum.ToString();
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            decimal incomeSum = context.Incomes.Where(i => i.TimeAdded.Month == selectedDate.Month && i.TimeAdded.Year == selectedDate.Year).AsEnumerable().Sum(i => i.Summ);
            label7.Text = incomeSum.ToString();

            decimal expenseSum = -context.Expenses.Where(i => i.TimeAdded.Month == selectedDate.Month && i.TimeAdded.Year == selectedDate.Year).AsEnumerable().Sum(i => i.Summ);
            label6.Text = expenseSum.ToString();

            decimal totalSum3 = incomeSum + expenseSum;
            label8.Text = totalSum3.ToString();
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.Today;
            decimal incomeSum = context.Incomes.Where(i => i.TimeAdded.Year == selectedDate.Year).AsEnumerable().Sum(i => i.Summ);
            label7.Text = incomeSum.ToString();

            decimal expenseSum = -context.Expenses.Where(i => i.TimeAdded.Year == selectedDate.Year).AsEnumerable().Sum(i => i.Summ);
            label6.Text = expenseSum.ToString();

            decimal totalSum = incomeSum + expenseSum;
            label8.Text = totalSum.ToString();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            decimal expenseSum = -context.Expenses.AsEnumerable().Sum(i => i.Summ);
            label6.Text = expenseSum.ToString();

            decimal incomeSum = context.Incomes.AsEnumerable().Sum(i => i.Summ);
            label7.Text = incomeSum.ToString();

            decimal totalSum = incomeSum + expenseSum;
            label8.Text = totalSum.ToString();
        }
    }

}
