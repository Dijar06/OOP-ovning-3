using System;

namespace OOP_Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            p1.metod1 = "Dijar";
            p1.metod2 = "Zejnullahi";

            Console.WriteLine(p1.metod1 + " " + p1.metod2);

            DateTime födelsedatum = new DateTime(2006, 12, 11);
            Console.WriteLine(födelsedatum.ToString());

            Console.WriteLine("Hur gammal är du?");
            p1.ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Myndig: " + p1.myndig());
        }
    }
}