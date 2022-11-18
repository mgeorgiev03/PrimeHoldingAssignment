using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrousersContext : IDBContext<Trousers>
    {
        private Context context;
        public TrousersContext()
        {
            context = new Context();
        }

        public void Create(Trousers item)
        {
            context.Trousers.Add(item);
            context.SaveChanges();
        }

        public Trousers? Get(string key)
        {
            return context.Trousers.Find(key);
        }

        public ICollection<Trousers>? GetAll()
        {
            return context.Trousers as ICollection<Trousers>;
        }

        public void Update(Trousers item)
        {
            Trousers trousersInDB = context.Trousers.Find(item);
            context.Entry(trousersInDB).CurrentValues.SetValues(item);
            context.SaveChanges();
        }

        public void Delete(string key)
        {
            context.Trousers.Remove(context.Trousers.Find(key));
            context.SaveChanges();
        }
    }
}
