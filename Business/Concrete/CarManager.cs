using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}