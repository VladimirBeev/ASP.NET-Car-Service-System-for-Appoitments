using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Common
{
	public static class EntityValidationConstants
	{
		public static class CarConstant
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
		}
	}
}
