using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string streetAddress = "";
            string city = "";
            string postalCode = "";
            string province = "";
            string country = "";
            string phoneNo = "";
            string collegeEmail = "";
            string fullName = "";
            string address = "";
            string yesOrNo = "";

            int age = 0;
            double balance = 0.0;
            int studentNo = 0;

            Console.WriteLine("Enter Your Information");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*            do
                        {
                            Console.Write("  First Name: ");
                            firstName = Console.ReadLine();
                            Console.Write("You entered \"" + firstName + "\"." + "Is that right? (y/n): ");
                            yesOrNo = Console.ReadLine();
                            if (yesOrNo.StartsWith("y", "Y"))
                            {

                            }

                        } while (true);*/

            Console.Write("  Last Name: ");
            lastName = Console.ReadLine();
            // string.split
            // if ()
            // is alpha // // // //

            Console.Write("  Age: ");
            age = int.Parse(Console.ReadLine());
            //int.TryParse

            Console.Write("  Bank Balance: ");
            balance = double.Parse(Console.ReadLine());

            Console.Write("  Student Number: ");
            studentNo = int.Parse(Console.ReadLine());

            Console.Write("  Street Address: ");
            streetAddress = Console.ReadLine();

            Console.Write("  City: ");
            city = Console.ReadLine();

            Console.Write("  postalCode: ");
            postalCode = Console.ReadLine();

            Console.Write("  Province: ");
            province = Console.ReadLine();

            Console.Write("  Country: ");
            country = Console.ReadLine();

            Console.Write("Cell Phone Number: ");
            phoneNo = Console.ReadLine();

            Console.Write("College Email: ");
            collegeEmail = Console.ReadLine();

            fullName = firstName + " " + lastName;
            address = streetAddress + " " + city + " " + postalCode + " " + province + " " + country;

            Console.WriteLine("\nYour name is " + fullName + " and you are " + age + " years old");
            Console.WriteLine("Your address is " + address);
            Console.WriteLine("Your cell phone number is " + phoneNo);
            Console.WriteLine("Your student No is " + studentNo + " and email is " + collegeEmail);
            Console.WriteLine("Your Balance is " + balance);
            Console.ReadKey();
        }
    }
}
