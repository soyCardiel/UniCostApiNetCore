using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Domain.Catalogs.Contract;
using UnitCost.Domain.Impl;
using UnitCost.Dto.Catalalogs;

namespace UnitCost.Domain.Catalogs.Impl
{
    public class UserDomain: BaseDomain, IUserDomain
    {
        private readonly IUserDao dao;
        public UserDomain(IServiceProvider provider): base(provider)
        {
            dao = GetDaoInstance<IUserDao>();
        }

        public UserDto GetUser()
        {
            return dao.GetById(1);
        }
    }
}
