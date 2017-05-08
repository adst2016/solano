using Infrastructure.DataBase.Entities;

namespace Solano.Web.Areas.Main.Models.Entities
{
    public class Panel : EntityWithDescriptionBase
    {
        public virtual Form Form { get; set; }

        public virtual int ColumnNo { get; set; }
        public virtual int OrderInForm { get; set; }
    }
}