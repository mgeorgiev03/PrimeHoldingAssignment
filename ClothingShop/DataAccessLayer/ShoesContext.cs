using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ShoesContext : IDBContext<Shoes>
    {
        private Context context;
        public ShoesContext()
        {
            context = new Context();
        }

        public void Create(Shoes item)
        {
            context.Shoes.Add(item);
            context.SaveChanges();
        }

        public Shoes? Get(string key)
        {
            return context.Shoes.Find(key);
        }

        public ICollection<Shoes>? GetAll()
        {
            return context.Shoes as ICollection<Shoes>;
        }

        public void Update(Shoes item)
        {
            Shoes shoesInDb = context.Shoes.Find(item.Name);
            context.Entry(shoesInDb).CurrentValues.SetValues(item);
            context.SaveChanges();
        }

        public void Delete(string key)
        {
            context.Shoes.Remove(context.Shoes.Find(key));
            context.SaveChanges();
        }
    }
}
