using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ 
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)//this-->Message parametresinin yanında Result'ın tek parametreli olan constructor ına success i yolla
        {
            Message = message;
            
        }

        public Result(bool success)
        {
            
            Success = success;
        }
        public bool Success { get; }

        public string Message  { get; } //getter read only olsa bile constructor içerisinde set edilebilir.
    }
}
