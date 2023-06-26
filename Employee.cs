using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee : Person

    {
        public Employee() { }
        public override void Display()
        {
            Console.WriteLine("This is Employee");
            Console.WriteLine("Name = {0}, Sin = {1}, Address= {2} , Salary = {3}",
                this.Name, this.Sin, this.Address,this.Salary);
        }

        public override void DisplayBonus()
        {
            Console.WriteLine("Bonus = {0}", Salary * 3);
        }

        public override void Input()
        {
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter Sin: ");
            this.Sin = Console.ReadLine();

            Console.Write("Enter address: ");
            this.Address = Console.ReadLine();

            Console.Write("Enter Salary: ");
            this.Salary = Convert.ToDouble(Console.ReadLine());

        }
    }
}
