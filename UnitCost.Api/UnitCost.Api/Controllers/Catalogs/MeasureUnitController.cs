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
    public class MeasureUnitController : BaseController
    {
        private readonly IMeasureUnitDomain Domain;

        public MeasureUnitController(IServiceProvider provider) : base(provider)
        {
            Domain = GetDomainInstance<IMeasureUnitDomain>();
        }

        [HttpGet("GetCatalogList")]
        [Produces(typeof(List<MeasureUnitDto>))]
        public List<MeasureUnitDto> GetCatalogList()
        {
            try
            {
                return Domain.GetCatalogList();
            }
            catch
            {
                throw;
            }
        }
    }
}