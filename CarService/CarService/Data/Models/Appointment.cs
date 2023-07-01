using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService.Data.Models
{
    [Comment("Appointment Table")]
	public class Appointment
	{
        [Comment("Primary Key")]
        [Key]
		public int Id { get; set; }

        [Comment("Appointment Date and Time")]
        [Required]
        public DateTime AppointmentDateTime { get; set; }

        [Comment("Status")]
        public bool? Status { get; set; }

        [Comment("EmployeeId")]
        public int EmployeeId { get; set; }
        [Comment("Employee")]
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }

        [Comment("Car Id")]
        public int CarId { get; set; }
        [Comment("Car")]
        [ForeignKey(nameof(CarId))]
        [Required]
        public Car Car { get; set; } = null!;

        [Comment("Service Id")]
        public int CarServiceId { get; set; }
        [Comment("Service")]
        [ForeignKey(nameof(CarServiceId))]
        public CarsService? CarService { get; set; }

    }
}
