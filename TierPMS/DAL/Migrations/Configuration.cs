namespace DAL.Migrations
{
    using DAL.EF.Tables;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.PMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.PMSContext context)
        {
            var cats = new string[] {"C1","C2","C3","C4","C5" };
            //foreach (var item in cats) {
            //    Category ca = new Category() { Name= item};
            //    context.Categories.AddOrUpdate(ca);
            //}
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++) {
                var p = new Product() {
                    Name = "Pro" + i,
                    Qty = 20,
                    Price = 20.67,
                    CatId = rnd.Next(1,6)
                    
                };
                context.Products.Add(p);    
            }
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
