using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitCost.Domain.Catalogs.Contract;
using UnitCost.Dto.Catalalogs;

namespace UnitCost.Api.Controllers.Catalogs
{
    public class SingleCostCatalogController : BaseController
    {
        private readonly ISingleCostCatalogDomain Domain;

        public SingleCostCatalogController(IServiceProvider provider) : base (provider)
        {
            Domain = GetDomainInstance<ISingleCostCatalogDomain>();
        }

        [HttpGet("GetCatalogList")]
        [Produces(typeof(List<SingleCostCatalogDto>))]
        public List<SingleCostCatalogDto> GetCatalogList()
        {
            try {
                return Domain.GetCatalogList();
            }
            catch
            {
                throw;
            }
        }
    }
}