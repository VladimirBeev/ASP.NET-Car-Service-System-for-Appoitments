using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Common
{
	public static class EntityValidationConstants
	{
		public static class AppointmentConstants
		{
			public const string AppointmentDateRegEx = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$";
		}
		public static class CarConstants
		{
			public const int CarMakeMinLength = 2;
			public const int CarMakeMaxLength = 20;

			public const int CarModelMinLength = 2;
			public const int CarModelMaxLength = 50;

			public const int CarFuelMinLength = 1;
			public const int CarFuelMaxLength = 5;

			public const int CarColorMinLength = 3;
			public const int CarColorMaxLength = 20;

			public const int CarTransmissionTypeMinLength = 5;
			public const int CarTransmissionTypeMaxLength = 20;

			public const int CarKilometersMinLength = 0;
			public const int CarKilometersMaxLength = 7;

			public const int CarEnginePowerMinLength = 0;
			public const int CarEnginePowerMaxLength = 10;

			public const int CarEngineTypeMinLength = 0;
			public const int CarEngineTypeMaxLength = 10;

			public const int CarVinMinLength = 15;
			public const int CarVinMaxLength = 15;

			public const int CarRegNumMinLength = 7;
			public const int CarRegNumMaxLength = 7;
		}

		public static class CarOwnerConstants
		{
			public const int CarOwnerNameMinLength = 0;
			public const int CarOwnerNameMaxLength = 30;

			public const int CarOwnerAddressMinLength = 0;
			public const int CarOwnerAddressMaxLength = 100;

			public const string CarOwnerDateOfBirthRegEx = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$";

			public const string CarOwnerPhoneNumberRegEx = @"^([\+] ? 359[-] ?|[0])?[1 - 9][0 - 9]{8}$";

			public const string CarOwnerEmailRegEx = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)";

			public const string CarOwnerPasswordRegEx = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

		}

		public static class CarsServiceConstants 
		{
			public const int CarsServiceNameMinLength = 0;
			public const int CarsServiceNameMaxLength = 50;
		}

		public static class EmployeeConstants
		{
			public const int EmployeeFirstNameMinLength = 0;
			public const int EmployeeFirstNameMaxLength = 130;

			public const int EmployeeLastNameMinLength = 0;
			public const int EmployeeLastNameMaxLength = 130;

			public const string EmployeeStartDateRegEx = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$";

			public const string EmployeeEndDateRegEx = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$";
		}

		public static class PaymentConstants
		{
			public const string PaymentDateOfPayRegEx = "^[0-9]{1,2}\\/[0-9]{1,2}\\/[0-9]{4}$";
		}
	}
}
