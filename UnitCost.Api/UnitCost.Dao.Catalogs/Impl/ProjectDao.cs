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
    public class ProjectDao : BaseDao<BasicProjectDto>, IProjectDao
    {
        public ProjectDao(IOptions<ConfigurationDto> options) : base(options)
        {

        }
     }
}
