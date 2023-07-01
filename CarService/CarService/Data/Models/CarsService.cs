using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace CarService.Data.Models
{
	[Comment("Car Service Table")]
	public class CarsService
	{
		[Comment("Primary Key")]
		[Key]
		public int Id { get; set; }

		[Comment("Service Name")]
		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;

		[Comment("Service Type")]
		[Required]
		[MaxLength(40)]
		public string ServiceType { get; set; } = null!;

		[Comment("Price of the Service")]
		[Precision(6, 2)]
		public decimal Price { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
