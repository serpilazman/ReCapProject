using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; } //Bu kısım IDataResult dan implemente oldu

        public DataResult(T data,bool success,string message):base(success,message) //Bu kısım Result içerisinde bulunan constructor ların implemente edildiği kısım
        {
            Data = data;
        }

        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
    }
}
