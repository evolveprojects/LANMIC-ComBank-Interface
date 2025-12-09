using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.DatabaseModels;

namespace LANMIC_ComBank_Interface.Models.ViewModels
{
    public class UserAuthorityViewModel : UserAuthority
    {
        public bool View { get; set; } = false;
        public bool New { get; set; } = false;
        public bool Edit { get; set; } = false;
        public bool Delete { get; set; } = false;
        public bool Print { get; set; } = false;
    }
}
