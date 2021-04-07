﻿using Intexium.Models;
using Intexium.Models.ProjectListViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intexium.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationDbContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext ctx )
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index(int pageNum)
        {
            return View(new ProjectListViewModel
            {
                Books = context.Books
            });
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
}
