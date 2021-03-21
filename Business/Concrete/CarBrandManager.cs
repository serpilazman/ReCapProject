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
    public class CarBrandManager : ICarBrandService
    {

        ICarBrandDal _carBrandDal;

        public CarBrandManager(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }

        public IResult Add(Brand brand)
        {

            _carBrandDal.Add(brand);

            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _carBrandDal.Delete(brand);

            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_carBrandDal.GetAll());

        }

        public IResult Update(Brand brand)
        {
             
            _carBrandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IDataResult<List<Brand>> GetById(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_carBrandDal.GetAll(p => p.BrandId == Id));
        }
    }
}
