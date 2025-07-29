using LedgerBook.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LedgerBook.Controllers;

public class LoginController : Controller
{

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginMain loginMain)
    {
        return View();
    }
}
