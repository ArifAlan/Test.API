using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data.Interfaces.Base;
using Test.Data.Models.Base;

namespace Test.Data.Impl
{
    public abstract class DataRepository<T> : IDataRepository<T> where T : Audit
    {         
        #region Const.

        public DataRepository()
        {
        }

        #endregion

        #region Insert
        public async Task<bool> InsertAsync(T entity)
        {
            // insert 
            return true;
        }

        #endregion

        #region Update

        public async Task<bool> UpdateAsync(T entity)
        {
            // update 
            return true;

        }

        #endregion

        #region Get

        public async Task<T> GetByIdAsync(long id)
        {
            return await GetDefaultAsync(id);
        }

        #endregion

        #region Delete

        public async Task<bool> DeleteAsync(T entity)
        {
            // delete
            return true;

        }

        #endregion        

        #region Get Server Date

        public async Task<DateTime> GetServerDateAsync()
        {
            return DateTime.Now;
        }

        #endregion

        #region Overrideable Methods

        public virtual async Task<T> GetDefaultAsync(long id)
        {
            return default;
        }

        #endregion
    }
}
