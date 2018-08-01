using Macrotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Macrotis.Repositories;

namespace Macrotis.Services
{
    public class AttractionServices
    {
        private IRepository<Attraction> attractionRepository;

        public AttractionServices(IRepository<Attraction> attractionRepository) 
        {
            this.attractionRepository = attractionRepository;
        }

        //public List<Attraction> ReturnFilteredAttractions(string category, string city)
        //{
        //    IEnumerable<Attraction> filteredAttractions = (isActive == true) ?
        //                                      (GetAttractions().Where(x => x.IsDone == false)) :
        //                                      (GetAttractions());
        //    return filteredAttractions.ToList();
        //}

        public void CreateAttraction(Attraction attraction)
        {
            attractionRepository.Create(attraction);
        }

        public Attraction GetAttractionById(long id)
        {
            return attractionRepository.GetRecordById(id);
        }

        public List<Attraction> GetAttractions()
        {
            return attractionRepository.GetAllElements();
        }

        public void RemoveAttraction(long id)
        {
            attractionRepository.Delete(attractionRepository.GetRecordById(id));
        }

        public void UpdateAttraction(Attraction attraction)
        {
            attractionRepository.Update(attraction);
        }
    }
}
