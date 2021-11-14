using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]{3,20}$")]
        public string ExpenseName { get; set; }
        [Required]
        [DisplayName("Amount")]
        [Range(1,int.MaxValue,ErrorMessage ="Amount must be Greater then 0!")]
        public int Amount { get; set; }

        [DisplayName("Expense Type")]
        public int ExpenseTypeId { set; get; }
        [ForeignKey("ExpenseTypeId")]

        public virtual ExpenseType ExpenseType {get;set;}
    }
}
