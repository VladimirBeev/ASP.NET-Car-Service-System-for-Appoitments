using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static CarService.Common.EntityValidationConstants.CarConstants;

namespace CarService.Data.Models.Models
{
	[Comment("Car Table")]
    public class Car
    {
        [Comment("Primary Key")]
        [Key]
        public int Id { get; set; }

        [Comment("Car Make")]
        [Required]
        [MaxLength(CarMakeMaxLength)]

        // TODO: Make class for Make
        public string Make { get; set; } = null!;

        [Comment("Car Model")]
        [Required]
        [MaxLength(CarModelMaxLength)]

        // TODO:Make class for Model
        public string Model { get; set; } = null!;

        [Comment("Manufactured Year")]
        public int? Year { get; set; }

        [Comment("Fuel Type")]
        [Required]
        [Range(CarFuelMaxLength, CarFuelMinLength)]

		// TODO: Make class for Fuel Type
		public FuelType FuelType { get; set; }

        [Comment("Color of car")]
        [MaxLength(CarColorMaxLength)]

        // TODO: Make class for Color
        public string? Color { get; set; }

        [Comment("Type of Transmission")]
        [MaxLength(CarTransmissionTypeMaxLength)]

        // TODO: Make class for Transmission Type
        public string? TransmissionType { get; set; }

        [Comment("Kilometers")]
        [MaxLength(CarKilometersMaxLength)]
        public int? Kilometers { get; set; }

        [Comment("Engine Power")]
        [MaxLength(CarEnginePowerMaxLength)]

        // TODO: Make class for Engine Power
        public string? EnginePower { get; set; }

        [Comment("Engine Type")]
        [MaxLength(CarEngineTypeMaxLength)]

        // TODO: Make class for Engine Type
        public string? EngineType { get; set; }

        [Comment("Vin Number")]
        [Required]
        [MaxLength(CarVinMaxLength)]
        public string Vin { get; set; } = null!;

        [Comment("Registration Number")]
        [Required]
        [MaxLength(CarRegNumMaxLength)]
        public string RegNum { get; set; } = null!;


        [Comment("Owner Id")]
        public int OwnerId { get; set; }
        [Comment("Owner")]
        [ForeignKey(nameof(OwnerId))]
        [Required]
        public CarOwner Owner { get; set; } = null!;

        public ICollection<Appointment>? Appointments { get; set; } = new List<Appointment>();
    }
}
