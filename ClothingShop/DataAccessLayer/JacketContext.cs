using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class JacketContext : IDBContext<Jacket>
    {
        private Context context;
        public JacketContext()
        {
            context = new Context();
        }

        public void Create(Jacket item)
        {
            context.Jackets.Add(item);
            context.SaveChanges();
        }

        public Jacket? Get(string key)
        {
            return context.Jackets.Find(key);
        }

        public ICollection<Jacket>? GetAll()
        {
            return context.Jackets as ICollection<Jacket>;
        }

        public void Update(Jacket item)
        {
            Jacket jacketInDb = context.Jackets.Find(item.Name);
            context.Entry(jacketInDb).CurrentValues.SetValues(item);
            context.SaveChanges();
        }

        public void Delete(string key)
        {
            context.Jackets.Remove(context.Jackets.Find(key));
            context.SaveChanges();
        }
    }
}
