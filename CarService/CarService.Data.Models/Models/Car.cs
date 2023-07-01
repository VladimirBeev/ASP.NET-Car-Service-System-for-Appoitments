using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static CarService.Common.EntityValidationConstants.CarConstant;

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
        public string Make { get; set; } = null!;

        [Comment("Car Model")]
        [Required]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; set; } = null!;

        [Comment("Manufactured Year")]
        public int? Year { get; set; }

        [Comment("Fuel Type")]
        [Required]
        [Range(CarFuelMaxLength,CarFuelMinLength)]
        public FuelType FuelType { get; set; }

        [Comment("Color of car")]
        [MaxLength(CarColorMaxLength)]
        public string? Color { get; set; }

        [Comment("Type of Transmission")]
        [MaxLength(15)]
        public string? TransmissionType { get; set; }

        [Comment("Kilometers")]
        [MaxLength(7)]
        public string? Kilometers { get; set; }

        [Comment("Engine Power")]
        [MaxLength(10)]
        public string? EnginePower { get; set; }

        [Comment("Engine Type")]
        [MaxLength(10)]
        public string? EngineType { get; set; }

        [Comment("Vin Number")]
        [Required]
        [MaxLength(15)]
        public string Vin { get; set; } = null!;

        [Comment("Registration Number")]
        [Required]
        [MaxLength(7)]
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
