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

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}-----{1}", car.BrandName, car.Description);
            }
        }

        

        

	
    }
}
