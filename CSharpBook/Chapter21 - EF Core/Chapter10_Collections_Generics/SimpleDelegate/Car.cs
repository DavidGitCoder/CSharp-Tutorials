using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    internal class Car
    {
        public int CurrentSpeed { get; set; } = 0;
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; } = "";
        private bool _carIsDead;

        private CarEngineHandler _listOfHandlers;

        public Car()
        {

        }
        public Car(string name, int maxSp, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
            MaxSpeed = maxSp;
        }

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }

        public void UnregisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine($"Current speed = {CurrentSpeed}");
                }
            }
        }

        public delegate void CarEngineHandler(string msgForCaller);

        public override string ToString() => $"{PetName} has speed of {CurrentSpeed} MPH";
    }
}
