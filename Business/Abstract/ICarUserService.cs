using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int Id);

        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
