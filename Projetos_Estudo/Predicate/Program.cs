using System;
using Predicate.Entities;
using System.Collections.Generic;
using System.Linq;

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

            
            
            //Example Func com Lambda
            //Func<Product, string> func = p => p.Name.ToUpper();

            //Example Func referência Indireta
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //Example Func referência direta
            List<string> result = list.Select(NameUpper).ToList();


            //Example actions
            //list.ForEach(UpdatePrice);

            //Action<Product> act = UpdatePrice;
            //list.ForEach(act);


            //Actions with Lambdas
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };


            //Example Predicate
            //Lambda InLine
            //list.RemoveAll(p => p.Price >= 100.0);
            //list.RemoveAll(ProductTest); //Predicate


            //Output Data

            //foreach (Product p in list){
            //    Console.WriteLine(p);
            //}
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }

    }
}
