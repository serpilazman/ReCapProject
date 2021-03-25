using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarRentalManager : ICarRentalService
    {
        ICarRentalDal _carRentalDal;
        public CarRentalManager(ICarRentalDal carRentalDal)
        {
            _carRentalDal = carRentalDal;
        }

        public IResult Add(Rental rental)
        {
            //if (rental.ReturnDate==null)
            //{
            //    return new ErrorDataResult<List<Rental>>(Messages.ReturnDateError);
            //}
            _carRentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
        
        public IResult CheckReturnDate(int carId)
        {
            var result = _carRentalDal.GetCarRentalDetails(r => r.CarId == carId && r.ReturnDate == null);

            if (result.Count > 0)
            {
                return new ErrorResult(Messages.ReturnDateError);
            }

            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _carRentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_carRentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetById(int Id)
        {
            return new SuccessDataResult<List<Rental>>(_carRentalDal.GetAll(r=>r.Id==Id));
        }

        public IDataResult<List<CarRentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<CarRentalDetailDto>>(_carRentalDal.GetCarRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _carRentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult UpdateReturnDate(Rental rental)
        {
            var result = _carRentalDal.GetAll(r => r.Id==rental.Id);
            var updateRental = result.LastOrDefault();

            if (updateRental.ReturnDate == null)
            {
                updateRental.ReturnDate = rental.ReturnDate;
                _carRentalDal.Update(updateRental);
                return new SuccessResult(Messages.RentalUpdateReturnDate);
            }

            return new ErrorResult(Messages.RentalReturnDateInfo);
        }
    }
}
