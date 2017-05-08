using Infrastructure.Fundamental.DtoBase;
using System;

namespace Solano.Web.Areas.Main.Models.DTO
{
    public class FormTypeUpdateDto : DtoUpdateWithDescriptionBase
    {
        public int NumberColumns { get; set; }

        public FormTypeUpdateDto()
        {
        }

        private FormTypeUpdateDto(Guid id, string code, string name, string description, string notes, int numberColumns) 
            : base(id, code, name, description, notes)
        {
            NumberColumns = numberColumns;
        }

        public static FormTypeUpdateDto Create(Guid id, string code, string name, string description, string notes, int numberColumns)
        {
            return new FormTypeUpdateDto(id, code, name, description, notes, numberColumns);
        }
    }
}