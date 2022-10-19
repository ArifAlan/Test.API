using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.Modules.Mappers
{
    public class CompanyMapper:Profile
    {
        public CompanyMapper()
        {
            CreateMap<InsertUpdateCompanyRequestModel, Company>().ForMember(x => x.CreatorUserId, opt => opt.Ignore())
                .ForMember(x => x.IsActive, opt => opt.Ignore())
                .ForMember(x => x.RowVersion, opt => opt.Ignore())
                .ForMember(x => x.CreateDate, opt => opt.Ignore())
                .ForMember(x => x.UpdateDate, opt => opt.Ignore())
                .ForMember(x => x.UpdaterUserId, opt => opt.Ignore())
                .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<Company, GetCompanyResponseModel>();
        }
    }
}
