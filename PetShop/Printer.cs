﻿using System;
using EASV.PetShop.Core.ApplicationService;
using System.Collections.Generic;
using System.Text;

namespace EASV.PetShop.ConsoleApp
{
    public class Printer
    {
        readonly IPetService _petService;

        public Printer (IPetService petService)
        {
            _petService = petService;
            ShowAllPets();
        }

        private void ShowAllPets()
        {
            var listOfPets = _petService.GetPets();
            foreach (var pet in listOfPets)
            {
                Console.WriteLine("Id: " + pet.Id + " Type: " + pet.Type);
            }
        }
    }
}
