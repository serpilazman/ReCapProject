using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult: Result //Base(Result)
    {
        public SuccessResult(string message):base(true,message)
        {
            
        }

        /*CarProductManager'daki kullanımı
        * 
        public IResult Add(Car car)
       {
           return new SuccessResult("Ürün eklendi.");
       }
        */

        public SuccessResult() : base(true)
        {
        }

        /*CarProductManager'daki kullanımı
         * 
         public IResult Add(Car car)
        {
            return new SuccessResult();
        }
         */
    }
}
