﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    [Table("DueBalance")]
    public class DueBalance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DueBalanceId { get; set; }
        public int? StudentId { get; set; }
        public decimal? DueBalanceAmount { get; set; }
        public DateTime? LastUpdate { get; set; } = DateTime.Now;
        public Student? Student { get; set; }
    }
}
