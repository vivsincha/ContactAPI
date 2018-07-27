using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Contacts.Repository
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(object Id);
        bool Insert(T obj);
        bool Delete(object Id);
        bool Update(T obj);
        bool Deactivate(object Id);
    }
}
