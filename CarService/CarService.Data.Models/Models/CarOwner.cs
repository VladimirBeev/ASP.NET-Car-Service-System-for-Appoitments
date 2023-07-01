using Microsoft.EntityFrameworkCore;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarService.Data.Models.Models
{
    [Comment("Car Owner Table")]
    public class CarOwner
    {
        [Comment("Primary Key")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of owner")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Comment("Address of owner")]
        [MaxLength(100)]
        public string? Address { get; set; }

        [Comment("Phone Number")]
        [Required]
        [MaxLength(10)]
        public int PhoneNumber { get; set; }

        [Comment("Date of birth")]
        public DateTime? DateOfBirth { get; set; }

        [Comment("Email of owner")]
        [EmailAddress]
        [Required]
        [MaxLength(40)]
        public string Email { get; set; } = null!;

        [Comment("Password of owner")]
        [Required]
        [PasswordPropertyText]
        [MaxLength(20)]
        public string Password { get; set; } = null!;
        //public string? grantLevel { get; set; }
        public ICollection<Car> Car { get; set; } = new List<Car>();
    }
}
