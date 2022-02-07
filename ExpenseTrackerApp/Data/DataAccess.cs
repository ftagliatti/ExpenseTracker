using ExpenseTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Data
{
    public class DataAccess
    {
        private readonly ApplicationDBContext _db;
        public DataAccess(ApplicationDBContext db)
        {
            _db = db;
        }
        public List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();

            foreach(var expense in _db.Expenses)
            {
                expenses.Add(expense);
            }

            return expenses;
        }
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            foreach (var person in _db.People)
            {
                people.Add(person);
            }

            return people;
        }
    }
}
