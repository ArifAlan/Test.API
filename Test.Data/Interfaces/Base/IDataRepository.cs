using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Models.Base;

namespace Test.Data.Interfaces.Base
{
    public interface IDataRepository<T> where T : Audit
    {
        Task<T> GetByIdAsync(long id);

        Task<bool> InsertAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<DateTime> GetServerDateAsync();
    }
}
