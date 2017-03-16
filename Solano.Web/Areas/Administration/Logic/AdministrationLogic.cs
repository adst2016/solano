using Infrastructure.Shared.Components;
using Solano.Web.Areas.Administration.Models.Repositories;
using System;

namespace Solano.Web.Areas.Administration.Logic
{
    public interface IAdministrationLogic : ILogic
    {
        Guid GetId(string name);
    }

    public class AdministrationLogic : IAdministrationLogic
    {
        private readonly ITestRepository testRepository;

        public AdministrationLogic(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }

        public Guid GetId(string name)
        {
            return this.testRepository.GetByName(name);
        }
    }
}