using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Interfaces;
using Test.Data.Models;

namespace Test.Data.Impl.Base
{
    public class CompanyDataRepository : DataRepository<Company>, ICompanyDataRepository
    {
        public override async Task<Company> GetDefaultAsync(long id)
        {
            return new Company
            {
                Id = id,
                Name = $"Name{id}",
                Code = $"Code{id}",
                Title = $"Title{id}",
                TaxNumber = $"TaxNumber{id}"
            };
        }
    }
}
