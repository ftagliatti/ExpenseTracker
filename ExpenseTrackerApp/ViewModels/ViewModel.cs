using ExpenseTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.ViewModels
{
    public class ViewModel
    {
        public List<Expense> Expenses { get; set; }
        public List<Person> People { get; set; }
    }
}
