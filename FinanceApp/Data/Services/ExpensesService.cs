using FinanceApp.Models;

namespace FinanceApp.Data.Services {
  public class ExpensesService : IExpensesService {
    private readonly FinanceAppContext _context;
    public ExpensesService(FinanceAppContext context) {
      _context = context;
    }

    public Task Add(Expense expense) {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Expense>> GetAll() {
      throw new NotImplementedException();
    }
  }
}
