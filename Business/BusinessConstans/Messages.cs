using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //System Messages
        public static string MaintenanceTime = "Sistem Bakımda.";
        

        //User Messages
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserListed = "Kullanıcı Listelendi";

       

        //Process Messages
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";

        //Shcool Messages
        public static string ShcoolAdded = "Okul başarıyla eklendi.";
        public static string ShcoolDeleted = "Okul başarıyla silindi.";
        public static string ShcoolUpdated = "Okul başarıyla güncellendi.";
        public static string ShcoolsListed = "Okullar Listelendi";
        public static string ShcoolListed = "Okul Listelendi";


    }
}
