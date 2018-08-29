using System;
using System.Collections.Generic;
using System.Text;
using EASV.PetShop.Entities;

namespace EASV.PetShop.Core.DomainService
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
       
    }
}
