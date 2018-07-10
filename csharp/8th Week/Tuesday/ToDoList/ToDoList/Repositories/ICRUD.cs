using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Repositories
{
    public interface ICRUD<Type>
    {
        void Create(Type element);
        List<Type> GetAllElements();
        void Update(Type element);
        Type GetRecordById(long id);
        void Delete(Type element);
    }
}
