﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    [Table("ExamScheduleStandard")]
    public class ExamScheduleStandard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamScheduleStandardId { get; set; }

        public int? ExamScheduleId { get; set; }
        public int StandardId { get; set; }
        public virtual Standard? Standard { get; set; }
        public virtual ExamSchedule? ExamSchedule { get; set; }
        public virtual ICollection<ExamSubject>? ExamSubjects { get; set; } = [];
    }
}
