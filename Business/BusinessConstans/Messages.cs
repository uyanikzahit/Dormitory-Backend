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
        public static string SchoolAdded = "Okul başarıyla eklendi.";
        public static string SchoolDeleted = "Okul başarıyla silindi.";
        public static string SchoolUpdated = "Okul başarıyla güncellendi.";
        public static string SchoolsListed = "Okullar Listelendi";
        public static string SchoolListed = "Okul Listelendi";

        //Activity Messages
        public static string ActivityAdded = "Aktivite başarıyla eklendi.";
        public static string ActivityDeleted = "Aktivite başarıyla silindi.";
        public static string ActivityUpdated = "Aktivite başarıyla güncellendi.";
        public static string ActivitiesListed = "Aktiviteler listelendi";
        public static string ActivityListed = "Aktivite listelendi";

        //Rooom Messages
        public static string RoomAdded = "Aktivite başarıyla eklendi.";
        public static string RoomDeleted = "Aktivite başarıyla silindi.";
        public static string RoomUpdated = "Aktivite başarıyla güncellendi.";
        public static string RoomsListed = "Aktiviteler listelendi";
        public static string RoomListed = "Aktivite listelendi";


    }
}
