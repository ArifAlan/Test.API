using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Interfaces;
using Test.Data.Models;
using Test.Modules.Interfaces;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.Modules.Modules
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDataRepository _companyDataRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyDataRepository companyDataRepository, IMapper mapper)
        {
            _companyDataRepository = companyDataRepository;
            _mapper = mapper;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var dbCompany = await _companyDataRepository.GetByIdAsync(id);
            if (dbCompany == null)
            {
                throw new Exception("CompanyNotFoundForDelete");
            }
            return await _companyDataRepository.DeleteAsync(dbCompany);
        }

        public async Task<GetCompanyResponseModel> GetByIdAsync(long id)
        {
            var dbCompany = await _companyDataRepository.GetByIdAsync(id);
            if (dbCompany == null)
            {
                throw new Exception("CompanyNotFound");
            }

            return _mapper.Map<GetCompanyResponseModel>(dbCompany);
        }

        public async Task<long> InsertAsync(InsertUpdateCompanyRequestModel request)
        {
            var dbCompany = new Company();
            return await InsertUpdateCompanyAsync(dbCompany, request);
        }

        public async Task<long> UpdateAsync(long id, InsertUpdateCompanyRequestModel request)
        {
            var dbCompany = await _companyDataRepository.GetByIdAsync(id);
            if (dbCompany == null)
            {
                throw new Exception("CompanyNotFoundForUpdate");
            }
            return await InsertUpdateCompanyAsync(dbCompany, request);
        }

        private async Task<long> InsertUpdateCompanyAsync(Company company, InsertUpdateCompanyRequestModel request)
        {

            company = _mapper.Map(request, company);
            if (company.Id > 0)
            {
                await _companyDataRepository.UpdateAsync(company);
            }
            else
            {
                await _companyDataRepository.InsertAsync(company);
            }

            return company.Id;
        }
    }
}
