using Macrotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Repositories
{
    public interface IRepository<Attraction>
    {
        void Create(Attraction element);
        List<Attraction> GetAllElements();
        void Update(Attraction element);
        Attraction GetRecordById(long id);
        void Delete(Attraction element);
    }
}
