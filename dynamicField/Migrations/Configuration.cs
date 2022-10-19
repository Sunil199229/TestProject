namespace dynamicField.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dynamicField.PL.Ankit_PracticeEntities11>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "dynamicField.PL.Ankit_PracticeEntities11";
        }

        protected override void Seed(dynamicField.PL.Ankit_PracticeEntities11 context)
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
        }
    }
}
