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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
