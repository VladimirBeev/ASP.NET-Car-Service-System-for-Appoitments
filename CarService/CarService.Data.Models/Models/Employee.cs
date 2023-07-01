using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace CarService.Data.Models.Models
{
    [Comment("Employee Table")]
    public class Employee
    {
        [Comment("Primary Key")]
        [Key]
        public int Id { get; set; }

        [Comment("First Name")]
        [Required]
        [MaxLength(130)]
        public string FirstName { get; set; } = null!;

        [Comment("Last Name")]
        [Required]
        [MaxLength(130)]
        public string LastName { get; set; } = null!;

        [Comment("Start Date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Comment("End Date")]
        public DateTime? EndDate { get; set; }

        [Comment("Is active")]
        public bool? IsActive { get; set; }
    }
}