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

            if (car.Description.Length>=2 && car.DailyPrice>0)
            {
                _carProductDal.Add(car);
            }
            
        }
                

        public void Delete(Car car)
        {
            _carProductDal.Delete(car);
        }

        public List<Car> GetAll()
        {
          return  _carProductDal.GetAll();
        }

        public List<Car> GetById(int Id)
        {
            return _carProductDal.GetAll(p => p.Id == Id);
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carProductDal.GetAll(p=>p.BrandId==Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carProductDal.GetAll(p=>p.ColorId==Id);
        }

        public void Update(Car car)
        {
            _carProductDal.Update(car);
        }
    }
}
