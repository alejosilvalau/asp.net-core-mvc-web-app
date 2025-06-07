using FinanceApp.Data.Services;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers {
  public class ExpensesController : Controller {
    private readonly IExpensesService _expensesService;

    public ExpensesController(IExpensesService expensesService) {
      _expensesService = expensesService;
    }

    public async Task<IActionResult> Index() {
      var expenses = await _expensesService.GetAll();
      return View(expenses);
    }
    public IActionResult Create() {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Expense expense) {
      if (ModelState.IsValid) {
        await _expensesService.Add(expense);
        return RedirectToAction(nameof(Index));
      }

      return View(expense);
    }
  }
}
