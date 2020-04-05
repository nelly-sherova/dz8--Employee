using System;

namespace Employee
{
    class Employee
    {
        public string name;
        public string surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public int experience;
        public string position; 
        public double salary;
        public double Nalog()
        {
            return salary*13/100;
        }
        public double Pens()
        {
            return salary/100;
        }
        public double Zarp()
        {
            return salary - Nalog() - Pens();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
