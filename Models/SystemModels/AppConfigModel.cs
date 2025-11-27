using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.Models.SystemModels
{
    public class AppConfigModel
    {
        public string AppName { get; set; }
        public DatabaseConfigModel Database { get; set; }
    }
}
