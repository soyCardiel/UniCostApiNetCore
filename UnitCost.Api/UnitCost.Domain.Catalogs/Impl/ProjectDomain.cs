using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Domain.Catalogs.Contract;
using UnitCost.Domain.Impl;
using UnitCost.Dto.Catalalogs;

namespace UnitCost.Domain.Catalogs.Impl
{
    public class ProjectDomain : BaseDomain, IProjectDomain
    {
        private readonly IProjectDao dao;
        public ProjectDomain(IServiceProvider provider) : base(provider)
        {
            dao = GetDaoInstance<IProjectDao>();
        }

        public List<BasicProjectDto> GetProjectList()
        {
            try
            {
                return dao.GetAll().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public BasicProjectDto CreateProject(BasicProjectDto model)
        {
            try
            {
                long id = dao.CreateEntity(model);
                model.Id = Convert.ToInt32(id);

                return model;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
