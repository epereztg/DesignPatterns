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
            //https://www.codeproject.com/Articles/588882/TheplusVisitorplusPatternplusExplained
            //US1
            var root = new Composite();
            root.Add(new TeamTask(3));
            root.Add(new TeamTask(5));
            Console.WriteLine("US1:" + root.Horas());

            //US2
            var comp = new Composite();
            comp.Add(new TeamTask(2));
            comp.Add(new TeamTask(5));
            //Console.WriteLine("comp");
            Console.WriteLine("US2:" + comp.Horas());

            //F1
            var feature1 = new Composite();
            feature1.Add(root);
            feature1.Add(comp);
            Console.WriteLine("feature1:" + feature1.Horas());
           
            //Epic 1
            var epic = new Composite();
            epic.Add(feature1);
            Console.WriteLine("epic:" + epic.Horas());


            //U3
            var US3 = new Composite();
            US3.Add(new TeamTask(2));
            US3.Add(new TeamTask(9));
            Console.WriteLine("US3:" + US3.Horas());

            var US4 = new Composite();
            US4.Add(new TeamTask(1));
            US4.Add(new TeamTask(4));
            US4.Add(new TeamTask(4));
            Console.WriteLine("US4:" + US4.Horas());


            //F2
            var feature2 = new Composite();
            feature2.Add(US3);
            Console.WriteLine("feature2:" + feature2.Horas());


            //F3
            var feature3 = new Composite();
            feature3.Add(US4);
            Console.WriteLine("feature3:" + feature3.Horas());


            //Epic 2
            var epic2 = new Composite();
            epic2.Add(feature2);
            epic2.Add(feature3);
            Console.WriteLine("epic2:" + epic2.Horas());


            //// Wait for user
            Console.ReadKey();
        }
    }
}
