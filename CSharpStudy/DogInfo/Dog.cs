using System;
using System.Collections.Generic;
using System.Text;

namespace DogInfo
{
    public class Dog
    {

        #region Fields
        // Field
        private string name;
        private int age;
        #endregion

        #region Constroctor
        // Constructor
        public Dog(string name)
        {
            //name = string.Empty;
            this.name = name;
        }
        #endregion

        #region Properties
        // Property
        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}
        public string Name { get; set; }

        //public string Age
        //{
        //    get { return this.age; }
        //    set { this.age = value; }
        //}
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        #endregion

        #region Public Methods
        // method
        public string GetDogData()
        {
            string data = string.Format("Name: {0} Age: {1}",
                this.name, this.age);
            return data;
        }

        //public 

        #endregion
    }
}
