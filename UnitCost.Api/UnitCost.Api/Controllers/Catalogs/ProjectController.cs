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
    public class ProjectController : BaseController
    {
        private readonly IProjectDomain domain;
        public ProjectController(IServiceProvider provider) : base (provider)
        {
            domain = GetDomainInstance<IProjectDomain>();
        }

        [HttpGet("GetBasicProjects")]
        [Produces(typeof(List<BasicProjectDto>))]
        public List<BasicProjectDto> GetBasicProjects()
        {
            return domain.GetProjectList();
        }

        [HttpPost("CreateBasicProject")]
        [Produces(typeof(BasicProjectDto))]
        public BasicProjectDto CreateBasicProject(BasicProjectDto model)
        {
            return domain.CreateProject(model);
        }
    }
}
