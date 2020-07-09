using System;
using System.Collections.Generic;
using System.Text;

namespace UnitCost.Dao.Contract
{
    public interface IBaseDao
    {
        T GetById<T>(object id);
        List<T> GetAll<T>();

        long CreateEntity<T>(T entity);
        bool UpdateEntity<T>(T entity);
        bool DeleteEntity<T>(T entity);

        long CreateEntity<T>(IEnumerable<T> entity);
        bool UpdateEntity<T>(IEnumerable<T> entity);
        bool DeleteEntity<T>(IEnumerable<T> entity);

    }
}
