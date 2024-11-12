using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfwithDTO.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }    
    }
}