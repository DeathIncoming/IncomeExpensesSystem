using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpensesSystem.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Summ {  get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public DateTime TimeAdded { get; set; }
    }
}
