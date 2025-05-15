using EmployeesApp.Web;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;

namespace EmployeesApp;

public class EmployeesController : Controller
{
    static EmployeeService service = new();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = service.GetAll();
        return View(model);
    }

    [HttpGet("Create")]
    public IActionResult Create()
    {
        return View("Index");
    }

    [HttpPost("Create")]
    public IActionResult Create(Employee employee)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        service.Add(employee);
        return RedirectToAction(nameof(Index));
    }
}
