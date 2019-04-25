using System;
using System.Collections.Generic;
using System.IO;
using Projeto_IComparable.Entities;

namespace Projeto_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Home\Documents\GitHub\00.Projetos_C#_Estudos\Projeto_IComparable\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                
                }
            Console.ReadLine();
        }
    }
}
