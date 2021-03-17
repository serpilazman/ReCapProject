using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Durumu ve sonucu içeren bir :IResult implementasyonu olduğunu belirtiyoruz
    public interface IDataResult<T>:IResult
    {
        T Data { get; } //Araba,arabalar
    }
}
