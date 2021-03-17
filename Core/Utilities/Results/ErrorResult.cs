using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        /*CarProductManager'daki kullanımı
        * 
        public IResult Add(Car car)
       {
           return new ErrorResult("Ürün eklenemedi.");
       }
        */

        public ErrorResult() : base(false)
        {
        }

        /*CarProductManager'daki kullanımı
         * 
         public IResult Add(Car car)
        {
            return new ErrorResult();
        }
         */
    }
}
