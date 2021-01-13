using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreParametersTest
{
    public static class SystemManagerConfiguration
    {

        public static void ConfigureSystemanager(IConfigurationBuilder builder)
        {
            var build  = builder.Build();
            var options = build.GetAWSOptions("AWS:SystemManager");
            builder.AddSystemsManager("/Davi/Parameter", options);

        }
    }
}