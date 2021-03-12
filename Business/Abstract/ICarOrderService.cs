using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarOrderService
    {
        List<Order> GetAll();
        List<Order> GetById(int Id);

        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
