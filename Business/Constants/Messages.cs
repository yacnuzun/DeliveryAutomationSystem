using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string DeliveryListed = "Teslimatlar Listelendi.";

        public static string DeliveryAdded = "Teslimat Eklendi.";

        public static string DeliveryHandOver = "Teslim Edildi.";

        public static string DeliveryTake = "Teslimat Alındı.";

        public static string OrderGet = "Siparişler Listelendi.";

        public static string OrderGive = "Sipariş Verildi.";

        public static string UserNameOrPasswordError = "Kullanıcı adı veya sifre hatalı";

        public static string UserExistsError = "Böyle bir kullanıcı yok.";

        public static string LoginSuccess = "Giriş başarılı!";

        public static string TokenCreate = "Token Oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok";
    }
}
