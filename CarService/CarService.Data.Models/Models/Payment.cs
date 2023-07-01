using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarService.Data.Models.Models
{
    [Comment("Payment Table")]
    public class Payment
    {
        [Comment("Primary Key")]
        [Key]
        public int Id { get; set; }

        [Comment("Payment Type")]
        [Required]
        [Range(minimum: 1, maximum: 3)]
        public PaymentType PaymentTypeId { get; set; }
        public bool Status { get; set; }

        [Comment("Amount")]
        [Required]
        [Precision(6, 2)]
        public decimal Amount { get; set; }

        [Comment("Date of pay")]
        [Required]
        public DateTime DateOfPay { get; set; }


        [Comment("OwnerId")]
        public int OwnerId { get; set; }
        [Comment("Owner")]
        [ForeignKey(nameof(OwnerId))]
        [Required]
        public CarOwner CarOwner { get; set; } = null!;

        public ICollection<CarsService> CarServices { get; set; } = new HashSet<CarsService>();

    }
}
