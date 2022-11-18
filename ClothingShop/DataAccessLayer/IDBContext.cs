using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal interface IDBContext<T> where T : BaseClothing
    {
        void Create(T item);
        T? Get(string key);
        ICollection<T>? GetAll();
        void Update(T item);
        void Delete(string key);
    }
}
