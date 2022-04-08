using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId+ " --" +car.BrandName + "-- "+car.ColorName);
            }



            //CarTest();

            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine("Brand Id : " + car.BrandId + "  =  " + "Daily Price : " + car.DailyPrice + " / Model : " + car.Description + " / Fuel :  " + car.Features);
            }

            Console.WriteLine("-----------");

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description + " " + car.Features);
            }
        }
    }
}
