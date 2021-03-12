using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete
{
    public class InMemoryCarProductDal :ICarProductDal
    {// Burada memory'de tutulacak verileri oluşturacağız


        List<Car> _cars;

        public InMemoryCarProductDal() //Constructor
        {
            _cars = new List<Car> { 
            new Car{BrandId=1,ColorId=1,DailyPrice=500000,Description="Sıfır",Id=1,ModelYear=2021},
            new Car{BrandId=3,ColorId=1,DailyPrice=5000,Description="İkinci el",Id=2,ModelYear=2010},
            new Car{BrandId=2,ColorId=1,DailyPrice=100000,Description="İkinci el",Id=3,ModelYear=2015},
            new Car{BrandId=1,ColorId=1,DailyPrice=90000,Description="İkinci el",Id=4,ModelYear=2017},
            new Car{BrandId=1,ColorId=1,DailyPrice=125000,Description="Sıfır",Id=5,ModelYear=2020}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Add(Car car, Car car1)
        {
            _cars.Add(car);
            _cars.Add(car1);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{

        //}

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(p=>p.Id==Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=>p.Id==car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        
    }
}
