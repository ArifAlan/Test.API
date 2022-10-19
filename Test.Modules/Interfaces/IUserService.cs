using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.Modules.Interfaces
{
    public interface IUserService
    {
        Task<GetUserResponseModel> GetByIdAsync(long id);

        Task<long> InsertAsync(InsertUpdateUserRequestModel request);

        Task<long> UpdateAsync(long id,InsertUpdateUserRequestModel request);

        Task<bool> DeleteAsync(long id);


    }
}
