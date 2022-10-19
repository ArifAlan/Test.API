using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Interfaces;
using Test.Data.Models;

namespace Test.Data.Impl.Base
{
    public class UserDataRepository : DataRepository<User>, IUserDataRepository
    {
        public override async Task<User> GetDefaultAsync(long id)
        {
            return new User
            {
                Id = id,
                UserName = $"UserName{id}",
                Pass = $"Pass{id}"
            };
        }
    }
}
