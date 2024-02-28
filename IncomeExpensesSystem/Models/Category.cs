using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesSystem.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string NameCategory { get; set; }
        public bool IsIncome { get; set; }
        public bool Status {  get; set; }
        public DateTime DateInsert { get; set; }
        public List<Income> Incomes { get; set; } = [];
        public List<Expense> Expenses { get; set; } = [];
    }
}
