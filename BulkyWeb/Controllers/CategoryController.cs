﻿using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext Db) 
        {
            _db = Db;
        }
        public IActionResult Index()
        {
            List<Category>objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
