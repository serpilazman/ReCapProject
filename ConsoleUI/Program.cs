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
            //CarAddTest();
            //CarGetAllTest();
            //GetByIdTest();
            //GetCarsByBrandIdTest();
            //GetCarsByColorIdTest();
            //CarUpdateTest();
            //CarDeleteTest();
            //ColorGetAllTest();
            //ColorDeleteTest();
            //ColorUpdateTest();
            //ColorAddTest();
            //ColorGetAllSuccessTest();
            //OrderTest();
            //CarTest();
            //CustomerAddTest();
            //CustomerListTest();
            //RentACarTest();
            //RentACarListTest();

        }

        private static void RentACarListTest()
        {
            CarRentalManager carRentalManager = new CarRentalManager(new EfRentalDal());
            Console.WriteLine("Id" + "---" + "Araç Id" + "---" + " Müşteri Id" + "---" + "Kiralama Tarihi" + "---" + "Teslim Tarihi");
            foreach (var car in carRentalManager.GetAll().Data)
            {
                Console.WriteLine(car.Id + "---" + car.CarId + "---" + car.CustomerId + "---" + car.RentDate + "---" + car.ReturnDate);
            }
        }

        private static void RentACarTest()
        {
            CarRentalManager carRentalManager = new CarRentalManager(new EfRentalDal());
            string _tempCustomer;
            int _carId, _customerId;
            DateTime _rentDate;
            DateTime? _returnDate;

            Console.Write("Kiralaması Yapılacak Müşteri Id: ");
            _tempCustomer = Console.ReadLine();

            if (_tempCustomer != null)
            {
                Console.Write("Kiralanacak araç Id: ");
                _carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kiralama Tarihi [aa/gg/yyyy] : ");
                _rentDate = Convert.ToDateTime(Console.ReadLine());
                _returnDate = null;
                _customerId = Convert.ToInt32(_tempCustomer);


                Rental rental = new Rental
                {

                    CarId = _carId,
                    CustomerId = _customerId,
                    RentDate = _rentDate,
                    ReturnDate = _returnDate
                };

                var result = carRentalManager.Add(rental);
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorGetAllSuccessTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            Console.WriteLine("Color bilgisi çekme result");

            var result = carColorManager.GetAll();


            if (result.Success)
            {
                foreach (Color color in result.Data)
                {
                    Console.WriteLine(color.ColorId + "-----" + color.ColorName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorAddTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());

            Console.WriteLine("Yeni Renk Ekleme");

            carColorManager.Add(
                new Color { ColorId = 4, ColorName = "Pink" }
                );

            foreach (Color color in carColorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "-----" + color.ColorName);
            }
        }

        private static void ColorUpdateTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            Console.WriteLine("Color bilgisi güncelleme");

            carColorManager.Update(new Color { ColorId = 1, ColorName = "Green" });
        }

        private static void ColorDeleteTest()
        {
            Console.WriteLine("Color bilgisi silme");

            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());

            carColorManager.Delete(new Color { ColorId = 4 });

            foreach (Color color in carColorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "-----" + color.ColorName);
            }
        }

        private static void ColorGetAllTest()
        {
            CarColorManager carColorManager = new CarColorManager(new EfCarColorDal());
            foreach (Color color in carColorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "-----" + color.ColorName);
            }
        }

        private static void CarAddTest()
        {
            Console.WriteLine("Yeni araç kaydı  \n");

            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());
            carProductManager.Add(
                new Car { Id = 3, BrandId = 3, ColorId = 3, CarName = "Skoda", ModelYear = 2019, DailyPrice = 800000, Description = "Sıfır" }

                );

            foreach (Car car in carProductManager.GetAll().Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void CarGetAllTest()
        {
            Console.WriteLine("----------Tüm Araç Listesi---------- \n");

            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            foreach (var car in carProductManager.GetAll().Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void CarDeleteTest()
        {
            Console.WriteLine("Verilen araç Id'sine göre araç kaydı silme \n");

            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            carProductManager.Delete(new Car { Id = 3 });

            foreach (Car car in carProductManager.GetAll().Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void CarUpdateTest()
        {
            Console.WriteLine("Verilen Id bilgisine göre o araç kaydının güncelleme işlemi \n");
            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());
            carProductManager.Update(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 2,
                CarName = "Audi 2",
                ModelYear = 2010,
                DailyPrice = 55000,
                Description = "İkinci el"


            });

            foreach (Car car in carProductManager.GetAll().Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void GetByIdTest()
        {
            Console.WriteLine("Araç Id bilgisine göre veri çekme \n");
            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            foreach (var car in carProductManager.GetById(1).Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void GetCarsByBrandIdTest()
        {
            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            Console.WriteLine("Brand Id bilgisine göre veri çekme \n");

            foreach (var car in carProductManager.GetCarsByBrandId(1).Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void GetCarsByColorIdTest()
        {
            CarProductManager carProductManager = new CarProductManager(new EfCarProductDal());

            Console.WriteLine("Color Id bilgisine göre veri çekme \n");


            foreach (var car in carProductManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(" Id: " + car.Id + "\n Marka Id: " + car.BrandId + "\n Renk Id: " + car.ColorId + "\n Araç adı: " + car.CarName + "\n Araç açıklama: " + car.Description + " \n Araç kiralama günlük fiyat: " + car.DailyPrice + "\n Araç model tarihi: " + car.ModelYear);
            }
        }

        private static void CustomerListTest()
        {
            CarCustomerManager carCustomerManager = new CarCustomerManager(new EfCustomerDal());

            var result = carCustomerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine("Müşteri Id: " + customer.Id + "\n Kullanıcı Id: " + customer.UserId + " \n Müşteri şirket: " + customer.CompanyName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAddTest()
        {
            CarCustomerManager carCustomerManager = new CarCustomerManager(new EfCustomerDal());

            Console.WriteLine("Yeni müşteri ekleme");
            carCustomerManager.Add(
                new Customer { Id = 4, UserId = 4, CompanyName = "CompanyD" }
                );
        }

        private static void CarTest()
        {
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
        }

        private static void OrderTest()
        {
            CarOrderManager carOrderManager = new CarOrderManager(new EfCarOrderDal());
            foreach (var order in carOrderManager.GetAll().Data)
            {
                Console.WriteLine(order.OrderId);
            }
        }
    }
}
