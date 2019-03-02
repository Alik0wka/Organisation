using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class colleagues
    {
        public List<IWorker> team = new List<IWorker>();
        Random rnd = new Random();

        public void createTeam()
        {
            Employee manager777= new Employee(Position.worker);
            manager777.fullName = "Yevgeniy Gertsen";
            manager777.salary = rnd.Next(100000,9999999);
            team.Add(manager777);

            Employee manager1 = new Employee(Position.worker);
            manager1.fullName = "Diass Ospanov";
            manager1.salary = rnd.Next(4000, 7000);
            team.Add(manager1);

            Employee manager2 = new Employee(Position.worker);
            manager2.fullName = "Asslan Askarbek";
            manager2.salary = rnd.Next(1, 10000);
            team.Add(manager2);

            Employee worker1 = new Employee(Position.worker);
            worker1.fullName = "Ruslan Kim";
            worker1.salary = rnd.Next(1500, 2500);
            team.Add(worker1);

            Employee worker2 = new Employee(Position.worker);
            worker2.fullName = "Adlet Konakbayev";
            worker2.salary = rnd.Next(6000, 8000);
            team.Add(worker2);

            Employee worker3 = new Employee(Position.worker);
            worker3.fullName = "Dulat Taigulov";
            worker3.salary = rnd.Next(1, 5);
            team.Add(worker3);
        }

        public void employeeInfo()
        {
        Marker:
            Console.Clear();
            Console.WriteLine("Информация");
            Console.WriteLine("1 - Полная информация");
            Console.WriteLine("2 - Информация по должности");
            Console.WriteLine("3 - Информация по полу");
            int switcher = Int32.Parse(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                    Console.Clear();
                    this.fullInfo();
                    break;
                case 2:
                    PosMark:
                    Console.Clear();
                    Console.WriteLine("1 - Информация о работниках");
                    Console.WriteLine("2 - Информация о менеджерах");
                    int switcherPos = Int32.Parse(Console.ReadLine());
                    switch (switcherPos)
                    {
                        case 1:
                            Console.Clear();
                            this.workersInfo();
                            break;
                        case 2:
                            Console.Clear();
                            this.managersInfo();
                            break;
                        default:
                            Console.Clear();
                            goto PosMark;
                    }
                    
                    break;
                case 3:
                    sexMark:
                    Console.Clear();
                    Console.WriteLine("1 - Информация о мужчинах");
                    Console.WriteLine("2 - Информация о женщинах");
                    int switcherSex = Int32.Parse(Console.ReadLine());
                    switch (switcherSex)
                    {
                        case 1:
                            Console.Clear();
                            this.mansInfo();
                            break;
                        case 2:
                            Console.Clear();
                            this.womansInfo();
                            break;
                        default:
                            Console.Clear();
                            goto sexMark;
                    }
                    break;
                default:
                    Console.Clear();
                    goto Marker;
            }
        }
        public void fullInfo()
        {
            for (int i = 0; i < team.Count; i++)
                team[i].printInfo();
            Console.ReadKey();
        }
        public void workersInfo()
        {
            Console.Clear();
            for (int i = 0; i < team.Count; i++)
                team[i].workerInfo();
            Console.ReadKey();
        }

        public void managersInfo()
        {
            Console.Clear();
            for (int i = 0; i < team.Count; i++)
                team[i].managInfo();
            Console.ReadKey();


        }
        public void mansInfo()
        {
            Console.Clear();
            for (int i = 0; i < team.Count; i++)
                team[i].sexW();
            Console.ReadKey();
        }

        public void womansInfo()
        {
            Console.Clear();
            for (int i = 0; i < team.Count; i++)
                team[i].sexW();
            Console.ReadKey();
        }






    }
}