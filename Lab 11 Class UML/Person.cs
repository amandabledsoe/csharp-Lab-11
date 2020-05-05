using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Class_UML
{
    class Person
    {
        private string name;
        private string address;

        public string Name { get; set; }
        public string Address { get; set; }

        public Person() { }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return ($"Person[name={Name},address={Address}]");
        }
    }
}
