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
    public class UserService : IUserService
    {
        #region Variables / DI Services

        private readonly IUserDataRepository _userDataRepository;

        private readonly IMapper _mapper;

        #endregion

        #region Const...

        public UserService(IUserDataRepository userDataRepository, IMapper mapper)
        {
            _userDataRepository = userDataRepository;
            _mapper = mapper;
        }

        #endregion

        #region Insert 

        public async Task<long> InsertAsync(InsertUpdateUserRequestModel request)
        {
            var dbUser = new User();
            return await InsertUpdateUserAsync(dbUser, request);
        }

        #endregion

        #region Get

        public async Task<GetUserResponseModel> GetByIdAsync(long id)
        {
            var dbUser = await _userDataRepository.GetByIdAsync(id);
            if (dbUser == null)
            {
                throw new Exception("UserNotFound");
            }

            return _mapper.Map<GetUserResponseModel>(dbUser);
        }

        #endregion

        #region Update 

        public async Task<long> UpdateAsync(long id, InsertUpdateUserRequestModel request)
        {
            var dbUser = await _userDataRepository.GetByIdAsync(id);
            if (dbUser == null)
            {
                throw new Exception("UserNotFoundForUpdate");
            }
            return  await InsertUpdateUserAsync(dbUser, request);
        }

        #endregion

        #region Delete

        public async Task<bool> DeleteAsync(long id)
        {
            var dbUser = await _userDataRepository.GetByIdAsync(id);
            if (dbUser == null)
            {
                throw new Exception("UserNotFoundForDelete");
            }
            return await _userDataRepository.DeleteAsync(dbUser);
        }

        #endregion

        #region Private Methods

        private async Task<long> InsertUpdateUserAsync(User user, InsertUpdateUserRequestModel request)
        {
            
            user = _mapper.Map(request, user);
            if (user.Id > 0)
            {
                await _userDataRepository.UpdateAsync(user);
            }
            else
            {
                await _userDataRepository.InsertAsync(user);
            }

            return user.Id ;
        }


        #endregion

    }
}
