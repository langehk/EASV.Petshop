using System;
namespace EASV.PetShop.ConsoleApp
{
    public class Printer
    {
        readonly IPetService _PetService;

        public Printer (IPetService petService)
        {
            _PetService = petService;
            ShowAllPets();
        }



        private void ShowAllPets()
        {
            var listOfPets = _PetService.GetPets();
            foreach (var pet in listOfPets)
            {
                Console.WriteLine("Id: " + pet.Id + " Type: " + pet.Type);
            }
        }
    }
}
