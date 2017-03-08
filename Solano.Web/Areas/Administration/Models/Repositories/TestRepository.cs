using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Infrastructure.DataBase.Repositories;
using Solano.Web.Areas.Administration.Models.Entities;

namespace Solano.Web.Areas.Administration.Models.Repositories
{
    public class TestRepository : RepositoryBase<Test>
    {
        public TestRepository(global::NHibernate.ISession session) : base(session)
        {
        }
    }
}