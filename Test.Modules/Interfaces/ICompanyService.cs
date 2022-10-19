using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.Modules.Interfaces
{
    public interface ICompanyService
    {
        Task<GetCompanyResponseModel> GetByIdAsync(long id);

        Task<long> InsertAsync(InsertUpdateCompanyRequestModel request);

        Task<long> UpdateAsync(long id, InsertUpdateCompanyRequestModel request);

        Task<bool> DeleteAsync(long id);
    }
}
