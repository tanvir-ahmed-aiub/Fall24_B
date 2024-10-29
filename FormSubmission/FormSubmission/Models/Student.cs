using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please provide Id")]
        [Range(1,40,ErrorMessage ="Id must be 1<=id<=40")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(11)]
        public string Phone { get; set; }
    }
}