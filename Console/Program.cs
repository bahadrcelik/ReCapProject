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
            //CarManager carManager = new CarManager(new EFCarDal());

            //var result = carManager.GetCarDetailDtos();
            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarId + " --" + car.BrandName + "-- " + car.ColorName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
           

            //CarTest();

            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EFCarDal());
        //    foreach (var car in carManager.GetCarsByBrandId(5))
        //    {
        //        Console.WriteLine("Brand Id : " + car.BrandId + "  =  " + "Daily Price : " + car.DailyPrice + " / Model : " + car.Description + " / Fuel :  " + car.Features);
        //    }

        //    Console.WriteLine("-----------");

        //    foreach (var car in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    Console.WriteLine("-------------");

        //    foreach (var car in carManager.GetCarsByColorId(2))
        //    {
        //        Console.WriteLine(car.Description + " " + car.Features);
        //    }
        //}
    }
}
