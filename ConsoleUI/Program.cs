using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarTest();
			//BrandTest();
			//ColorTest();
		}

		private static void ColorTest()
		{
			ColorManeger colorManeger = new ColorManeger(new EfColorDal());

			foreach (var color in colorManeger.GetAll())
			{
				Console.WriteLine(color.ColorName);
			}
		}

		private static void BrandTest()
		{
			BrandManager brandManager = new BrandManager(new EfBrandDal());
			var NameById = brandManager.GetByBrandId(1).BrandName;
			
			Console.WriteLine(NameById);
			
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());
			var result = carManager.GetCarDetails();
            if (result.Success== true)
            {
				foreach (var car in result.Data)
				{
					Console.WriteLine("{0} - {1} - {2} - {3} - {4}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice, car.Description);
				}
			}
            else
            {
                Console.WriteLine(result.Message);
            }
			
		}

		

		

	
	}
}
