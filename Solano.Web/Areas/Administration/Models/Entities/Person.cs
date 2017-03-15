using Infrastructure.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solano.Web.Areas.Administration.Models.Entities
{
    public class Person : EntityWithDescriptionBase
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}