﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }

    }
}
