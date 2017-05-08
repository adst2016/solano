using Infrastructure.DataBase.Entities;

namespace Solano.Web.Areas.Main.Models.Entities
{
    public class FormType : EntityWithDescriptionBase
    {
        public virtual int NumberColumns { get; set; }
    }
}