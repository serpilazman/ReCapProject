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

        public static string OrderAdded = "Sipariş eklendi";
        public static string OrderDeleted = "Sipariş silindi";
        public static string OrderListed = "Siparişler silindi";
        public static string OrderUpdated = "Siparişler silindi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorUpdated = "Renkler güncellendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandUpdated = "Marka güncellendi";
    }
}
