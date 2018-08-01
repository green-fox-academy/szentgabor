using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Macrotis.Models;

namespace Macrotis.Repositories
{
    public class AttractionRepository : IRepository<Attraction>
    {
        private AttractionContext attractionContext;

        public AttractionRepository(AttractionContext attractionContext)
        {
            this.attractionContext = attractionContext;
        }

        public void Create(Attraction element)
        {
            attractionContext.Add(element);
            attractionContext.SaveChanges();
        }

        public void Delete(Attraction element)
        {
            attractionContext.Remove(element);
            attractionContext.SaveChanges();
        }

        public List<Attraction> GetAllElements()
        {
            return attractionContext.Attractions.ToList();
        }

        public Attraction GetRecordById(long id)
        {
            return attractionContext.Attractions.ToList().FirstOrDefault(x => x.ID == id);
        }

        public void Update(Attraction element)
        {
            attractionContext.Update(element);
            attractionContext.SaveChanges();
        }
    }
}
