using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseCategoryController(ApplicationDbContext db)
        {
            _db = db ??
                throw new ArgumentNullException(nameof(db));
        }

        public IActionResult Index()
        {
            IEnumerable<ExpenseCategory> objList = _db.ExpenseCategories;
            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if (obj is null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ExpenseCategories.Find(id);
            if (obj is null)
            {
                return NotFound();
            }
            _db.ExpenseCategories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpenseCategories.Find(id);
            if (obj is null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpenseCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpenseCategories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
