using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.Dto.Catalalogs;

namespace UnitCost.Domain.Catalogs.Contract
{
    public interface IUserDomain
    {
        UserDto GetUser();
    }
}
