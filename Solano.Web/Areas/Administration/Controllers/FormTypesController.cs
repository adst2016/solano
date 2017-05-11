using Infrastructure.Fundamental.ControllerBase;
using Solano.Web.Areas.Main.Models.DTO;
using Solano.Web.Areas.Main.Models.Entities;
using Solano.Web.Areas.Main.Services;

namespace Solano.Web.Areas.Administration.Controllers
{
    public class FormTypesController : AppCrudControllerBase<FormType, FormTypeInfoDto, FormTypeCreateDto, IFormTypeService>
    {
        public FormTypesController(IFormTypeService service) : base(service)
        {
        }
    }    
}