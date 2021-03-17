using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using Entities.Concrete;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DTO-Data Transformation Object
            //OrderTest();



            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            var result = carProductManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "---" + car.DailyPrice + "---" + car.BrandName + "---" + car.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

            



                //CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

                //CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());

                //Console.WriteLine("Yeni Renk Ekleme");

                //carColorManager.Add(
                //    new Color { ColorId=1,ColorName="Pink"}                
                //    );

                //Console.WriteLine("Color bilgisi çekme");

                //foreach (Color color in carColorManager.GetAll())
                //{
                //    Console.WriteLine(color.ColorId+"-----"+color.ColorName);
                //}

                //Console.WriteLine("Color bilgisi güncelleme");

                //carColorManager.Update(new Color { ColorId=1,ColorName="Red"}

                //    );




                //foreach (Color color in carColorManager.GetAll())
                //{
                //    Console.WriteLine(color.ColorId + "-----" + color.ColorName);
                //}

                //Console.WriteLine("Color bilgisi silme");

                //carColorManager.Delete(new Color { ColorId=1});







                //Console.WriteLine("Yeni araç kaydı yapılmıştı \n");


                //carProductManager.Add(
                //    new Car { Id = 1, BrandId = 2, ColorId = 2, CarName="Audi", DailyPrice = 800000, Description = "abc", ModelYear = 2019 }

                //    );

                //foreach (Car car in carProductManager.GetAll())
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.CarName + "--"+car.Description + "--" + car.DailyPrice + "---" + car.ModelYear);
                //}





                //Console.WriteLine("---------------------------------------------------");

                //List<Car> cars = carProductManager.GetAll();

                //Console.WriteLine("----------Tüm Araç Listesi---------- \n");

                //foreach (var car in cars)
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear );
                //}






                //Console.WriteLine("---------------------------------------------------");






                //Console.WriteLine("Verilen araç Id'sine göre araç kaydı silme \n");

                //carProductManager.Delete(new Car { Id = 1 });

                //foreach (Car car in carProductManager.GetAll())
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear );
                //}





                //Console.WriteLine("---------------------------------------------------");






                //Console.WriteLine("Verilen Id bilgisine göre o araç kaydının güncelleme işlemi \n");

                //carProductManager.Update(new Car
                //{
                //    Id = 1,
                //    BrandId = 1,
                //    ColorId = 2,
                //    DailyPrice = 55000,
                //    Description = "İkinci el",
                //    ModelYear = 2010

                //});

                //foreach (Car car in carProductManager.GetAll())
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear );
                //}





                //Console.WriteLine("---------------------------------------------------");





                //Console.WriteLine("Araç Id bilgisine göre veri çekme \n");

                //List<Car> carsId = carProductManager.GetById(2);

                //foreach (var car in carsId)
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear);
                //}




                //Console.WriteLine("---------------------------------------------------");





                //Console.WriteLine("Brand Id bilgisine göre veri çekme \n");

                //List<Car> carsId = carProductManager.GetCarsByBrandId(2);

                //foreach (var car in carsId)
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear);
                //}




                //Console.WriteLine("---------------------------------------------------");





                //Console.WriteLine("Color Id bilgisine göre veri çekme \n");

                //List<Car> carsId = carProductManager.GetCarsByColorId(2);

                //foreach (var car in carsId)
                //{
                //    Console.WriteLine(car.Id + "---" + car.BrandId + "---" + car.ColorId + "--" + car.Description + "--" + car.DailyPrice + "---" + car.ModelYear);
                //}


        }

        //private static void OrderTest()
        //{
        //    CarOrderManager carOrderManager = new CarOrderManager(new EfCarOrderDal());
        //    foreach (var order in carOrderManager.GetAll())
        //    {
        //        Console.WriteLine(order.OrderId);
        //    }
        //}
    }
}
