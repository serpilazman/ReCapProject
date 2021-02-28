using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICarProductDal
    {

        List<Car> GetAll();
        List<Car> GetAllById(int Id);
        void Add(Car car);
        void Add(Car car,Car car1);
        void Update(Car car);
        void Delete(Car car);
    }
}
