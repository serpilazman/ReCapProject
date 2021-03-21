using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int Id);
        
        IResult Add(Color color);        
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
