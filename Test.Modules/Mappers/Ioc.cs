using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Modules.Mappers
{
    public static class Ioc
    {
        public static void IocMapperInstall(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserMapper());
                mc.AddProfile(new CompanyMapper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
