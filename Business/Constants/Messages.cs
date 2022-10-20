using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme başarılı";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz yok";
        internal static string UserRegistered;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static User UserNotFound;
        internal static User PasswordError;
    }
}
