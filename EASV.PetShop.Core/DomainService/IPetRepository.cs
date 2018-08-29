using System;
using System.Collections.Generic;
using System.Text;


namespace EASV.PetShop.Core.DomainService
{
    public interface IPetRepository
    {

        IEnumerable<Pet> ReadPets();
    }
}
