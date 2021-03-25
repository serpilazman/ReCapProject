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

        public static string UserAdded = "Marka eklendi";
        public static string UserDeleted = "Marka silindi";
        public static string UserListed = "Markalar listelendi";
        public static string UserUpdated = "Marka güncellendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerAddError = "Böyle bir kullanıcı olmadığından Müşteri eklenemedi";

        public static string RentalAdded = "Araç kiraya verildi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralamalar güncellendi";
        public static string ReturnDateError = "Araç teslim edilmemiş kiralanamaz!";
        public static string RentalUpdateReturnDate = "Araç teslim tarihi bilgisi güncellendi";
        public static string RentalReturnDateInfo = "Araç teslim edilmiş";

    }
}
