using System;
using System.Collections.Generic;
using EASV.PetShop.Entities;

namespace PetShop
{
    public class Program
    {

        static int id = 1;
        static List<Pet> Pets = new List<Pet>();

        static void Main(string[] args)
        {
            var pet1 = new Pet()
            {
                Id = id++,
                Name = "Pippi",
                Type = "Dansk-Svensk gårdhund / Terrier",
                //BirthDate =03 / 05 / 2003 22:00:00 ,
                //SoldDate = 01 / 11 / 2004 17:00:00 ,
                Color = "Brown",
                PreviousOwner = "Abdi",
                Price = 3500,

            };
            Pets.Add(pet1);

            string[] menuItems = {
                "Show List of all choises",
                "Show list of all pets",
                "Search pet by type",
                "Create new pet",
                "Delete pet",
                "Update pet",
                "Sort pets by price",
                "Get 5 cheapest pets"

            };

            var selection = ShowMenu(menuItems);

            while (selection != 9)
            {
                switch (selection)
                {
                    case 1:
                        ShowListOfChoises();
                        break;
                    case 2:
                        ShowListOfAllPets();
                        break;
                    case 3:
                        FindPetByType();
                        break;
                    case 4:
                        CreateNewPet();
                        break;
                    case 5:
                        DeletePet();
                        break;
                    case 6:
                        UpdatePet();
                        break;
                    case 7:
                        SortPetsByPrice();
                        break;
                    case 8:
                        GetFiveCheapestPetsAvalible();
                        break;
                    case 9:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Woooof!");

            Console.ReadLine();
        }

        private static void GetFiveCheapestPetsAvalible()
        {
            throw new NotImplementedException();
        }

        private static void SortPetsByPrice()
        {
            throw new NotImplementedException();
        }

        private static void UpdatePet()
        {
            throw new NotImplementedException();
        }

        private static void DeletePet()
        {
            throw new NotImplementedException();
        }

        private static void CreateNewPet()
        {
            throw new NotImplementedException();
        }

        private static void FindPetByType()
        {
            throw new NotImplementedException();
        }

        private static void ShowListOfAllPets()
        {
            Console.WriteLine("\nList of Pets");
            foreach (var pet in Pets)
            {
                Console.WriteLine($"Id: {pet.Id} Name: {pet.Name} " +
                                  $" Type: {pet.Type} " + $" BirthDate: {pet.BirthDate}" + 
                                  $" SoldDate: {pet.SoldDate}" +
                                  $" Color: {pet.Color}" +
                                  $" PreviousOwner: {pet.PreviousOwner}" +
                                  $" Price: {pet.Price}"
                                 
                                 
                                 );
            }
            Console.WriteLine("\n");
        }



        private static void ShowListOfChoises()
        {
            throw new NotImplementedException();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 9)
            {
                Console.WriteLine("Please select a number between 1-9");
            }

            return selection;
        }




    }
}
