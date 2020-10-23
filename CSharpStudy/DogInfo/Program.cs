using System;
using System.Collections.Generic;

namespace DogInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            string name;
            string breed;
            int sex;

            List<Dog> Dogs = new List<Dog>();

            Console.WriteLine("Welcome to the Dog Information System");

            // List, Hashset, Queue, Stack


            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("A. Display the name, breed, colour, and sex of the doay");
                Console.WriteLine("B. Add a new dog");
                Console.WriteLine("C. Edit an existing dog");
                Console.WriteLine("D. Display data from class");
                Console.WriteLine("E. Exit the program");
                Console.Write("\nSelect menu: ");

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "A": case "a":
                        foreach (Dog dog in Dogs)
                        {
                            Console.WriteLine("Name: {0} Breed: {1} Sex: {2}", dog.Name, dog.Breed, dog.Sex);
                        }
                        //Dog newDog = new Dog();
                        // add a new dog
                        break;

                    case "B": case "b":
                        //Console.Write("Name: ");

                        //name = Console.ReadLine();
                        //newDog.Name = name;

                        Dog newDog = new Dog();

                        Console.Write("Name: ");

                        name = Console.ReadLine();
                        newDog.Name = name;

                        Console.Write("Breed: ");
                        breed = Console.ReadLine();
                        newDog.Breed = breed;

                        //Console.Write("Colour: ");
                        //colour = Console.ReadLine();

                        Console.Write("Sex 1: female, 2: male: ");
                        sex = int.Parse(Console.ReadLine());
                        newDog.Sex = sex;

                        Dogs.Add(newDog);

                        // edit dog 
                        break;

                    case "C": case "c":
                        // display data
                        
                        break;

                    case "D": case "d":
                        break;

                    case "E": case "e":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid menu: {0}", menu);
                        break;
                }

            } // while
        } // main
    }
}
