using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
  public class ExpensesController : Controller
  {
    private readonly FinanceAppContext _context;

    public ExpensesController(FinanceAppContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      return View();
    }
  }
}
