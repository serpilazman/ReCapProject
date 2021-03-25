using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
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
        
        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                //Magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _carProductDal.Add(car);

            return new SuccessResult(Messages.ProductAdded);
            //Generate Constructor  'Result' with fields  yapısıyla oluşturulacak--Result tıkla F12

            //if (car.Description.Length>=2 && car.DailyPrice>0)
            //{
            //    _carProductDal.Add(car);
            //}

        }

        public IResult Update(Car car)
        {
            _carProductDal.Update(car);
            return new SuccessResult(Messages.ProductUpdated);
        }
        public IResult Delete(Car car)
        {
            _carProductDal.Delete(car);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);//Generate field dediğimizde Messages a ekleme yapar
            }

          return new SuccessDataResult<List<Car>>(_carProductDal.GetAll(),Messages.ProductListed);
        }
               

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);//Generate field dediğimizde Messages a ekleme yapar
            }
            return new SuccessDataResult<List<CarDetailDto>>( _carProductDal.GetCarDetails(),Messages.ProductListed);
        }

        public IDataResult< List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>( _carProductDal.GetAll(p=>p.BrandId==Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carProductDal.GetAll(p=>p.ColorId==Id));
        }

        

        public IDataResult<List<Car>> GetById(int Id)
        {
            return new SuccessDataResult<List<Car>> (_carProductDal.GetAll(p => p.Id == Id));
        }
    }
}
