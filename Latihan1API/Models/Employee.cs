using System;
using System.ComponentModel.DataAnnotations;

namespace Latihan1API.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name column just 50 character")]
        public string Name { get; set; }
    }
}
