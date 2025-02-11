using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.ViewModels
{
    public class SaveExamScheduleVM
    {
        public string ExamScheduleName { get; set; }
        public int ExamTypeId { get; set; }
        public IEnumerable<int>? SubjectIds { get; set; }
    }
}
