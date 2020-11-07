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
            int age;

            List<Dog> dogs = new List<Dog>();

            Console.WriteLine("============= Welcome to the Dog Information System =============");

            // List, Hashset, Queue, Stack

            //dogs.

            menu = "hello";

            ////////dog a = new dog("aa");

            //a.

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" A. All dogs data");
                Console.WriteLine(" B. Build a new dog data");
                Console.WriteLine(" C. Change a dog data");
                Console.WriteLine(" D. Display selected dog data");
                Console.WriteLine(" E. Exit the program");
                Console.Write("\n Select menu: ");

                menu = Console.ReadLine();

                switch (menu)
                {
                    case "A": case "a":
                        foreach (Dog dog in dogs)
                        {
                            Console.WriteLine("Name: {0} Age: {1}", dog.Name, dog.Age);
                        }
                        //Dog newDog = new Dog();
                        // add a new dog
                        break;

                    case "B": case "b":
                        Console.Write("    Name: ");
                        name = Console.ReadLine();

                        bool isExist = false;

                        // check if the dog is already in the list
                        foreach (Dog dog in dogs)
                        {
                            if (dog.Name == name)
                            {
                                Console.WriteLine("The dog \"{0}\" is already  exist. Stopped", name);
                                isExist = true;
                                break;
                            }
                        }

                        

                        if (isExist) continue;

                        Console.Write("    Age: ");
                        age = int.Parse(Console.ReadLine());

                        Dog newDog = new Dog(name );

                        newDog.Age = age;

                        dogs.Add(newDog);

                        // edit dog 
                        break;

                    case "C": case "c":
                        // display data
                        
                        break;

                    case "D": case "d":
                        Console.Write("Enter dog name: ");
                        name = Console.ReadLine();
                        foreach (Dog dog in dogs)
                        {
                            if (name == dog.Name)
                            {
                                Console.Write("Enter dog new age: ");
                                age = int.Parse(Console.ReadLine());
                            }
                            

                        }
                        break;

                    case "E": case "e":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid menu selected: {0}", menu);
                        break;
                }

            } // while
        } // main
    }
}
