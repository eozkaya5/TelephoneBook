using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public class Messages
    {
        public static string Added = "Kişi Eklendi.";
        public static string Deleted = "Kişi Silindi";
        public static string Updated = "Kişi Güncellendi.";
        public static string Listed = "Kişiler Listelendi.";

        public static string UserRegistered = "Kullanıcı Kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş yapıldı.";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token eklendi.";

        public static string AuthorizationDenied = "";
    }
}
