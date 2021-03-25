using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RecapProjectDBContext>, ICarCustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var result = from cst in filter is null ? context.Customers : context.Customers.Where(filter)
                             join usr in context.Users on cst.UserId equals usr.Id
                             select new CustomerDetailDto
                             { 
                                 CustomerId =cst.Id,
                                 UserId = usr.Id,
                                 UserName = usr.FirstName,
                                 CompanyName = cst.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}
