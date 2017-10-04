using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _14DTHC34Web.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }

        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

        public string Place { get; set; }

        public DateTime DateTime { get; set; }

    }
}