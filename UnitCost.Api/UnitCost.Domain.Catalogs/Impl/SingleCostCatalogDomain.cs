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
    public class SingleCostCatalogDomain : BaseDomain, ISingleCostCatalogDomain
    {
        private readonly ISingleCostCatalogDao Dao;

        public SingleCostCatalogDomain(IServiceProvider provider) : base (provider)
        {
            Dao = GetDaoInstance<ISingleCostCatalogDao>();
        }

        public List<SingleCostCatalogDto> GetCatalogList()
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
