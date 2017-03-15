using Infrastructure.Shared.Components;
using Solano.Web.Areas.Administration.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Infrastructure.DataBase.Repositories;

namespace Solano.Web.Areas.Administration.Services
{
    public interface IAdministrationService : IService
    {
        string GetName(int Id);
    }

    public class AdministrationService : IAdministrationService
    {
        private readonly IRepository<Test, int> repositoryTest;
        private readonly IRepository<Person, int> repositoryPerson;

        public AdministrationService(
            IRepository<Test, int> repositoryTest,
            IRepository<Person, int> repositoryPerson)
        {
            this.repositoryTest = repositoryTest;
            this.repositoryPerson = repositoryPerson;
        }

        public string GetName(int Id)
        {
            Test testEntity = this.repositoryTest.GetById(Id);
            Person personEntity = this.repositoryPerson.GetById(Id);

            return testEntity.Name + " " + personEntity.Name;
        }
    }
}