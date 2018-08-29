using System;
using System.Collections.Generic;
using EASV.PetShop.Entities;
using EASV.PetShop.Core.DomainService;
using System.Linq;
using System.Text;

namespace EASV.PetShop.Core.ApplicationService.Implementation
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public List<Pet> GetPets()
        {
            return _petRepository.ReadPets().ToList();
        }

       
    }
}
