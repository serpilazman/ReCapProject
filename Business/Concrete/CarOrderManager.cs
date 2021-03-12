using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public  class CarOrderManager : ICarOrderService
    {
        ICarOrderDal _carOrderDal;

        public CarOrderManager(ICarOrderDal carOrderDal)
        {
            _carOrderDal = carOrderDal;
        }

        public void Add(Order order)
        {
            _carOrderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _carOrderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _carOrderDal.GetAll();
        }

        public List<Order> GetById(int Id)
        {
            return _carOrderDal.GetAll(o => o.OrderId == Id);
        }

        public void Update(Order order)
        {
            _carOrderDal.Update(order);
        }
    }
}
