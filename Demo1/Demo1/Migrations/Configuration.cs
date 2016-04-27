namespace Demo1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Demo1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo1.Models.NumbersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Demo1.Models.NumbersContext";
        }

        protected override void Seed(Demo1.Models.NumbersContext context)
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
            NumbersModel n1 = new Models.NumbersModel()
            {
                Number = 700
            };
            var nlist = from x in context.Numbers
                        where x.Number == n1.Number
                        select x;
            var nlist2 = context.Numbers.Where(
                x => x.Number == n1.Number);
            if (nlist.Count() > 0)
            {
                n1 = nlist.First();
            }
            context.Numbers.AddOrUpdate(x => x.Id, n1);

        }
    }
}
