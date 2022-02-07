using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerWebApp.Models
{
    public class Expense
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,4)")]
        [Range(1, (double) decimal.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("Person")]
        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
