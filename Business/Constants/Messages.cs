using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";

        public static string CategoryAdded = "Kategori başarıyla eklendi";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi";
        public static string CategoryDeleted = "Kategori başarıyla silindi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string LoginSuccessful = "Başarılı giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}