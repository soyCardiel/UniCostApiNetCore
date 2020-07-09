using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using UnitCost.Dao.Contract;
using UnitCost.Dto.Catalalogs;
using UnitCost.Dto.Common;

namespace UnitCost.Dao.Impl
{
    public class BaseDao : IBaseDao
    {
        private readonly ConfigurationDto Config;

        public BaseDao(IOptions<ConfigurationDto> config)
        {
            Config = config.Value;
        }

        public UserDto GetUser()
        {

            return new UserDto
            {
                Firstname = "Edgar",
                Lastname = "Cardiel"
            };
        }

        public long CreateEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public long CreateEntity<T>(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity<T>(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(object id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity<T>(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
