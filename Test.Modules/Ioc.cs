using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Modules.Interfaces;
using Test.Modules.Modules;

namespace Test.Modules
{
    public static class Ioc
    {
        public static void IocModulesInstall(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICompanyService, CompanyService>();            
        }
    }
}
