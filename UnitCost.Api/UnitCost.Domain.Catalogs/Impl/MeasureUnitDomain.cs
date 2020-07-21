using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Domain.Catalogs.Contract;
using UnitCost.Domain.Impl;
using UnitCost.Dto.Catalalogs;

namespace UnitCost.Domain.Catalogs.Impl
{
    public class MeasureUnitDomain : BaseDomain, IMeasureUnitDomain
    {
        private readonly IMeasureUnitDao Dao;

        public MeasureUnitDomain(IServiceProvider provider) : base (provider)
        {
            Dao = GetDaoInstance<IMeasureUnitDao>();
        }

        public List<MeasureUnitDto> GetCatalogList()
        {
            try
            {
                return Dao.GetAll().ToList();
            } 
            catch
            {
                throw;
            }
        }
    }
}
