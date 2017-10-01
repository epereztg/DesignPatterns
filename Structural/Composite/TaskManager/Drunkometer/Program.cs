using System;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //US1
            var root = new Composite();
            root.Add(new Leaf(3));
            root.Add(new Leaf(5));
            Console.WriteLine("US1:" + root.Horas());

            //US2
            var comp = new Composite();
            comp.Add(new Leaf(2));
            comp.Add(new Leaf(5));
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
            US3.Add(new Leaf(2));
            US3.Add(new Leaf(9));
            Console.WriteLine("US3:" + US3.Horas());

            var US4 = new Composite();
            US4.Add(new Leaf(1));
            US4.Add(new Leaf(4));
            US4.Add(new Leaf(4));
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
