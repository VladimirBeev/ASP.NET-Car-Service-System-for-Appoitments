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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>()
				.Property(e => e.FirstName)
				.HasColumnName("First Name");
			modelBuilder.Entity<Employee>()
				.Property(e => e.LastName)
				.HasColumnName("Last Name");
			modelBuilder.Entity<Employee>()
				.Property(e => e.StartDate)
				.HasColumnName("Start Date");
			modelBuilder.Entity<Employee>()
				.Property(e => e.EndDate)
				.HasColumnName("End Date");

			modelBuilder.Entity<Appointment>()
				.Property(e => e.AppointmentDateTime)
				.HasColumnName("Appointment Date");

			modelBuilder.Entity<Car>()
				.Property(e => e.FuelType)
				.HasColumnName("Fuel Type");
			modelBuilder.Entity<Car>()
				.Property(e => e.TransmissionType)
				.HasColumnName("Transmission Type");
			modelBuilder.Entity<Car>()
				.Property(e => e.EnginePower)
				.HasColumnName("Engine Power");
			modelBuilder.Entity<Car>()
				.Property(e => e.EngineType)
				.HasColumnName("Engine Type");
			modelBuilder.Entity<Car>()
				.Property(e => e.Vin)
				.HasColumnName("Vin Number");
			modelBuilder.Entity<Car>()
				.Property(e => e.RegNum)
				.HasColumnName("Registration Number");

			modelBuilder.Entity<CarOwner>()
				.Property(e => e.PhoneNumber)
				.HasColumnName("Phone Number");
			modelBuilder.Entity<CarOwner>()
				.Property(e => e.DateOfBirth)
				.HasColumnName("Date Of Birth");

			modelBuilder.Entity<Payment>()
				.Property(e => e.DateOfPay)
				.HasColumnName("Date Of Pay");

			base.OnModelCreating(modelBuilder);
		}

	}
}