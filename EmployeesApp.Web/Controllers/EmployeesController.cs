﻿using EmployeesApp.Web;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Models;

namespace EmployeesApp;

public class EmployeesController : Controller
{
    private readonly static EmployeeService service = new();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = service.GetAll();
        return View(model);
    }

    [HttpGet("Create")]
    public IActionResult Create()
    {
        return View();
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

    [HttpGet("Details/{id}")]
    public IActionResult Details(int id)
    {
        var model = service.GetById(id);
        return View(model);
    }
}
