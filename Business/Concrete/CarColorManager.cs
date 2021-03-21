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
    public class CarColorManager : ICarColorService
    {
        ICarColorDal _carColorDal;

        public CarColorManager(ICarColorDal carColorDal)
        {
            _carColorDal = carColorDal;
        }

        public IResult Add(Color color)
        {

            _carColorDal.Add(color);

            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _carColorDal.Delete(color);

            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);//Generate field dediğimizde Messages a ekleme yapar
            }
            return new SuccessDataResult<List<Color>>( _carColorDal.GetAll(),Messages.ColorListed);

        }

        public IResult Update(Color color)
        {
            _carColorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }

        public IDataResult<List<Color>> GetById(int Id)
        {
            return new SuccessDataResult<List<Color>>(_carColorDal.GetAll(p => p.ColorId == Id));
        }
    }
}
