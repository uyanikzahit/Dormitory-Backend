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
        public static string RoomAdded = "Oda başarıyla eklendi.";
        public static string RoomDeleted = "Oda başarıyla silindi.";
        public static string RoomUpdated = "Oda başarıyla güncellendi.";
        public static string RoomsListed = "Oda listelendi";
        public static string RoomListed = "Oda listelendi";
        public static string RoomNumberAlreadyExists = "Bu oda numarasına ait oda mevcut.";

        //Announcement Messages
        public static string AnnouncementAdded = "Duyuru başarıyla eklendi.";
        public static string AnnouncementDeleted = "Duyuru başarıyla silindi.";
        public static string AnnouncementUpdated = "Duyuru başarıyla güncellendi.";
        public static string AnnouncementListed = "Duyurular listelendi";
        public static string AnnouncementsListed = "Duyuru listelendi";

        //Cafeteria Messages
        public static string CafeteriaAdded = "Yemek başarıyla eklendi.";
        public static string CafeteriaDeleted = "Yemek başarıyla silindi.";
        public static string CafeteriaUpdated = "Yemek başarıyla güncellendi.";
        public static string CafeteriasListed = "Yemekler listelendi";
        public static string CafeteriaListed = "Yemek listelendi";

        //Image Messages
        public static string UserImageLimit = "Bir kullanıcıya birden fazla resim eklenemez";
        public static string UserImageDeleted = "Resim silindi";
        public static string UserImageUpdated = "Resim güncellendi";
        public static string UserImageAdded = "Resim eklendi";

        //Record Messages
        public static string RecordAdded = "Kayıt Eklendi";
        public static string RecordDeleted = "Kayıt Silindi";
        public static string RecordUpdated = "Kayıt Güncellendi";
        public static string RecordNameInvalid = "Kayıt İsmi Geçersiz";
        public static string RecordsListed = "Kayıtlar Listelendi";
        public static string RecordListed = "Kayıt Listelendi";
        public static string RecordDetailsListed = "Kayıt Detayları Listelendi";


    }
}
