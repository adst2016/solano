using Infrastructure.Fundamental.DtoBase;
using System;

namespace Solano.Web.Areas.Main.Models.DTO
{
    public class FormTypeInfoDto : DtoInfoWithDescriptionBase
    {
        public int NumberColumns { get; set; }

        public FormTypeInfoDto()
        {
        }

        private FormTypeInfoDto(Guid id, string code, string name, string description, string notes, int numberColumns) 
            : base(id, code, name, description, notes)
        {
            NumberColumns = numberColumns;
        }

        public static FormTypeInfoDto Create(Guid id, string code, string name, string description, string notes, int numberColumns)
        {
            return new FormTypeInfoDto(id, code, name, description, notes, numberColumns);
        }
    }
}