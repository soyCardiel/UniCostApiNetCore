using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using UnitCost.Dao.Contract;
using UnitCost.Dto.Catalalogs;
using UnitCost.Dto.Common;

namespace UnitCost.Dao.Impl
{
    public class BaseDao<TEntity> : IBaseDao<TEntity> where TEntity : class
    {
        private readonly ConfigurationDto Config;

        public BaseDao(IOptions<ConfigurationDto> config)
        {
            Config = config.Value;
        }

        private IEnumerable<T> ExecSp<T>(string storedProcedure, object parameters)
        {
            string connectionString = Config.DatabaseConnection;
            IEnumerable<T> result = default ;

            if(!string.IsNullOrEmpty(storedProcedure))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    result = connection.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                }
            }

            return result;
        }

        protected IEnumerable<T> ExecuteStoredProcedure<T>(string storesProcedure, object parameters)
        {
            return ExecSp<T>(storesProcedure, parameters);
        }

        public long CreateEntity(TEntity entity)
        {
            string connectionString = Config.DatabaseConnection;
            long result = default;

            if(entity != null)
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Insert(entity);
                }
            }

            return result;
        }

        public long CreateEntities(IEnumerable<TEntity> entity)
        {
            string connectionString = Config.DatabaseConnection;
            long result = default;

            if (entity != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Insert(entity);
                }
            }

            return result;
        }

        public bool DeleteEntity(TEntity entity)
        {
            string connectionString = Config.DatabaseConnection;
            bool result = default;

            if (entity != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Delete(entity);
                }
            }

            return result;
        }

        public bool DeleteEntity(IEnumerable<TEntity> entity)
        {
            string connectionString = Config.DatabaseConnection;
            bool result = default;

            if (entity != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Delete(entity);
                }
            }

            return result;
        }

        public IEnumerable<TEntity> GetAll()
        {
            string connectionString = Config.DatabaseConnection;
            IEnumerable<TEntity> result = default;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                result = connection.GetAll<TEntity>();
            }

            return result;
        }

        public TEntity GetById(object id)
        {
            string connectionString = Config.DatabaseConnection;
            TEntity result = default;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                result = connection.Get<TEntity>(id);
            }

            return result;
        }

        public bool UpdateEntity(TEntity entity)
        {
            string connectionString = Config.DatabaseConnection;
            bool result = default;

            if (entity != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Update(entity);
                }
            }

            return result;
        }

        public bool UpdateEntity(IEnumerable<TEntity> entity)
        {
            string connectionString = Config.DatabaseConnection;
            bool result = default;

            if (entity != null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = connection.Update(entity);
                }
            }

            return result;
        }
    }
}
