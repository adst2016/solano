using Infrastructure.DataBase.Repositories;
using Solano.Web.Areas.Administration.Models.Entities;
using System;

namespace Solano.Web.Areas.Administration.Models.Repositories
{
    public interface ITestRepository : IRepository<Person, Guid>
    {
        Guid GetByName(string name);
    }

    public class TestRepository : RepositoryBase<Person, Guid>, ITestRepository
    {
        public Guid GetByName(string name)
        {
            Person person = this.Session.CreateQuery("from Person as person where person.Name = '" + name + "'").UniqueResult<Person>();

            return person.Id;            
        }
    }
}