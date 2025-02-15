﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    // Class table, renamed for avoiding built-in keyword clash

    [Table("Standard")]
    public class Standard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StandardId { get; set; }
        [Required]
        public string? StandardName { get; set; }
        public string? StandardCapacity { get; set; }
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<ExamScheduleStandard>? ExamScheduleStandards { get; set; }
        public virtual ICollection<Student>? Students { get; set; } = [];

        //[NotMapped]
        //public int? StudentCount { get; set; } //=> this.Students?.Count;
        //[NotMapped]
        //public int? SubjectCount { get; set; }

    }
}
