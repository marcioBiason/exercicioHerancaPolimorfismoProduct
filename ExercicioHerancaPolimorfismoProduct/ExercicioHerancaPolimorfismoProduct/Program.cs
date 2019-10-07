using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioHerancaPolimorfismoProduct.Entities;

namespace ExercicioHerancaPolimorfismoProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int nOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nOfProducts; i++)
            {
                Console.WriteLine("Product #{0} data:",i);
                Console.Write("Common, used or imported: ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime dateManufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, dateManufacture));
                }
                else
                {
                    list.Add(new Product(name, price));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
