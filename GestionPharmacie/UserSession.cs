using System;

namespace GestionPharmacie
{

    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string UserEmail { get; set; }
        public static string UserName { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void Login(int userId, string email, string name)
        {
            UserId = userId;
            UserEmail = email;
            UserName = name;
            IsLoggedIn = true;
        }

        public static void Logout()
        {
            UserId = 0;
            UserEmail = null;
            UserName = null;
            IsLoggedIn = false;
        }
    }
}
