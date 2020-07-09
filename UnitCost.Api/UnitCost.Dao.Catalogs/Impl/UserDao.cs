using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Dao.Impl;
using UnitCost.Dto.Catalalogs;
using UnitCost.Dto.Common;

namespace UnitCost.Dao.Catalogs.Impl
{
    public class UserDao : BaseDao<UserDto>, IUserDao
    {
        public UserDao(IOptions<ConfigurationDto> config) : base(config) { 
        }


    }
}
