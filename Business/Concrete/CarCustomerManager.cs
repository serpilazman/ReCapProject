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
    public class CarCustomerManager : ICarCustomerService
    {
        ICarCustomerDal _carCustomerDal;
        public CarCustomerManager(ICarCustomerDal carCustomerDal)
        {
            _carCustomerDal = carCustomerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.UserId != 0)
            {
                _carCustomerDal.Add(customer);
                return new SuccessResult(Messages.CustomerAdded);
            }
            return new ErrorResult(Messages.CustomerAddError);
        }

        public IResult Delete(Customer customer)
        {
            _carCustomerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_carCustomerDal.GetAll(),Messages.CustomerListed);
        }

        public IDataResult<List<Customer>> GetById(int Id)
        {
            return new SuccessDataResult<List<Customer>>(_carCustomerDal.GetAll(c => c.Id == Id));
        }

        public IResult Update(Customer customer)
        {
            _carCustomerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated );
        }
    }
}
