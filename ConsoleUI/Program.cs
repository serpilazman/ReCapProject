using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarProductManager carProductManager = new CarProductManager(new InMemoryCarProductDal());

            List<Car> cars = carProductManager.GetAll();

            Console.WriteLine("----------Tüm Araç Listesi---------- \n");

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id+"--"+car.Description+"--"+car.DailyPrice+"---"+car.ModelYear+"---"+car.ColorId);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Id bilgisine göre veri çekme \n");

            List<Car> carsId = carProductManager.GetAllById(3);

            foreach (var car in carsId)
            {
                Console.WriteLine(car.Id + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear + "---" + car.ColorId);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Yeni araç kaydı \n");

            carProductManager.Add(
                new Car {Id=6,BrandId=2,ColorId=2,DailyPrice=800000,Description="Sıfır",ModelYear=2019 },
                new Car { Id = 7, BrandId = 3, ColorId = 3, DailyPrice = 10000, Description = "İkinci el", ModelYear = 2018 }
                
                );

            foreach (Car car in carProductManager.GetAll())
            {
                Console.WriteLine(car.Id + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear + "---" + car.ColorId);
            }


            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Verilen araç Id'sine göre araç kaydı silme \n");

            carProductManager.Delete(new Car { Id=1});

            foreach (Car car in carProductManager.GetAll())
            {
                Console.WriteLine(car.Id + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear + "---" + car.ColorId);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Verilen Id bilgisine göre o araç kaydının güncelleme işlemi \n");

            carProductManager.Update(new Car
            {
                Id=2,
                BrandId=1,
                ColorId=2,
                DailyPrice=55000,
                Description="İkinci el",
                ModelYear=2010

            });

            foreach (Car car in carProductManager.GetAll())
            {
                Console.WriteLine(car.Id + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear + "---" + car.ColorId);
            }

        }
    }
}
