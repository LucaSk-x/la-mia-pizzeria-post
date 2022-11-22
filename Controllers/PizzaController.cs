﻿using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        PizzeriaDbContext db;

        public PizzaController() : base()
        {
            db = new PizzeriaDbContext();
        }
        public IActionResult Index()
        {
            //PizzeriaDbContext db = new PizzeriaDbContext();
            List<Pizza> listaPizza = db.Pizze.ToList();
            return View(listaPizza);
        }

        public IActionResult Detail(int id)
        {
            //PizzeriaDbContext db = new PizzeriaDbContext();
            Pizza pizza = db.Pizze.Where(p => p.Id == id).FirstOrDefault();
            return View(pizza);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza pizza)
        {
            return RedirectToAction("Index");
        }
    }
}
