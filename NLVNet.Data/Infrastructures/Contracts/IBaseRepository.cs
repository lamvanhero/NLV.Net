using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLVNet.Data.Infrastructures.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        TEntity Delete(TEntity entity);

        TEntity Delete(long id);

        void DeleteMulti(Expression<Func<TEntity, bool>> where);

        TEntity GetSigleById(long id);

        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where, string includes);


        int Count(Expression<Func<TEntity, bool>> where);

        IEnumerable<TEntity> GetAll(string[] includes = null);

        TEntity GetSingleByCondition(Expression<Func<TEntity, bool>> expression, string[] includes = null);

        IEnumerable<TEntity> GetMulti(Expression<Func<TEntity, bool>> predicate,
            string[] includes = null);

        IEnumerable<TEntity> GetMultiPaging(Expression<Func<TEntity, bool>> predicate, out int total,
            int index = 0, int size = 20, string[] includes = null);

        bool CheckContains(Expression<Func<TEntity, bool>> predicate);
    }
}
