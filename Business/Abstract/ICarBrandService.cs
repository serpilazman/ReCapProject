using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetById(int Id);
        
        void Add(Brand brand);        
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
