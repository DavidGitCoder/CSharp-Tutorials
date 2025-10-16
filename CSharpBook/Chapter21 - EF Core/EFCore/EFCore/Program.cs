using AutoLot;

Employee e = new Employee("Marvin", 45, 123, 3500, "111-222-3333", EmployeePayTypeEnum.Hourly, new DateTime(250320240900));
Console.WriteLine(e.Pay);
e.GiveBonus(100);
Console.WriteLine(e.Pay);
e.DisplayStats();
Console.ReadLine();