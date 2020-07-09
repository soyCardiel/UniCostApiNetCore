using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitCost.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IServiceProvider serviceProvider;

        public BaseController(IServiceProvider provider)
        {
            serviceProvider = provider;
        }

        public T GetDomainInstance<T>()
        {
            return serviceProvider.GetService<T>();
        }
    }
}
