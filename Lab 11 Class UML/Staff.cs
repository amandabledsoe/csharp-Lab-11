using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_Class_UML
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School { get; set; }
        public double Pay { get; set; }

        public Staff() { }
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return ($"Staff[Person[name={Name},address={Address}," +
                $"school={School},pay={Pay}");
        }
    }
}
