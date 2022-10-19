using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Impl.Base;
using Test.Data.Interfaces;

namespace Test.Data
{
    public static class Ioc
    {
        public static void IocDataRepositoryInstall(this IServiceCollection services)
        {
            services.AddTransient<IUserDataRepository, UserDataRepository>();
            services.AddTransient<ICompanyDataRepository, CompanyDataRepository>();
        }
    }
}
