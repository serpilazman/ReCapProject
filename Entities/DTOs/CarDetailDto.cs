using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{

    //IEntity -- Sen bir veritabanı tablosusun anlamına gelir
    //IEntity -- evrensel bir interface
    //IDto -- evrensel bir interface -->Generate type IDto
  public  class CarDetailDto:IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
