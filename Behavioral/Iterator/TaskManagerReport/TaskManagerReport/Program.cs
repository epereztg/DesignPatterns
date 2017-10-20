using System;
using System.Collections.Generic;

namespace TaskManagerReport
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<IVisitable> teamWork = new List<IVisitable>();
            TextReport textReport = new TextReport();         

            //*******Create task structure
            //Epic1(Presupuesto 100€)
            // Feature1 (Equipo Warrior)
            //    -US1(5 p)
            //        T1(4h)
            //    - US2(3p)
            //        T2(3h)

            //US1
            var us1 = new Us(5, "us1");
            us1.Add(new TeamTask(4, "t1"));

            //US2
            var us2 = new Us(3, "us2");
            us2.Add(new TeamTask(3, "t2"));

            //US3
            var us3 = new Us(5, "us3");
            us3.Add(new TeamTask(5, "t3"));

            var f1 = new Feature("Equipo WARRIOR", "Feature1");
            f1.Add(us1);
            f1.Add(us2);

            var f2 = new Feature("Equipo Vikings", "Feature2");
            f2.Add(us1);
            f2.Add(us2);
            f2.Add(us3);

            var epic1 = new Epic(100, "Epic1");
            epic1.Add(f1);

            var epic2 = new Epic(200, "Epic2");
            epic2.Add(f2);
            //Store tasks
            teamWork.Add(epic1);
            teamWork.Add(epic2);

            textReport.GenerateIterator(teamWork);

            //// Wait for user
            Console.ReadKey();
        }
    }
}
