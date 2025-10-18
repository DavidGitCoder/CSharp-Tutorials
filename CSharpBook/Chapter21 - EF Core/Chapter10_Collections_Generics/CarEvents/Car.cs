namespace CarEvents;
public class Car
{
    //delegate
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;
    //

    public int CurrentSpeed { get; set; } = 0;
    public int MaxSpeed { get; set; } = 100;
    public string PetName { get; set; } = "";
    private bool _carIsDead;

    public Car()
    {

    }
    public Car(string name, int maxSp, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
        MaxSpeed = maxSp;
    }

    public void Accelerate(int delta)
    {
        if (_carIsDead)
        {
            Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
        }
        else
        {
            CurrentSpeed += delta;

            if (10 == (MaxSpeed - CurrentSpeed))
            {
                AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
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

    public override string ToString() => $"{PetName} has speed of {CurrentSpeed} MPH";

}