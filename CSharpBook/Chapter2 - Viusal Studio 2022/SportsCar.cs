using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBook_Chapter2;
public class SportsCar : Car
{
    public string GetPetName()
    {
        PetName = "red";
        return PetName;
    }

}
