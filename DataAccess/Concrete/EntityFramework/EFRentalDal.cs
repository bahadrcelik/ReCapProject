﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFRentalDal :EFEntityRepositoryBase<Rental,ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals

                             join c in context.Cars
                             on r.CarId equals c.CarId



                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId

                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.CarId,
                                 CustomerId = cu.CustomerId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate

                             };

                return result.ToList();
            }
        }

    }
}
