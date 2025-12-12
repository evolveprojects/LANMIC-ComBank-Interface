using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using LANMIC_ComBank_Interface.Models.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LANMIC_ComBank_Interface.Models.SessionModel
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static List<UserAuthorityViewModel> UserPermissions { get; set; }      
        public static bool IsAdmin { get; set; }
        public static DateTime LoginTime { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            IsAdmin = false;
            LoginTime = DateTime.MinValue;
            UserPermissions = new List<UserAuthorityViewModel>();
        }

    }
}
