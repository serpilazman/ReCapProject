using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarColorManager : ICarColorService
    {
        ICarColorDal _carColorDal;

        public CarColorManager(ICarColorDal carColorDal)
        {
            _carColorDal = carColorDal;
        }

        public void Add(Color color)
        {
            _carColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _carColorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _carColorDal.GetAll();
        }

        public void Update(Color color)
        {
            _carColorDal.Update(color);
        }

        public List<Color> GetById(int Id)
        {
            return _carColorDal.GetAll(p => p.ColorId == Id);
        }
    }
}
