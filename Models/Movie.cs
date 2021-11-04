using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
// đổi namepsace giống tên project
namespace MvcMovie.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}