using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreParametersTest
{
    public class ApiConfiguration
    {
        public string Gateway { get; set; }
        public CommomConfiguration Commom { get; set; }
    }


    public class CommomConfiguration
    {
        public string Gateway { get; set; }
    }
}
