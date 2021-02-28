using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarProductManager : ICarProductService
    {
        ICarProductDal _carProductDal;

        public CarProductManager(ICarProductDal carProductDal)
        {
            _carProductDal = carProductDal;
        }

        public void Add(Car car)
        {
            _carProductDal.Add(car);
        }

        public void Add(Car car, Car car1)
        {
            _carProductDal.Add(car);
            _carProductDal.Add(car1);


        }

        public void Delete(Car car)
        {
            _carProductDal.Delete(car);
        }

        public List<Car> GetAll()
        {
          return  _carProductDal.GetAll();
        }

        public List<Car> GetAllById(int Id)
        {
            return _carProductDal.GetAllById(Id);
        }

        public void Update(Car car)
        {
            _carProductDal.Update(car);
        }
    }
}
