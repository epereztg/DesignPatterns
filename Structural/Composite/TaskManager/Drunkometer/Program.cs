using System;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a tree structure
            var root = new Composite();

            var feature1 = new Composite();

            //US1
            root.Add(new Leaf(3));
            root.Add(new Leaf(5));
            Console.WriteLine("root");
           root.Display();
         
            //US2
            var comp = new Composite();
            comp.Add(new Leaf (2));
            comp.Add(new Leaf(5));
            Console.WriteLine("comp");
            comp.Display();


            //F1
            feature1.Add(root);
            feature1.Add(comp);
            Console.WriteLine("feature1");
            feature1.Display();


            var epic = new Composite();
            epic.Add(feature1);
            feature1.Display();
            //root.Add(new Leaf("Leaf C"));

            //// Add and remove a leaf
            //var leaf = new Leaf("Leaf D");
            //root.Add(leaf);
            //root.Remove(leaf);

            //// Recursively display tree
            //root.Display(1);

            //// Wait for user
            Console.ReadKey();
        }
    }
}
