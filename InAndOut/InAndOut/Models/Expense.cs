﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Amount { get; set; }
    }
}