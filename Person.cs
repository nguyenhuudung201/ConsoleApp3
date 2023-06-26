using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Person
    {
        public string Name { get; set; }    
        public string Address { get; set; }
        public string Sin { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public abstract void Input();

        public abstract void Display();
        public abstract void DisplayBonus();
    }
}
