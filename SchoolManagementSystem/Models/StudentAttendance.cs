using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    //[Table("StudentAttendance")]
    public class StudentAttendance : Attendance
    {
        public int StudentId { get; set; } 
        public Student? Student { get; set; } 

    }
}
