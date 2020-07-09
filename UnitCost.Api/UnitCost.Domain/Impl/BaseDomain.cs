using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.Domain.Contract;

namespace UnitCost.Domain.Impl
{
    public class BaseDomain : IBaseDomain
    {
        private readonly IServiceProvider serviceProvider;

        public BaseDomain(IServiceProvider provider)
        {
            serviceProvider = provider;
        }

        public T GetDaoInstance<T>()
        {
            return serviceProvider.GetService<T>();
        }

    }
}
