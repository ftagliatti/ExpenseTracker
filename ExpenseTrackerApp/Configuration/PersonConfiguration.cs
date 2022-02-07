using ExpenseTrackerWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Configuration
{
    public class PersonConfiguration: IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasMany(p => p.Expenses)
                .WithOne(e => e.Person);
            builder.HasData(
               new Person { PersonId = 1, FirstName = "Francesco", LastName = "Tagliatti" },
               new Person { PersonId = 2, FirstName = "Rachael", LastName = "Kapple" },
               new Person { PersonId = 3, FirstName = "Mark", LastName = "Flynn" }
            );
        }
    }
}
