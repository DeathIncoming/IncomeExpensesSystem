using IncomeExpensesSystem.Models;


namespace IncomeExpensesSystem.Controls
{
    public partial class DashboardForm : UserControl
    {

        public DashboardForm()
        {
            InitializeComponent();
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            using var context = new ContextDB();
            DateTime today = DateTime.Today;
            label22.Text = context.Incomes.AsEnumerable().Sum(i => i.Summ).ToString();
            label24.Text = context.Expenses.AsEnumerable().Sum(i => i.Summ).ToString();
            UpdateLabelIncome(label5, context.Incomes.AsEnumerable().Where(i => i.TimeAdded.Date == today));
            UpdateLabelExpense(label9, context.Expenses.AsEnumerable().Where(i => i.TimeAdded.Date == today));
            UpdateLabelIncome(label6, context.Incomes.AsEnumerable().Where(i => i.TimeAdded.Date == today.AddDays(-1)));
            UpdateLabelExpense(label10, context.Expenses.AsEnumerable().Where(i => i.TimeAdded.Date == today.AddDays(-1)));
            UpdateLabelIncome(label7, context.Incomes.AsEnumerable().Where(i => i.TimeAdded.Date >= new DateTime(today.Year, today.Month, 1) && i.TimeAdded.Date <= new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))));
            UpdateLabelExpense(label11, context.Expenses.AsEnumerable().Where(i => i.TimeAdded.Date >= new DateTime(today.Year, today.Month, 1) && i.TimeAdded.Date <= new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month))));
            UpdateLabelIncome(label8, context.Incomes.AsEnumerable().Where(i => i.TimeAdded.Date >= new DateTime(today.Year, 1, 1) && i.TimeAdded.Date <= new DateTime(today.Year, 12, 31)));
            UpdateLabelExpense(label12, context.Expenses.AsEnumerable().Where(i => i.TimeAdded.Date >= new DateTime(today.Year, 1, 1) && i.TimeAdded.Date <= new DateTime(today.Year, 12, 31)));
        }

        private void UpdateLabelIncome(Label label, IEnumerable<Income> data)
        {
            var sum = data.Sum(i => i.Summ);
            label.Text = sum.ToString();
        }

        private void UpdateLabelExpense(Label label, IEnumerable<Expense> data)
        {
            var sum = data.Sum(i => i.Summ);
            label.Text = sum.ToString();
        }

        private void DashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}