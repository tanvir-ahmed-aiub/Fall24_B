using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductRepo : Repo, IRepo<Product, int, bool>
    {
        public bool Create(Product obj)
        {
            db.Products.Add(obj);
            return db.SaveChanges() > 0;
        }

        public void Delete(int id)
        {
            var ex = Get(id);
            db.Products.Remove(ex);
            db.SaveChanges();
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        public bool Update(Product obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
