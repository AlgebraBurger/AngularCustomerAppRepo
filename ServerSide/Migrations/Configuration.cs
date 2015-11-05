namespace CustomerApiServer.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerApiServer.Models.CrmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CustomerApiServer.Models.CrmDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //var customerList = new List<Customer>()
            //{
            //    new Customer { ID=1,FullName="Julius Bacosa", Email="juliusbacosa@gmail.com", DateCreated=DateTime.Parse("1983-10-29") },
            //    new Customer { ID=1,FullName="Anakin Skywalker", Email="anakinskywalker@gmail.com", DateCreated=DateTime.Parse("2015-10-10") },
            //    new Customer { ID=1,FullName="Obiwan Kinobi", Email="obiwankinubi@gmail.com", DateCreated=DateTime.Parse("2015-10-10") },                
            //    new Customer { ID=1,FullName="Ahsoka Tano", Email="ahsokatano@gmail.com", DateCreated=DateTime.Parse("2015-10-10") }
            //};
            //customerList.ForEach(x => context.Customers.Add(x));

        }
    }
}
