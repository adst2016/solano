﻿using Infrastructure.DataBase.Entities;

namespace Solano.Web.Areas.Administration.Models.Entities
{
    public class Test : EntityWithDescriptionBase
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}