using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANMIC_ComBank_Interface.HelpServices.CombankAPI
{
    public class ApiResponse
    {
        public string status { get; set; }
        public DataObject? data { get; set; } = null;
        public List<ApiError>? errors { get; set; } = null;
        public object warnings { get; set; }
    }

    public class ApiError
    {
        public string code { get; set; }
        public string message { get; set; }
    }

    public class DataObject
    {
        public string respdesc { get; set; }
        public string respcode { get; set; }
        public string description { get; set; }
        public string reference { get; set; }
        public string status { get; set; }
        public string isnumber { get; set; }
    }

}