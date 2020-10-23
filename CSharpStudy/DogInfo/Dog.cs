using System;
using System.Collections.Generic;
using System.Text;

namespace DogInfo
{
    public class Dog
    {
        // Field
        private string name;
        private string breed;
        private string colour;
        int sex;

        // Constructor
        //public Dog(string name)
        //{
        //    //name = string.Empty;
        //    this.name = name;
        //}              

        // Property
        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}
        public string Name { get; set; }

        //public string Breed
        //{
        //    get { return this.breed; }
        //    set { this.breed = value; }
        //}
        public string Breed { get; set; }

        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }

        public int Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        // method
        public string GetDogData()
        {
            string data = string.Format("Name: {0} Breed: {1} Colour: {2} Sex: {3}",
                this.name, this.breed, this.colour, this.sex);
            return data;
        }
    }
}
