using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solano.Web.Migrations
{
    [Migration(1)]
    public class DataBaseMigration : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            //Alter.Column("Shelf_id").OnTable("Test").AsInt32().NotNullable();
            //Create.Index("index001").OnTable("Test").OnColumn("Id").Ascending();
        }

    }
}