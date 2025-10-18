using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    internal class Car
    {
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        public Car()
        {
            
        }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public override string ToString() => $"{PetName} has speed of {CurrentSpeed} MPH";
    }
}
