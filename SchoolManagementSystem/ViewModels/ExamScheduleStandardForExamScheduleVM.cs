using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.ViewModels
{
    public class ExamScheduleStandardForExamScheduleVM
    {
        public string? StandardName { get; set; }

        public IEnumerable<ExamSubjectVM>? ExamSubjects { get; set; } = [];
    }
}
