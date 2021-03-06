using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarBrandManager : ICarBrandService
    {

        ICarBrandDal _carBrandDal;

        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }

        public void Add(Brand brand)
        {
            _carBrandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _carBrandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _carBrandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _carBrandDal.Update(brand);
        }

        public List<Brand> GetById(int Id)
        {
            return _carBrandDal.GetAll(p => p.BrandId == Id);
        }
    }
}
