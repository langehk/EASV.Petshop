using System;
using System.Collections.Generic;
using EASV.PetShop.Entities;
using System.Text;

namespace EASV.PetShop.Core.ApplicationService
{
    public interface IPetService
    {
        List<Pet> GetPets();
    }
}
