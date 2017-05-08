using System;
using Infrastructure.Fundamental.DtoBase;

namespace Solano.Web.Areas.Main.Models.DTO
{
    public class FormTypeCreateDto : DtoCreateWithDescriptionBase
    {
        public int NumberColumns { get; set; }

        public FormTypeCreateDto()
        {
        }
    }
}