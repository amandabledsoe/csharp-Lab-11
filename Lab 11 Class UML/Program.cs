using System;

namespace Lab_11_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();

            a.Name = "Amanda";
            a.Address = "1234 Leisure Drive";
            Console.WriteLine(a.ToString());
            Console.WriteLine("");

            Student b = new Student();

            b.Name = "Alexis";
            b.Address = "4453 Bayview Avenue";
            b.Program = "Nursing";
            b.Year = 2022;
            b.Fee = 15785.59;
            Console.WriteLine(b.ToString());
            Console.WriteLine("");

            Staff c = new Staff();

            c.Name = "Diane";
            c.Address = "17570 Goose Road";
            c.School = "Grand Blanc Middle School West";
            c.Pay = 55459.63;
            Console.WriteLine(c.ToString());
        }
    }
}
