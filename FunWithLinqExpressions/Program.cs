using System;
using FunWithLinqExpressions;

Console.WriteLine("***** Fun With Query Expressions *****");
ProductInfo[] itemsInStock = {
    new ProductInfo {Name = "Mac's Coffe",
        Description = "Coffe with TEETH", NumberInStock = 24},
    new ProductInfo {Name = "Milk Maid Mill",
        Description = "Milk cow's like", NumberInStock = 100},
    new ProductInfo {Name = "Pure Silk Tofu",
        Description = "Bland as Possible", NumberInStock = 120},
    new ProductInfo {Name = "Crunchy Pops",
        Description = "Chezzy, peppery goodness", NumberInStock = 2},
    new ProductInfo {Name = "RipOff",
        Description = "From the tap of your wallet", NumberInStock = 100},
    new ProductInfo {Name = "Classic Valpo Pizza",
        Description = "Everyone loves pizza!", NumberInStock = 73}
};
SelectEverything(itemsInStock);
ListProductNames(itemsInStock);
GetOverstock(itemsInStock);
ReverseEverything(itemsInStock);
AlphabetizeProductNames(itemsInStock);
Array objs = GetNamesAndDescriptions(itemsInStock);
foreach (object o in objs)
{
    Console.WriteLine(o);
}

static void SelectEverything(ProductInfo[] products)
{
    Console.WriteLine("\nAll product details:\n");
    var allProducts = from p in products select p;
    foreach (var prod in allProducts)
    {
        Console.WriteLine(prod);
    }
}
static void ListProductNames(ProductInfo[] products)
{
    Console.WriteLine("\nOnly product Name:\n");
    IEnumerable<string> prodNames = from p in products select p.Name;
    foreach (string p in prodNames)
    {
        Console.WriteLine(p);
    }
}
static void GetOverstock(ProductInfo[] products)
{
    Console.WriteLine("\nThe overstock items!\n");
    var overstock = from p in products where p.NumberInStock > 25 select p;
    foreach (var prod in overstock)
    {
        Console.WriteLine(prod);
    }
}
static Array GetNamesAndDescriptions(ProductInfo[] products)
{
    Console.WriteLine("\nNames and Descriptions: ");
    var nameDesc = from p in products select new { p.Name, p.Description };
    foreach (var i in nameDesc)
    {
        Console.WriteLine(i);
    }
    return nameDesc.ToArray();
}
static void ReverseEverything(ProductInfo[] products)
{
    Console.WriteLine("Product in reverse:");
    var allProducts = from p in products select p;
    foreach (var prod in allProducts.Reverse())
    {
        Console.WriteLine(prod.ToString());
    }
}
static void AlphabetizeProductNames(ProductInfo[] products)
{
    var subset = from p in products orderby p.Name select p;
    Console.WriteLine("Ordered by Name:");
    foreach (var p in subset)
    {
        Console.WriteLine(p.ToString());
    }
}
