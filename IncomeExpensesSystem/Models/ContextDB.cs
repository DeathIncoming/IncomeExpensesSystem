using Microsoft.EntityFrameworkCore;

namespace IncomeExpensesSystem.Models
{
    public class ContextDB : DbContext
    {
        public ContextDB() 
        {
            // Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = IncomeExpenses.db");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
