using Microsoft.AspNetCore.Mvc;
using Test.Modules.Interfaces;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.API.Controllers
{
    [Route("api/v1/company")]
    public class CompanyController : Controller
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

     
        [HttpPost()]
        public async Task<long> InsertAsync([FromBody] InsertUpdateCompanyRequestModel request)
        {
            return await _companyService.InsertAsync(request);
        }
        

      
        [HttpPut("{id:long}")]
        public async Task<long> UpdateAsync([FromBody] InsertUpdateCompanyRequestModel request, [FromRoute] long id)
        {
            return await _companyService.UpdateAsync(id, request);
        }
      

       

        [HttpDelete("{id:long}")]
        public async Task<bool> DeleteAsync([FromRoute] long id)
        {
            return await _companyService.DeleteAsync(id);
        }

      

        [HttpGet("{id:long}")]
        public async Task<GetCompanyResponseModel> GetAsync([FromRoute] long id)
        {
            return await _companyService.GetByIdAsync(id);
        }

      
    }
}
