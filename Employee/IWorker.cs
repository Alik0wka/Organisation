using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public enum Position { manager, worker }
    public interface IWorker
    {
        int id { get; }
        string fullName { get; set; }
        double salary { get; set; }
        Position position { get; set; }
        string sex { get; set; }
        void printInfo();

        void sexW();
        void sexM();
        void managInfo();
        void workerInfo();

    }
}
