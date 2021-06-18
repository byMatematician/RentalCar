using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from c in context.CARS
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.BrandName,
                                 BrandId = c.BrandId,
                                 DailyPrice = c.Dailyprice,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        
        }
    }
}
