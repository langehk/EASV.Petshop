using System;
using System.Collections.Generic;
using EASV.PetShop.Entities;

namespace EASV.PetShop.Infrastructure.Data
{
    public interface PetRepository; IPetRepository 
    {
        IEnumerable<Pet> ReadPets();
        {
            return null;
        }

        public Pet CreatePet (Pet pet)
        {

    pet.Id = FakeDB.PetId++;
    var pets = FakeDB.Pets.ToList();
    pets.Add(Pet);
    FakeDB.Pets = pets;
    return pet;
        }
    }
}
