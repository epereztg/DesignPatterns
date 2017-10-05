using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerReport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVisitable> teamWork = new List<IVisitable>();

            //Create task struture
            //US1
            var us1 = new US(5, "us1");
            us1.Add(new TeamTask(4, "t1"));

            //US2
            var us2 = new US(3, "us2");
            us2.Add(new TeamTask(3, "t2"));

            var f1 = new Feature("Equipo WARRIOR", "Feature1");
            f1.Add(us1);
            f1.Add(us2);


            var epic1 = new Epic(100, "Epic1");
            epic1.Add(f1);

            //Store tasks
            teamWork.Add(epic1);           

            Report report = new Report();
            foreach (var element in teamWork)
            {
                element.Visit(report);
            }

            //// Wait for user
            Console.ReadKey();
        }
    }
}
