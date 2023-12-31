﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AAAAA_FUNCIONA_MDS.Models;
using AAAAA_FUNCIONA_MDS.Controllers;
using App.Context;
using Microsoft.EntityFrameworkCore;

namespace AAAAA_FUNCIONA_MDS.Controllers;

public class HomeController : Controller
{

    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Produtos.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
