using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakım saati";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated="Ürün güncellendi.";
        public static string ProductNameExist="Aynı kategoride ürün ismi mevcut.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı. Ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetki Yok";
        public static string UserRegistered="Kullanıcı Kaydedildi";
        public static string UserNotFound="Kullaıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş tokeni oluşturuldu.";
    }
}
