using System;
using System.Reflection.Metadata.Ecma335;
namespace FunWithLinqExpressions
{
    class ProductInfoSmall
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public override string ToString()
        {
            return $"Name = {Name}, Description = {Description}";
        }
        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descrptions: ");
            IEnumerable<ProductInfoSmall> nameDesc = 
            from p in products select new ProductInfoSmall
            {Name = p.Name, Description = p.Description};
            foreach(ProductInfoSmall item in nameDesc)
            {
                Console.WriteLine(item);
            }
        }
    }
}