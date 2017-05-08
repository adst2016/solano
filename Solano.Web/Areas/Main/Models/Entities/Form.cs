using Infrastructure.DataBase.Entities;

namespace Solano.Web.Areas.Main.Models.Entities
{
    public class Form : EntityWithDescriptionBase
    {
        public virtual FormType FormType { get; set; }
    }
}