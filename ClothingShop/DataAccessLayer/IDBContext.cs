using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal interface IDBContext<T, K> where T : BaseClothing where K : IConvertible
    {
        void Create(T item);
        T? Get(K key);
        ICollection<T>? GetAll();
        void Update(T item);
        void Delete(K key);
    }
}
