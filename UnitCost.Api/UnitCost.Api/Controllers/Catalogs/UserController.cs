using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitCost.Domain.Catalogs.Contract;

namespace UnitCost.Api.Controllers.Catalogs
{
    public class UserController : BaseController
    {
        private readonly IUserDomain domain;

        public UserController(IServiceProvider provider) : base(provider)
        {
            domain = GetDomainInstance<IUserDomain>();
        }

    }
}