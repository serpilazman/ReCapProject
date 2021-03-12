using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarProductDal : EfEntityRepositoryBase<Car, RecapProjectDBContext>, ICarProductDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapProjectDBContext context=new RecapProjectDBContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             select new CarDetailDto { BrandName = b.BrandName, CarName = p.CarName, ColorName = c.ColorName, DailyPrice = p.DailyPrice };
                return result.ToList();
                            
            }
        }
    }
}
