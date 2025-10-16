using Employees;

static void CastingExamples()
{
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-111-1111", new DateTime(2013, 10, 01), 5);

    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-111-1321", new DateTime(2013, 10, 05), 1);
    GivePromotion(moonUnit);
    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", new DateTime(), 90);
    GivePromotion(jill);
    Console.WriteLine($"{moonUnit.ToString()}-{moonUnit.GetHashCode()}-{moonUnit.GetType()}");
}
static void GivePromotion(Employee emp)
{

    Console.WriteLine($"{emp.Name} was promoted!");
    switch (emp)
    {
        case SalesPerson s when s.SalesNumber > 5:
            Console.WriteLine($"{emp.Name} made {s.SalesNumber} sales");
            break;
        case Manager m:
            Console.WriteLine($"{emp.Name} had {m.StockOptions} stocks");
            break;
        case Employee _:
            Console.WriteLine($"{emp} is a wrong employee type");
            break;

    }
}
//CastingExamples();

//object[] things = new object[4];
//things[0] = new Hexagon();
//things[1] = false;
//things[2] = new Manager();
//things[3] = "last";

//foreach (object o in things)
//{
//    bool isHex = o is Hexagon;
//    if (!isHex)
//    {
//        Console.WriteLine($"{o} is not an Hexagon");
//    }
//    else
//    {
//        ((Hexagon)o).Draw();
//    }
//}

SalesPerson s = new SalesPerson("George", 1001, 28, 3500, "100-222-123", new DateTime(2024, 08, 01), 3);
Manager m = new Manager("Peter McCallum", 52, 1003, 8420, "111-555-321", new DateTime(2019, 03, 14), 10_000);
double cost = m.GetBenefitCost();
//Console.WriteLine(cost);
Employee.BenefitPackage bp = new Employee.BenefitPackage();
Console.WriteLine(bp);
PtSalesPerson pt = new PtSalesPerson("Celia", 21, 1003, 2200, "123-444-213", new DateTime(2025, 09, 01), 0);
Employee e = s;
s.GiveBonus(300);
m.GiveBonus(500);
pt.GiveBonus(100);
Console.WriteLine(s.ToString());
Console.WriteLine(m.ToString());
Console.WriteLine(pt.ToString());
Console.WriteLine(s.Equals(m));
Console.WriteLine(s.Equals(e));
Console.WriteLine(s.GetHashCode());
Console.WriteLine(m.GetHashCode());
Console.WriteLine(pt.GetHashCode());
Console.WriteLine(e.GetHashCode());
