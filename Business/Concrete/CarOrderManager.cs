using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Order order)
        {

            
           
            _carOrderDal.Add(order);

            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _carOrderDal.Delete(order);

            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Order>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Order>>(_carOrderDal.GetAll(),Messages.OrderListed);

        }

        public IDataResult<List<Order>> GetById(int Id)
        {
            return new SuccessDataResult<List<Order>>(_carOrderDal.GetAll(o => o.OrderId == Id));
        }

        public IResult Update(Order order)
        {
            _carOrderDal.Update(order);

            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
