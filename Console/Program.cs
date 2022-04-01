using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                System.Console.WriteLine("Brand Id : "+car.BrandId +"  =  " +"Daily Price : "+car.DailyPrice+" / Model : "+car.Description   +" / Fuel :  " + car.Features);
            }

            System.Console.WriteLine("-----------");

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                System.Console.WriteLine(car.Description);
            }

            System.Console.WriteLine("-------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                System.Console.WriteLine(car.Description + " " +car.Features);
            }
        }
    }
}
