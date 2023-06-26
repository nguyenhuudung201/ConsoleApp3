using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Manager : Person
    {
        public Manager() { }
        public string Roll { get; set; }
        public override void Display()
        {
            Console.WriteLine("This is Manager");
            Console.WriteLine("Name = {0}, Sin = {1}, Address= {2} , Salary = {3},Roll = {4}",
                this.Name, this.Sin, this.Address, this.Salary,this.Roll);
        }
        public override void DisplayBonus()
        {
            Console.WriteLine("Bonus = {0}", Salary * 5);
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

            Console.Write("Enter Roll: ");
            this.Roll = Console.ReadLine();
        }
    }
}
