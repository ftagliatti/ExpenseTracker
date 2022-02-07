using ExpenseTrackerWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Configuration
{
    public class ExpenseConfiguration: IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasOne(e => e.Person)
                .WithMany(p => p.Expenses)
                .HasForeignKey(e => e.PersonId);
            builder.HasData(
                new Expense { ItemId = 1, ItemName = "Car", Amount = 10000, Date = DateTime.Now, PersonId = 1 },
                new Expense { ItemId = 2, ItemName = "Watch", Amount = 250, Date = DateTime.Now, PersonId = 1 },
                new Expense { ItemId = 3, ItemName = "Shoes", Amount = 40, Date = DateTime.Now, PersonId = 1 },
                new Expense { ItemId = 4, ItemName = "Umbrella", Amount = 20, Date = DateTime.Now, PersonId = 2 },
                new Expense { ItemId = 5, ItemName = "Book", Amount = 10, Date = DateTime.Now, PersonId = 2 },
                new Expense { ItemId = 6, ItemName = "Computer", Amount = 1000, Date = DateTime.Now, PersonId = 3 },
                new Expense { ItemId = 7, ItemName = "Hat", Amount = 10, Date = DateTime.Now, PersonId = 3 }
            );
        }
    }
}
