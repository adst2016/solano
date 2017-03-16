using Infrastructure.Shared.Components;
using Solano.Web.Areas.Administration.Models.Entities;
using Infrastructure.DataBase.Repositories;
using Solano.Web.Areas.Administration.Logic;
using System;

namespace Solano.Web.Areas.Administration.Services
{
    public interface IAdministrationService : IService
    {
        string GetName(Guid Id);
    }

    public class AdministrationService : IAdministrationService
    {
        private readonly IRepository<Test, Guid> repositoryTest;
        private readonly IRepository<Person, Guid> repositoryPerson;

        private readonly IAdministrationLogic administrationLogic;

        public AdministrationService(
            IRepository<Test, Guid> repositoryTest,
            IRepository<Person, Guid> repositoryPerson,
            IAdministrationLogic administrationLogic)
        {
            this.repositoryTest = repositoryTest;
            this.repositoryPerson = repositoryPerson;
            this.administrationLogic = administrationLogic;
        }

        public string GetName(Guid Id)
        {
            Guid guid = new Guid("7AE8606A-8085-43B6-A39D-A738014A71E0");

            Person person2 = this.repositoryPerson.GetById(guid);

            person2.Name = "Natalia";
            repositoryPerson.SaveOrUpdateAndFlush(person2);

            return "";

            //Person person2 = new Person()
            //{
            //    Name = "Adam",
            //    Description = "coś fajnego",
            //    Notes = "bleble"
            //};

            //this.repositoryPerson.SaveOrUpdateAndFlush(person2);            

            //Test testEntity = this.repositoryTest.GetById(person2.Id);
            //Person personEntity = this.repositoryPerson.GetById(person2.Id);
            //Guid id = this.administrationLogic.GetId(personEntity.Name);

            //return testEntity.Name + " " + personEntity.Name + " " + id;
        }
    }
}