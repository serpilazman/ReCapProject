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
    public class CarUserManager : ICarUserService
    {
        ICarUserDal _carUserDal;
        public CarUserManager(ICarUserDal carUserDal)
        {
            _carUserDal = carUserDal;
        }

        public IResult Add(User user)
        {
            _carUserDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _carUserDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_carUserDal.GetAll(),Messages.UserListed);
        }

        public IDataResult<List<User>> GetById(int Id)
        {
            return new SuccessDataResult<List<User>>(_carUserDal.GetAll(u=>u.Id==Id));
        }

        public IResult Update(User user)
        {
            _carUserDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
