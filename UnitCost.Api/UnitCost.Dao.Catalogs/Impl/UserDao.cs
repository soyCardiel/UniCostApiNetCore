using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Dao.Impl;
using UnitCost.Dto.Common;
using UnitCost.DBMigrations;

namespace UnitCost.Dao.Catalogs.Impl
{
    public class UserDao : BaseDao, IUserDao
    {
        public UserDao(IOptions<ConfigurationDto> config, UnitCostAppContext dbcontext) : base(config, dbcontext) { 
        }
    }
}
