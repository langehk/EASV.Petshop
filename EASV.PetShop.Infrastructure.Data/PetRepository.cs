using System.Collections.Generic;
using EASV.PetShop.Core.DomainService;
using EASV.Core.Entity;
using EASV.PetShop.Entities;

namespace EASV.PetShop.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        public IEnumerable<Pet> ReadPets()
        {
            return FakeDB.Pets;
        }
    }
}
