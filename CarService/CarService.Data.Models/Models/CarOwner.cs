using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static CarService.Common.EntityValidationConstants.CarOwnerConstants;

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
        [MaxLength(CarOwnerNameMaxLength)]
        public string Name { get; set; } = null!;

        [Comment("Address of owner")]
        [MaxLength(CarOwnerAddressMaxLength)]
        public string? Address { get; set; }

        [Comment("Phone Number")]
        [Required]
		[Phone]
		[RegularExpression(CarOwnerPhoneNumberRegEx)]
        public int PhoneNumber { get; set; }

        [Comment("Date of birth")]
        [RegularExpression(CarOwnerDateOfBirthRegEx)]
        public DateTime? DateOfBirth { get; set; }

        [Comment("Email of owner")]
		[Required]
		[EmailAddress]
        [RegularExpression(CarOwnerEmailRegEx)]
        public string Email { get; set; } = null!;

        [Comment("Password of owner")]
        [Required]
        [RegularExpression(CarOwnerPasswordRegEx)]
        public string Password { get; set; } = null!;

        public ICollection<Car> Car { get; set; } = new List<Car>();
    }
}
