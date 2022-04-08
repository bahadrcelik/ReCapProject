using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice> 0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Was Added");
            }
            else
            {
                Console.WriteLine("ERROR ! Car Not Added");
            }
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Car Deleted !");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(b => b.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=> c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            Console.WriteLine("Car Updated !");
        }
    }
}