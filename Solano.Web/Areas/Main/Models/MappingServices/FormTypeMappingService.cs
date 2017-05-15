using Infrastructure.Fundamental.MappingServiceBase;
using Solano.Web.Areas.Main.Models.DTO;
using Solano.Web.Areas.Main.Models.Entities;

namespace Solano.Web.Areas.Main.Models.MappingServices
{
    public class FormTypeMappingService : IMapping<FormType, FormTypeInfoDto, FormTypeCreateDto>
    {
        public FormTypeInfoDto MapToInfoDto(FormType Entity)
        {
            return FormTypeInfoDto.Create(Entity.Id, Entity.Code, Entity.Name, Entity.Description, Entity.Notes, Entity.NumberColumns);
        }

        public FormType MapToEntity(FormType entity, FormTypeInfoDto dtoInfo)
        {
            entity.Code = dtoInfo.Code;
            entity.Name = dtoInfo.Name;
            entity.Description = dtoInfo.Description;
            entity.Notes = dtoInfo.Notes;
            entity.NumberColumns = dtoInfo.NumberColumns;

            return entity;
        }

        public FormType MapToNewEntity(FormTypeCreateDto dtoCreate)
        {
            return new FormType
            {
                Code = dtoCreate.Code,
                Name = dtoCreate.Name,
                Description = dtoCreate.Description,
                Notes = dtoCreate.Notes,
                NumberColumns = dtoCreate.NumberColumns
            };
        }
    }
}