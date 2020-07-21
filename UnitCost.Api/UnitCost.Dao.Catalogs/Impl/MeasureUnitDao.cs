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
    public class MeasureUnitDao : BaseDao<MeasureUnitDto>, IMeasureUnitDao
    {
        public MeasureUnitDao(IOptions<ConfigurationDto> options) : base(options)
        {

        }


    }
}
