using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Class_UML
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student() { }

        public Student(string program, int year, double fee, string name, string address) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return ($"Student[Person[name={Name},address={Address}," +
                $"program={Program},year={Year},fee={Fee}");
        }
    }
}
