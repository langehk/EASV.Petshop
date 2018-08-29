using System;
using System.Collections.Generic;
using System.Linq;
using EASV.PetShop.Core.ApplicationService;
using EASV.PetShop.Core.ApplicationService.Implementation;
using EASV.PetShop.Core.DomainService;
using EASV.PetShop.Entities;
using EASV.PetShop.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace PetShop
{
    public class Program
    {
        
        static void Main(String[] args)
        {
            FakeDB.InitData();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var petService = serviceProvider.GetRequiredService<IPetService>();
            new Printer(petService);

            Console.ReadLine();




            //        static int id = 1;
            //        static List<Pet> Pets = new List<Pet>();

            //        static void Main(string[] args)
            //        {
            //            var pet1 = new Pet()
            //            {
            //                Id = id++,
            //                Name = "Allan",
            //                Type = "Terrier",
            //                //BirthDate = new DateTime (2012, 00, 00),
            //                //SoldDate = new DateTime (2015, 01, 06),
            //                Color = "Brown",
            //                PreviousOwner = "Lars",
            //                Price = 3500,

            //            };
            //            Pets.Add(pet1);

            //            string[] menuItems = {
            //                "Show List of all choises",
            //                "Show list of all pets",
            //                "Search pet by type",
            //                "Create new pet",
            //                "Delete pet",
            //                "Update pet",
            //                "Sort pets by price",
            //                "Get 5 cheapest pets"

            //            };

            //            var selection = ShowMenu(menuItems);

            //            while (selection != 9)
            //            {
            //                switch (selection)
            //                {
            //                    case 1:
            //                        ShowListOfChoises();
            //                        break;
            //                    case 2:
            //                        ShowListOfAllPets();
            //                        break;
            //                    case 3:
            //                        FindPetByType();
            //                        break;
            //                    case 4:
            //                        CreateNewPet();
            //                        break;
            //                    case 5:
            //                        DeletePet();
            //                        break;
            //                    case 6:
            //                        UpdatePet();
            //                        break;
            //                    case 7:
            //                        SortPetsByPrice();
            //                        break;
            //                    case 8:
            //                        GetFiveCheapestPetsAvalible();
            //                        break;
            //                    case 9:
            //                        break;
            //                }
            //                selection = ShowMenu(menuItems);
            //            }
            //            Console.WriteLine("Woooof!");

            //            Console.ReadLine();
            //        }

            //        private static Pet FindPetById()
            //        {
            //            Console.WriteLine("Insert pet ID:");

            //            int id;

            //            while (!int.TryParse(Console.ReadLine(), out id))
            //            {
            //                Console.WriteLine("Insert a number:");
            //            }

            //            foreach (var pet in Pets)
            //            {
            //                if (pet.Id == id)
            //                {
            //                    return pet;
            //                }
            //            }
            //            return null;
            //        }


            //        private static void GetFiveCheapestPetsAvalible()
            //        {
            //            throw new NotImplementedException();
            //        }

            //        private static void SortPetsByPrice()
            //        {
            //            throw new NotImplementedException();
            //        }

            //        private static void UpdatePet()
            //        {
            //            var pet = FindPetById();

            //            Console.WriteLine("Name:");
            //            pet.Name = Console.ReadLine();

            //            Console.WriteLine("Type:");
            //            pet.Type = Console.ReadLine();

            //            //Console.WriteLine("BirthDate:");
            //            //pet.BirthDate = Console.ReadLine();

            //            //Console.WriteLine("SoldDate:");
            //            //pet.SoldDate = Console.ReadLine();

            //            Console.WriteLine("Color:");
            //            pet.Color = Console.ReadLine();

            //            Console.WriteLine("PreviousOwner:");
            //            pet.PreviousOwner = Console.ReadLine();

            //            //Console.WriteLine("Price:");
            //            //pet.Price = Console.ReadLine();

            //        }

            //        private static void DeletePet()
            //        {
            //            var petFound = FindPetById();
            //            if (petFound != null)
            //            {
            //                Pets.Remove(petFound);
            //            }
            //        }

            //        private static void CreateNewPet()
            //        {

            //            Console.WriteLine("Name:");
            //            var name = Console.ReadLine();

            //            Console.WriteLine("Type:");
            //            var type = Console.ReadLine();

            //            Console.WriteLine("BirthDate:");
            //            var birthDate = Console.ReadLine();

            //            Console.WriteLine("SoldDate:");
            //            var soldDate = Console.ReadLine();

            //            Console.WriteLine("Color:");
            //            var color = Console.ReadLine();

            //            Console.WriteLine("PreviousOwner:");
            //            var previousOwner = Console.ReadLine();

            //            Console.WriteLine("Price:");
            //            var price = Console.ReadLine();

            //                   Pets.Add(new Pet()
            //                   {
            //                Id = id++,
            //                Name = name,
            //                Type = type,
            //                //BirthDate = birthDate,
            //                //SoldDate = soldDate,
            //                Color = color,
            //                PreviousOwner = previousOwner,
            //                //Price = price

            //                   });
            //        }
            ////        ID: int
            ////Name: string
            ////Type: string or Enum
            ////Birthdate: DateTime
            ////SoldDate: DateTime
            ////Color: string
            ////PreviousOwner: string
            ////Price: double


            //public static void FindPetByType()
            //{
            //    Console.WriteLine("Insert pet type:");

            //    string myString = Console.ReadLine();


            //    Pets.Where(x => x.Type.Contains(myString)).ToList();
            //    var list = Pets.Where(x => x.Type.Contains(myString)).ToList();

            //    Console.WriteLine(list);
            //}

            //private static void ShowListOfAllPets()
            //{
            //    Console.WriteLine("\nList of Pets");
            //    foreach (var pet in Pets)
            //    {
            //        Console.WriteLine($"Id: {pet.Id} Name: {pet.Name} " +
            //                          $" Type: {pet.Type} " + $" BirthDate: {pet.BirthDate}" + 
            //                          $" SoldDate: {pet.SoldDate}" +
            //                          $" Color: {pet.Color}" +
            //                          $" PreviousOwner: {pet.PreviousOwner}" +
            //                          $" Price: {pet.Price}"


            //                         );
            //    }
            //    Console.WriteLine("\n");
            //}



            //private static void ShowListOfChoises()
            //{

            //}

            //private static int ShowMenu(string[] menuItems)
            //{
            //    Console.WriteLine("Select What you want to do:\n");

            //    for (int i = 0; i < menuItems.Length; i++)
            //    {
            //        //Console.WriteLine((i + 1) + ":" + menuItems[i]);
            //        Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            //    }

            //    int selection;
            //    while (!int.TryParse(Console.ReadLine(), out selection)
            //        || selection < 1
            //        || selection > 9)
            //    {
            //        Console.WriteLine("Please select a number between 1-9");
            //    }

            //    return selection;
            //}



        }
    }
}
