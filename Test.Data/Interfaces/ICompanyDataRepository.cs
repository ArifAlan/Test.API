using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Interfaces.Base;
using Test.Data.Models;

namespace Test.Data.Interfaces
{
    public interface ICompanyDataRepository: IDataRepository<Company>
    {
    }
}
