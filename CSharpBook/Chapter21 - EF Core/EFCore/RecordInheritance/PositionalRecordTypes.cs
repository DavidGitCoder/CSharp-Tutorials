using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RecordInheritance
{
    public record PositionalCar(string Make, string Model, string Color);
    public record PositionalMiniVan(string Make, string Model, string Color, int Seating):PositionalCar(Make, Model, Color);
    public record MotorCycle(string Make, string Model);
    public record Scooter(string Make, string Model):MotorCycle(Make, Model);
    public record FancyScooter(string Make, string Model, string FancyColor):Scooter(Make, Model);

}
