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
            JSONReport jsonReport = new JSONReport();
            
            //Create task structure
            //US1
            var us1 = new US(5, "us1");
            us1.Add(new TeamTask(4, "t1"));

            //US2
            var us2 = new US(3, "us2");
            us2.Add(new TeamTask(3, "t2"));

            var f1 = new Feature("Equipo WARRIOR", "Feature1");
            f1.Add(us1);
            f1.Add(us2);

            var f2 = new Feature("Equipo WARRIOR2", "Feature2");
            f2.Add(us1);
            f2.Add(us2);

            var epic1 = new Epic(100, "Epic1");
            epic1.Add(f1);

            var epic2 = new Epic(200, "Epic2");
            epic2.Add(f2);
            //Store tasks
            teamWork.Add(epic1);
            teamWork.Add(epic2);

            textReport.Generate(teamWork);
            //jsonReport.Generate(teamWork);           

            //// Wait for user
            Console.ReadKey();
        }
    }
}
