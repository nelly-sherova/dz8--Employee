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
            return Math.Round(salary*13/100,2);
        }
        public double Pens()
        {
            return Math.Round(salary/100,2);
        }
        public double Zarp()
        {
            return Math.Round((salary - Nalog() - Pens()),2);
        }
        public void GetInfo()
        {
            Console.WriteLine($"{surname} {name}");
             if(position == "директор")
            {
                salary = 8000;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
                
            } 
            if(position == "начальник отдела")
            {
                salary = 6000;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            if(position == "бухгалтер")
            {
                salary = 6650.75;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            if(position == "программист")
            {
                salary = 3500;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            if(position == "эксперт")
            {
                salary = 3485.50;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            if(position == "охранник")
            {
                salary = 800;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            if(position == "инкасатор")
            {
                salary = 2800;
                if (experience >= 2 && experience < 4)salary+=250;
                if ( experience >= 4 && experience < 10 )salary+=1000;
                if (experience >=10)salary+=2000;
            }
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Стаж работы: {experience}");
            Console.WriteLine($"Оклад: {salary} сом");
            Console.WriteLine($"Налоговый сбор:(13% налог({Nalog()} сом) + 1% пенсионный фонд {Pens()} сом)");
            Console.WriteLine($"Заработная плата: {Zarp()} сом\n---------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Джордж", "Эрик", "Элианора", "Мэри", "Тайлер", "Шон", "Брендон",};
            string[] surnames = {"Робинсон", "Виллиамс", "Смит", "Гриффен", "Джонсон", "Джеймс","Ландграаб"};
            string[] positions = {"директор", "начальник отдела", "бухгалтер", "программист","эксперт", "охранник", "инкасатор"};
            for ( int i = 0; i<7; i++ )
            {
                Employee rabotnik = new Employee(surnames[i], names[i]);
                rabotnik.experience = new Random().Next(0,20);
                rabotnik.position = positions[i];
                rabotnik.GetInfo();
            }
        }
    }
}
