using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static -->new lemeden kullanmak için ve burası sabit olduğu için kullanılır
 public static  class Messages
    {
        public static string ProductAdded = "Araç eklendi"; //Public değişken adları PascalCase yani büyük harf yazılır
        public static string ProductNameInvalid = "Araç adı geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed = "Araçlar listelendi";
        public static string ProductUpdated="Araç güncellendi";
        public static string ProductDeleted="Araç silindi";
    }
}
