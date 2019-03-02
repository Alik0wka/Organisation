using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee : IWorker
    {
        public Employee(Position position)
        {
            this.position = position;
        }
        public string fullName { get; set; }
        public double salary { get; set; }
        public Position position { get; set; }
        public int id { get; private set; }
        public string sex { get; set; }

        public void printInfo()
        {
            Console.WriteLine("---------------\n{0}\n{1}\nЗарплата: {2}\nДолжность: {3} Пол: ",
                id, fullName, salary, position);
            if (sex == "m")
                Console.Write("Мужчина\n---------------");
            else Console.Write("Женщина\n---------------");

        }


        public void sexM()
        {
            if (sex == "m")
            {
                Console.WriteLine("---------------\n{0}\n{1}\nЗарплата: {2}\nДолжность: {3} Пол: ",
                id, fullName, salary, position);
            }
            else
            {
                Console.WriteLine("---------------\n{0}\n{1}\nЗарплата: {2}\nДолжность: {3} Пол: ",
                   id, fullName, salary, position);
            }
        }

        public void sexW()
        {
            if (sex == "w")
            {
                Console.WriteLine("---------------\n{0}\n{1}\nЗарплата: {2}\nДолжность: {3} Пол: ",
                id, fullName, salary, position);
            }
            else
            {
                Console.WriteLine("---------------\n{0}\n{1}\nЗарплата: {2}\nДолжность: {3} Пол: ",
                   id, fullName, salary, position);
            }
        }

        public void managInfo()
        {
            if (position == Position.manager)
                this.printInfo();
            else throw new Exception("Увы, нет у нас менеджеров, много процентов берут");
        }
        public void workerInfo()
        {
            if (position == Position.worker)
                this.printInfo();
            else throw new Exception("Увы, нет у нас работников, роботы захватят мир!");
        }



    }
}
