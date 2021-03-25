using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarProductService
    {
        IDataResult<List<Car>> GetAll();//IDataResult-->durumu,mesajı ve döndürülecek listeyi içeren bir yapı
        IDataResult<List<Car>> GetById(int Id);
        IDataResult< List<Car>> GetCarsByBrandId(int Id);
        IDataResult< List<Car>> GetCarsByColorId(int Id);
        IResult  Add(Car car);   //IResult void metotlar için oluşturuldu,durum ve mesaj bilgisi içeriyor     
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
