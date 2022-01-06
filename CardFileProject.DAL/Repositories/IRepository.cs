using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Create(T item);

        T GetById(int id);

        T Update(T item);

        bool Delete(T item);
    }
}