using System;

namespace TaskManagerReport
{
    class JSONReport : IVisitor
    {
        //public void Visit(IVisitor visitor)
        //{
        //    //foreach (var component in visitor.children)
        //    //{
        //    //    Console.WriteLine("{0}", visitor.Display());
        //    //}
        //}

        public void Visit(Epic epic)
        {
            //Console.WriteLine("{0}", epic.Display());

            var display = "{\n type:”epic”,\n description: “Epic1 \n";
            Console.WriteLine("{0}", display);
        }

        public void Visit(Feature task)
        {
            //var display = "{type: epic,description: epic.name,features: [";
            var display = "\t features: [\n { type: feature,\n description:" + task.name + "By: Warriors";
            Console.WriteLine("{0}", display);
        }

        public void Visit(US task)
        {
            //var display = "{type: epic,description: epic.name,features: [";
            var display = "UserHistories: [{\n"
                          + "type: UserHistory,"
                          + "description: US1,"
                          + "historyPoints: 5"
                          + "tasks:["
                          + "{"
                          + "type:Task,"
                          + "description: T1,"
                          + "hours4"
                          + "}"
                          + "]"
                          + "}";
            //{
            //    type:UserHistory,
            //    description: US2,
            //    historyPoints: 3
            //    tasks:[
            //    {
            //        type:Task,
            //        description: T2,
            //        hours3
            //    }
            //    ]
            //}


            //]";

            Console.WriteLine("{0}", display);
        }

        public void Visit(TeamTask task)
        {
            var display = "tasks:["
            + "{"
              + "type:Task,"
              + "description: T2,"
              + "hours3"
            + "}"
            + "]";
            Console.WriteLine("{0}", display);
        }
    }
}
