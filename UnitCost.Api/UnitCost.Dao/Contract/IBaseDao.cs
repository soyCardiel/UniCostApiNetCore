using System;
using System.Collections.Generic;
using System.Text;

namespace UnitCost.Dao.Contract
{
    public interface IBaseDao<TEntity>
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();

        long CreateEntity(TEntity entity);
        bool UpdateEntity(TEntity entity);
        bool DeleteEntity(TEntity entity);

        long CreateEntities(IEnumerable<TEntity> entity);
        bool UpdateEntity(IEnumerable<TEntity> entity);
        bool DeleteEntity(IEnumerable<TEntity> entity);

    }
}
