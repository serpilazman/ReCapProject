using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Order:IEntity
    {
        //CarName, BrandName, ColorName, DailyPrice
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
    }
}
