using System;
namespace EASV.PetShop.Core.DomainService
{
    public interface IPetRepository
    {

        IEnumerable<Pet> ReadPets();

        PetShop CreatePet(PetShop pet);
    }
}
