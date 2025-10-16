using Employees;

SalesPerson s = new SalesPerson("George", 1001, 28, 3500, "100-222-123", new DateTime(2024, 08, 01), 3);
Manager m = new Manager("Peter McCallum", 52, 1003, 8420, "111-555-321", new DateTime(2019, 03, 14), 10_000);
double cost = m.GetBenefitCost();
Console.WriteLine(cost);
Employee.BenefitPackage bp = new Employee.BenefitPackage();
Console.WriteLine(bp);
PtSalesPerson pt = new PtSalesPerson("Celia", 21, 1003, 2200, "123-444-213", new DateTime(2025, 09, 01), 0);
s.GiveBonus(300);
m.GiveBonus(500);
pt.GiveBonus(100);
s.DisplayStats();
m.DisplayStats();
pt.DisplayStats();