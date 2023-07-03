using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static CarService.Common.EntityValidationConstants.EmployeeConstants;

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
        [MaxLength(EmployeeFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("Last Name")]
        [Required]
        [MaxLength(EmployeeLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Comment("Start Date")]
        [Required]
        [RegularExpression(EmployeeStartDateRegEx)]
        public DateTime StartDate { get; set; }

        [Comment("End Date")]
        [RegularExpression(EmployeeEndDateRegEx)]
        public DateTime? EndDate { get; set; }

        [Comment("Is active")]
        public bool? IsActive { get; set; }

        [Comment("Appointments")]
        public ICollection<Appointment>? Appointments { get; set; } = new List<Appointment>();
    }
}