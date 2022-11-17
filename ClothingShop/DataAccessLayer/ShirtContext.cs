using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ShirtContext : IDBContext<Shirt, string>
    {
        private Context context;
        public ShirtContext()
        {
            context = new Context();
        }

        public void Create(Shirt item)
        {
            context.Shirts.Add(item);
            context.SaveChanges();
        }

        public Shirt Get(string key)
        {
            return context.Shirts.Find(key);
        }

        public ICollection<Shirt>? GetAll()
        {
            return context.Shirts as ICollection<Shirt>;
        }

        public void Update(Shirt item)
        {
            Shirt shirtInDb = context.Shirts.Find(item.Name);
            context.Entry(shirtInDb).CurrentValues.SetValues(item);
            context.SaveChanges();
        }

        public void Delete(string key)
        {
            context.Shirts.Remove(context.Shirts.Find(key));
            context.SaveChanges();
        }
    }
}
