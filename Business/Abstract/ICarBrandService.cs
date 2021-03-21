﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int Id);
        
        IResult Add(Brand brand);        
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
