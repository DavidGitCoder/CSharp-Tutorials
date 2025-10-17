using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar;
internal class Car : IComparable
{

    public const int MaxSpeed = 100;
    public int CarId { get; init; }
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    private bool _carIsDead;
    private readonly Radio _theMusicBox = new Radio();
    public static IComparer SortByPetName => new PetNameComparer();

    public Car()
    {

    }
    public Car(string name, int speed, int id)
    {
        PetName = name;
        CurrentSpeed = speed;
        CarId = id;
    }
    public void CrankTunes(bool state)
    {
        _theMusicBox.TurnOn(state);
    }
    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Console.WriteLine($"{PetName} is out of order...");
        }
        else
        {
            CurrentSpeed += delta;
            if (CurrentSpeed >= MaxSpeed)
            {
                CurrentSpeed = 0;
                _carIsDead = true;
                throw new Exception($"{PetName} has overheated!");
            }

        }
        Console.WriteLine($"=> Current Speed = {CurrentSpeed}");
    }
    public override string ToString()
    {
        return $"Name : {PetName}, Id : {CarId}, Speed : {CurrentSpeed}";
    }

    int IComparable.CompareTo(object? obj)
    {
        if (obj is Car c)
        {
            return this.CarId.CompareTo(c.CarId);
        }
        throw new ArgumentException("Parameter is not a Car!");
    }

}
