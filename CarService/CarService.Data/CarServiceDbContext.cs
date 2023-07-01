using CarService.Data.Models.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarService.Data
{
    public class CarServiceDbContext : IdentityDbContext
	{
		public CarServiceDbContext(DbContextOptions<CarServiceDbContext> options)
			: base(options)
		{
		}

        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarsService> CarsServices { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Employee> Employees { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

	}
}