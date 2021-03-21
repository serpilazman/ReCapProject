using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetById(int Id);

        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
