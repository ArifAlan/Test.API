using Microsoft.AspNetCore.Mvc;
using Test.Modules.Interfaces;
using Test.Modules.Models.Requests;
using Test.Modules.Models.Responses;

namespace Test.API
{
    [Route("api/v1/user")]
    public class UserController : Controller
    {
        #region Variables / DI Services

        private readonly IUserService _userService;

        #endregion

        #region Const...

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region Insert Update

        [HttpPost()]
        public async Task<long> InsertAsync([FromBody] InsertUpdateUserRequestModel request)
        {
            return await _userService.InsertAsync(request);
        }

        [HttpPut("{id:long}")]
        public async Task<long> UpdateAsync([FromBody] InsertUpdateUserRequestModel request, [FromRoute] long id)
        {
            return await _userService.UpdateAsync(id, request);
        }

        #endregion

        #region Delete

        [HttpDelete("{id:long}")]
        public async Task<bool> DeleteAsync([FromRoute] long id)
        {
            return await _userService.DeleteAsync(id);
        }

        #endregion

        #region Get

        [HttpGet("{id:long}")]
        public async Task<GetUserResponseModel> GetAsync([FromRoute] long id)
        {
            return await _userService.GetByIdAsync(id);
        }

        #endregion
    }
}
