using FunWithLinqExpressions;

ProductInfo[] itemsInStock = {
new ProductInfo {Name="Mac's Coffee", Description="Coffee with TEETH",NumberInStock=24},
new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
};

var subset=from p in itemsInStock where p.NumberInStock>25 select p;

foreach(ProductInfo item in subset)
{
    Console.WriteLine($"Stock > 25 items: {item.Name}");
    Console.WriteLine(item);
}
Console.WriteLine();

PagingWithLINQ(itemsInStock);
Console.WriteLine();

PagingWithChunks(itemsInStock);
Console.WriteLine();

GetNamesAndDesc(itemsInStock);

Console.WriteLine();

GetNamesAndDescriptionTyped(itemsInStock);

Console.WriteLine();
GetUnenumeratedCount(itemsInStock);

static void PagingWithLINQ(ProductInfo[] products)
{
    Console.WriteLine("Paging Operations");
    
    IEnumerable<ProductInfo> list= (from p in products select p).Take(3);
    OutputResults("The first 3", list);

    Console.WriteLine();

    IEnumerable<ProductInfo> listWhile = (from p in products select p).TakeWhile(x=>x.NumberInStock>30);
    OutputResults("All while number in stock > 30", listWhile);


    static void OutputResults(string msg, IEnumerable<ProductInfo> products)
    {
        Console.WriteLine(msg);
        foreach(ProductInfo p in products)
        {
            Console.WriteLine(p);
        }
    }
}

static void PaginWithRanges(ProductInfo[] products)
{
    Console.WriteLine("\nPaging with Ranges");

    IEnumerable<ProductInfo> list = (from p in products select p).Take(..3);
}

static void PagingWithChunks(ProductInfo[] products)
{
    IEnumerable<ProductInfo[]> chunks = products.Chunk(size:2);

    var counter = 0;

    foreach (IEnumerable<ProductInfo> p in chunks)
    {
        OutputResults($"Chunk #{++counter}", p);
    }
    static void OutputResults(string msg, IEnumerable<ProductInfo> products)
    {
        Console.WriteLine(msg);
        foreach (ProductInfo p in products)
        {
            Console.WriteLine(p);
        }
    }

}
static void GetNamesAndDesc(ProductInfo[] products)
{
    var nameDesc=from p 
                 in products 
                 select new { p.Name, p.Description };

    foreach(var item in nameDesc)
    {
        Console.WriteLine(item);
    }

}
static void GetNamesAndDescriptionTyped(ProductInfo[] products)
{
    Console.WriteLine("\nNames & Descriptions:");
    IEnumerable<ProductInfoSmall> nameDesc = from p
                                           in products
                                             select new ProductInfoSmall { Name = p.Name, Description = p.Description };
foreach(ProductInfoSmall p in nameDesc)
    {
        Console.WriteLine(p);
    }
}
static void GetUnenumeratedCount(ProductInfo[] products)
{
    Console.WriteLine("Get Unenumeratord Count");
    IEnumerable<ProductInfo> query = from p in products select p;
    var result = query.TryGetNonEnumeratedCount(out int count);
    if (result)
    {
        Console.WriteLine($"Total count:{count}");
    }
    else
    {
        Console.WriteLine("Try Get Count Failed");
    }
}

static void DisplayDiff()
{
    List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
    List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

    var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

    var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);
    var carUnion= (from c in myCars select c).Union(from c2 in yourCars select c2);

    var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);


    foreach (string car in carConcat) {
        Console.WriteLine($"I am: {car}");
    }
}
DisplayDiff();

static void DisplayDiffBySelector()
{
    var first = new (string Name, int Age)[] { ("Francis", 20), ("Lindsey", 30), ("Ashley", 40) };//array of tuples
    var second = new (string Name, int Age)[] { ("Claire", 30), ("Pat", 30), ("Drew", 33) };
    var result = first.ExceptBy(second.Select(x => x.Age), product => product.Age);
    Console.WriteLine("Except for by selector: ");
    foreach(var item in result)
    {
        Console.WriteLine(item);
    }

}
DisplayDiffBySelector();
static void DisplayIntersectionBySelector()
{
    var first = new (string Name, int Age)[] { ("Francis", 20), ("Lindsey", 30), ("Ashley", 40) };
    var second = new (string Name, int Age)[] { ("Claire", 30), ("Pat", 30), ("Drew", 33) };

    var result = first.IntersectBy(second.Select(x => x.Age), person => person.Age);
    
    Console.WriteLine("Intersection by selector:");
    foreach (var item in result)
    {
        Console.WriteLine(item); // { ("Lindsey", 30) }
    }
}
DisplayIntersectionBySelector();