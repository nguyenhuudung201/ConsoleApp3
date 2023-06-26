using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PersonManagement
    {
     
        ArrayList listPerson = null;

        public PersonManagement()
        {
            this.listPerson = new ArrayList();
        }
        public void AddPerson()
        {
            Person person = null;
            Console.WriteLine("Choose type: ");
            Console.WriteLine("1. Employee");
            Console.WriteLine("2. Manager");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    person = new Employee();
                    break;
                case 2:
                    person = new Manager();
                    break;
            }

            person.Input();
            person.Display();
            listPerson.Add(person);
        }
        ~PersonManagement()
        {
            Console.WriteLine("Clear List of Person before deleting PersonManagement");
            this.listPerson.Clear();
        }
        public ArrayList getListPerson()
        {
            return this.listPerson;
        }

        public void DisplayAll()
        {
            foreach (Person item in listPerson)
            {
                item.Display();
            }
        }
        public void DisplayBonus()
        {
            foreach (Person item in listPerson)
            {
                item.DisplayBonus();
            }
        }
    }
}
