using ExpenseTrackerWebApp.Data;
using ExpenseTrackerWebApp.Models;
using ExpenseTrackerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDBContext _db;

        public ExpenseController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //IEnumerable<Expense> objList = _db.Expenses;
            //return View(objList);
            DataAccess data = new DataAccess(_db);
            ViewModel vm = new ViewModel();
            vm.Expenses = data.GetExpenses();
            vm.People = data.GetPeople();
            return View(vm);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET-Delete
        public IActionResult Delete(int? itemId)
        {
            if (itemId == null || itemId == 0)
            {
                return NotFound();
            }

            var obj = _db.Expenses.Find(itemId);
            
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? itemId)
        {
            var obj = _db.Expenses.Find(itemId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-Update
        public IActionResult Update(int? itemId)
        {
            if (itemId == null || itemId == 0)
            {
                return NotFound();
            }

            var obj = _db.Expenses.Find(itemId);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Update
        public IActionResult UpdatePost(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
