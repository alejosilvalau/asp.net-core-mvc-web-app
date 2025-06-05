using asp.net_core_mvc_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_mvc_web_app.Data
{
  public class FinanceAppContext : DbContext
  {
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options) : base(options) { }

    DbSet<Expense> Expenses { get; set; }
  }
}
