using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentId { get; set; }

        public string StudentName { get; set; }

        [DataType(DataType.Date)]

        public DateTime NgaySi8nh { get; set; }

        
    }
}