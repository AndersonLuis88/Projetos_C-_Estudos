using System;
using Predicate.Entities;
using System.Collections.Generic;

namespace Predicate
{
    //Predicate: Representa um método que recebe um objeto 
    //do tipo T e retorna um valor booleano
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 60.00));
            list.Add(new Product("Multifuncional", 350.00));
            list.Add(new Product("HD Externo", 420.00));
            list.Add(new Product("Tablet", 700.00));
            list.Add(new Product("Mouse Pad", 30.00));

            //Lambda InLine
            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);
            foreach (Product p in list){
                Console.WriteLine(p);
            }
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

    }
}
