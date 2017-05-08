using Infrastructure.DataBase.Repositories;
using Infrastructure.Fundamental.ServiceBase;
using Solano.Web.Areas.Administration.Models.MappingServices;
using Solano.Web.Areas.Main.Models.DTO;
using Solano.Web.Areas.Main.Models.Entities;

namespace Solano.Web.Areas.Main.Services
{
    public interface IFormTypeService
        : IServiceCrudBase<FormType, FormTypeInfoDto, FormTypeCreateDto>
    {
    }

    public class FormTypeService : ServiceCrudBase<FormType, FormTypeInfoDto, FormTypeCreateDto>, IFormTypeService
    {
        public FormTypeService(IRepository<FormType> repository,
            IMapping<FormType, FormTypeInfoDto, FormTypeCreateDto> mapping) : base(repository, mapping)
        {
            
        }
    }
}