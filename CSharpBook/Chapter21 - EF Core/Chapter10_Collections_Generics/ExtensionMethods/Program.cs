using ExtensionMethods;

int myInt = 12345678;
myInt.DisplayDefiningAssembly();

System.Data.DataSet d= new System.Data.DataSet();
d.DisplayDefiningAssembly();

Console.WriteLine(myInt);
Console.WriteLine(myInt.ReverseDigits());